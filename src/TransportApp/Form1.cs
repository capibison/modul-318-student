using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        ITransport transport = new Transport();

        //
        //
        //
        //
        //
        //
        //ANFANG REISEN GROUP BOX



        private void groupBoxReisen_Enter(object sender, EventArgs e)
        {
        }

        private void buttonReisen_Click(object sender, EventArgs e)
        {
            groupBoxReisen.Visible = true;
            groupBoxAbfahrtstafel.Visible = false;
            //groupBoxNaheStationen.Visible = false;
            //groupBoxStationSuche.Visible = false;
        }

        private void buttonNaheStationen_Click(object sender, EventArgs e)
        {
            groupBoxReisen.Visible = false;
            groupBoxAbfahrtstafel.Visible = false;
            //groupBoxNaheStationen.Visible = true;
            //groupBoxStationSuche.Visible = false;
        }

        private void buttonAbfahrtstafel_Click(object sender, EventArgs e)
        {
            groupBoxReisen.Visible = false;
            groupBoxAbfahrtstafel.Visible = true;
            //groupBoxNaheStationen.Visible = false;
            //groupBoxStationSuche.Visible = false;
        }
        private void buttonStationSuche_Click(object sender, EventArgs e)
        {
            groupBoxReisen.Visible = false;
            groupBoxAbfahrtstafel.Visible = false;
            //groupBoxNaheStationen.Visible = false;
            //groupBoxStationSuche.Visible = true;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDownHour_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDownMinutes_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDownVerbindungen_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewVerbindungen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBoxStartPos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Station[] stationsArr = transport.GetStations(comboBoxStartPos.Text).StationList.ToArray();
                foreach (Station station in stationsArr)
                {
                    comboBoxStartPos.Items.Add(station.Name);
                }

            }
            catch
            {
                //Nicht schön, ist mir bewusst, aber löst eine "unnötige" Exception aus.
                //Löst nullpointer aus. Grund:Sobald man einen Text in der Combobox eingegeben und wiederkomplett gelöscht hat, stand der Wert bei null. Null ist  
                //laut APi unzulässig Grundsätzlich ist die exception auch nicht schlecht, aber Verbindung lässt sich ohne Station nicht suchen, daher ist ein  
                //Abbruch der Programms nicht notwendig und i.O. wenn es einfach weiterläfuft
            }
        }

        private void comboBoxEndPos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Station[] stationsArr = transport.GetStations(comboBoxEndPos.Text).StationList.ToArray();
                foreach (Station station in stationsArr)
                {
                    comboBoxEndPos.Items.Add(station.Name);
                }

            }
            catch
            {
                //Nicht schön, ist mir bewusst, aber löst eine "unnötige" Exception aus.
                //Löst nullpointer aus. Grund:Sobald man einen Text in der Combobox eingegeben und wiederkomplett gelöscht hat, stand der Wert bei null. Null ist  
                //laut APi unzulässig Grundsätzlich ist die exception auch nicht schlecht, aber Verbindung lässt sich ohne Station nicht suchen, daher ist ein  
                //Abbruch der Programms nicht notwendig und i.O. wenn es einfach weiterläfuft
            }
        }

        private void buttonClearReisen_Click(object sender, EventArgs e)
        {
            dataGridViewVerbindungen.Rows.Clear();
            dataGridViewVerbindungen.Refresh();
        }

        private void buttonVerbindungSuchen_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            time = evaluateDateTime(time);

            if (comboBoxStartPos.SelectedItem != null && comboBoxEndPos.SelectedItem != null)
            {
                string userStartPos = comboBoxStartPos.SelectedItem.ToString();
                string userEndPos = comboBoxEndPos.SelectedItem.ToString();

                int columnCounter = Decimal.ToInt32(numericUpDownVerbindungen.Value);

                Connections connections = transport.GetConnections(userStartPos, userEndPos, columnCounter);

                //Dies sollte die Zeiteingabe managen, aber funktioniert nicht. Auskommentiert, weil es ansonsten die gesamte Verbindungssuche behindern würde.
                //int j = 0;
                //do
                //{
                //    connections.ConnectionList.RemoveAt(j);
                //    j++;
                //} while (connections.ConnectionList[j].From.Departure < time);

                for (int i = 0; i < columnCounter; i++)
                {
                    printData(i, userStartPos, userEndPos, connections);
                }
            }
        }

        public DateTime evaluateDateTime(DateTime time)
        {
            int hour = Convert.ToInt32(numericUpDownHour.Value);
            int minutes = Convert.ToInt32(numericUpDownMinutes.Value);
            time = new DateTime(dateTimePickerReise.Value.Year, dateTimePickerReise.Value.Month, dateTimePickerReise.Value.Day, hour, minutes, 0);

            if (time > DateTime.Now)
            {
                return time;
            }
            else
            {
                return DateTime.Now;
            }
        }

        public void printData(int i, string userStartPos, string userEndPos, Connections connections)
        {
            dataGridViewVerbindungen.Rows.Add();
            dataGridViewVerbindungen.Rows[i].Cells[0].Value = userStartPos;
            dataGridViewVerbindungen.Rows[i].Cells[1].Value = userEndPos;
            dataGridViewVerbindungen.Rows[i].Cells[2].Value = connections.ConnectionList[i].Duration;
            dataGridViewVerbindungen.Rows[i].Cells[3].Value = connections.ConnectionList[i].From.Departure;
            dataGridViewVerbindungen.Rows[i].Cells[4].Value = connections.ConnectionList[i].To.Arrival;
        }

        //ENDE REISEN GROUPBOX
        //
        //
        //
        //
        //
        //ANFANG ABFAHRTSTAFEL GROUPBOX

        private void comboBoxAbfahrtstafel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Station[] stationsArr = transport.GetStations(comboBoxAbfahrtstafel.Text).StationList.ToArray();
                foreach (Station station in stationsArr)
                {
                    comboBoxAbfahrtstafel.Items.Add(station.Name);
                }

            }
            catch
            {
                //Nicht schön, ist mir bewusst, aber löst eine "unnötige" Exception aus.
                //Löst nullpointer aus. Grund:Sobald man einen Text in der Combobox eingegeben und wiederkomplett gelöscht hat, stand der Wert bei null. Null ist  
                //laut APi unzulässig Grundsätzlich ist die exception auch nicht schlecht, aber Verbindung lässt sich ohne Station nicht suchen, daher ist ein  
                //Abbruch der Programms nicht notwendig und i.O. wenn es einfach weiterläfuft
            }
        }

        private void buttonVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            if (comboBoxAbfahrtstafel.SelectedItem != null)
            {
                foreach(StationBoard connection in transport.GetStationBoard(comboBoxAbfahrtstafel.Text).Entries)
                {
                    dataGridViewAbfahrtstafel.Rows.Add(connection.To, connection.Stop.Departure);
                }
            }
        }
    }
}
