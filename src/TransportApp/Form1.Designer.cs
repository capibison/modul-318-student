
namespace TransportApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStationSuche = new System.Windows.Forms.Button();
            this.buttonReisen = new System.Windows.Forms.Button();
            this.buttonNaheStationen = new System.Windows.Forms.Button();
            this.buttonAbfahrtstafel = new System.Windows.Forms.Button();
            this.groupBoxReisen = new System.Windows.Forms.GroupBox();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.comboBoxEndPos = new System.Windows.Forms.ComboBox();
            this.comboBoxStartPos = new System.Windows.Forms.ComboBox();
            this.buttonClearReisen = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.dataGridViewVerbindungen = new System.Windows.Forms.DataGridView();
            this.Startstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownVerbindungen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerReise = new System.Windows.Forms.DateTimePicker();
            this.buttonVerbindungSuch = new System.Windows.Forms.Button();
            this.groupBoxAbfahrtstafel = new System.Windows.Forms.GroupBox();
            this.comboBoxAbfahrtstafel = new System.Windows.Forms.ComboBox();
            this.dataGridViewAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonVerbindungenSuchen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.groupBoxReisen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerbindungen)).BeginInit();
            this.groupBoxAbfahrtstafel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbfahrtstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.buttonStationSuche, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonReisen, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonNaheStationen, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonAbfahrtstafel, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(1, 1013);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(879, 136);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // buttonStationSuche
            // 
            this.buttonStationSuche.Location = new System.Drawing.Point(660, 3);
            this.buttonStationSuche.Name = "buttonStationSuche";
            this.buttonStationSuche.Size = new System.Drawing.Size(213, 130);
            this.buttonStationSuche.TabIndex = 3;
            this.buttonStationSuche.Text = "Wo ist meine Station";
            this.buttonStationSuche.UseVisualStyleBackColor = true;
            this.buttonStationSuche.Click += new System.EventHandler(this.buttonStationSuche_Click);
            // 
            // buttonReisen
            // 
            this.buttonReisen.Location = new System.Drawing.Point(441, 3);
            this.buttonReisen.Name = "buttonReisen";
            this.buttonReisen.Size = new System.Drawing.Size(213, 130);
            this.buttonReisen.TabIndex = 2;
            this.buttonReisen.Text = "Reisen";
            this.buttonReisen.UseVisualStyleBackColor = true;
            this.buttonReisen.Click += new System.EventHandler(this.buttonReisen_Click);
            // 
            // buttonNaheStationen
            // 
            this.buttonNaheStationen.Location = new System.Drawing.Point(222, 3);
            this.buttonNaheStationen.Name = "buttonNaheStationen";
            this.buttonNaheStationen.Size = new System.Drawing.Size(213, 130);
            this.buttonNaheStationen.TabIndex = 1;
            this.buttonNaheStationen.Text = "Stationen in der Nähe";
            this.buttonNaheStationen.UseVisualStyleBackColor = true;
            this.buttonNaheStationen.Click += new System.EventHandler(this.buttonNaheStationen_Click);
            // 
            // buttonAbfahrtstafel
            // 
            this.buttonAbfahrtstafel.Location = new System.Drawing.Point(3, 3);
            this.buttonAbfahrtstafel.Name = "buttonAbfahrtstafel";
            this.buttonAbfahrtstafel.Size = new System.Drawing.Size(213, 130);
            this.buttonAbfahrtstafel.TabIndex = 0;
            this.buttonAbfahrtstafel.Text = "Abfahrtstafel";
            this.buttonAbfahrtstafel.UseVisualStyleBackColor = true;
            this.buttonAbfahrtstafel.Click += new System.EventHandler(this.buttonAbfahrtstafel_Click);
            // 
            // groupBoxReisen
            // 
            this.groupBoxReisen.Controls.Add(this.numericUpDownMinutes);
            this.groupBoxReisen.Controls.Add(this.numericUpDownHour);
            this.groupBoxReisen.Controls.Add(this.comboBoxEndPos);
            this.groupBoxReisen.Controls.Add(this.comboBoxStartPos);
            this.groupBoxReisen.Controls.Add(this.buttonClearReisen);
            this.groupBoxReisen.Controls.Add(this.labelError);
            this.groupBoxReisen.Controls.Add(this.dataGridViewVerbindungen);
            this.groupBoxReisen.Controls.Add(this.label6);
            this.groupBoxReisen.Controls.Add(this.label5);
            this.groupBoxReisen.Controls.Add(this.numericUpDownVerbindungen);
            this.groupBoxReisen.Controls.Add(this.label4);
            this.groupBoxReisen.Controls.Add(this.label3);
            this.groupBoxReisen.Controls.Add(this.label2);
            this.groupBoxReisen.Controls.Add(this.label1);
            this.groupBoxReisen.Controls.Add(this.dateTimePickerReise);
            this.groupBoxReisen.Controls.Add(this.buttonVerbindungSuch);
            this.groupBoxReisen.Location = new System.Drawing.Point(30, 24);
            this.groupBoxReisen.Name = "groupBoxReisen";
            this.groupBoxReisen.Size = new System.Drawing.Size(817, 956);
            this.groupBoxReisen.TabIndex = 20;
            this.groupBoxReisen.TabStop = false;
            this.groupBoxReisen.Text = "Reisen";
            this.groupBoxReisen.Visible = false;
            this.groupBoxReisen.Enter += new System.EventHandler(this.groupBoxReisen_Enter);
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(745, 298);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(42, 27);
            this.numericUpDownMinutes.TabIndex = 39;
            this.numericUpDownMinutes.ValueChanged += new System.EventHandler(this.numericUpDownMinutes_ValueChanged);
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(686, 298);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(42, 27);
            this.numericUpDownHour.TabIndex = 38;
            this.numericUpDownHour.ValueChanged += new System.EventHandler(this.numericUpDownHour_ValueChanged);
            // 
            // comboBoxEndPos
            // 
            this.comboBoxEndPos.FormattingEnabled = true;
            this.comboBoxEndPos.Location = new System.Drawing.Point(121, 88);
            this.comboBoxEndPos.Name = "comboBoxEndPos";
            this.comboBoxEndPos.Size = new System.Drawing.Size(666, 28);
            this.comboBoxEndPos.TabIndex = 37;
            this.comboBoxEndPos.TextChanged += new System.EventHandler(this.comboBoxEndPos_TextChanged);
            // 
            // comboBoxStartPos
            // 
            this.comboBoxStartPos.FormattingEnabled = true;
            this.comboBoxStartPos.Location = new System.Drawing.Point(121, 48);
            this.comboBoxStartPos.Name = "comboBoxStartPos";
            this.comboBoxStartPos.Size = new System.Drawing.Size(666, 28);
            this.comboBoxStartPos.TabIndex = 36;
            this.comboBoxStartPos.TextChanged += new System.EventHandler(this.comboBoxStartPos_TextChanged);
            // 
            // buttonClearReisen
            // 
            this.buttonClearReisen.Location = new System.Drawing.Point(537, 131);
            this.buttonClearReisen.Name = "buttonClearReisen";
            this.buttonClearReisen.Size = new System.Drawing.Size(75, 29);
            this.buttonClearReisen.TabIndex = 35;
            this.buttonClearReisen.Text = "Clear";
            this.buttonClearReisen.UseVisualStyleBackColor = true;
            this.buttonClearReisen.Click += new System.EventHandler(this.buttonClearReisen_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelError.Location = new System.Drawing.Point(121, 159);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 31);
            this.labelError.TabIndex = 34;
            // 
            // dataGridViewVerbindungen
            // 
            this.dataGridViewVerbindungen.AllowUserToAddRows = false;
            this.dataGridViewVerbindungen.AllowUserToDeleteRows = false;
            this.dataGridViewVerbindungen.AllowUserToResizeColumns = false;
            this.dataGridViewVerbindungen.AllowUserToResizeRows = false;
            this.dataGridViewVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Startstation,
            this.Endstation,
            this.Duration,
            this.Abfahrtszeit,
            this.Ankunftszeit});
            this.dataGridViewVerbindungen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewVerbindungen.Location = new System.Drawing.Point(24, 372);
            this.dataGridViewVerbindungen.Name = "dataGridViewVerbindungen";
            this.dataGridViewVerbindungen.RowHeadersWidth = 51;
            this.dataGridViewVerbindungen.RowTemplate.Height = 29;
            this.dataGridViewVerbindungen.Size = new System.Drawing.Size(775, 557);
            this.dataGridViewVerbindungen.TabIndex = 33;
            this.dataGridViewVerbindungen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVerbindungen_CellContentClick);
            // 
            // Startstation
            // 
            this.Startstation.HeaderText = "Startstation";
            this.Startstation.MaxInputLength = 50;
            this.Startstation.MinimumWidth = 75;
            this.Startstation.Name = "Startstation";
            this.Startstation.ReadOnly = true;
            this.Startstation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Startstation.Width = 125;
            // 
            // Endstation
            // 
            this.Endstation.HeaderText = "Endstation";
            this.Endstation.MaxInputLength = 50;
            this.Endstation.MinimumWidth = 75;
            this.Endstation.Name = "Endstation";
            this.Endstation.ReadOnly = true;
            this.Endstation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Endstation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Endstation.Width = 125;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Reisedauer";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 125;
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.Abfahrtszeit.MaxInputLength = 10;
            this.Abfahrtszeit.MinimumWidth = 50;
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            this.Abfahrtszeit.ReadOnly = true;
            this.Abfahrtszeit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Abfahrtszeit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Abfahrtszeit.Width = 175;
            // 
            // Ankunftszeit
            // 
            this.Ankunftszeit.HeaderText = "Ankunftszeit";
            this.Ankunftszeit.MaxInputLength = 10;
            this.Ankunftszeit.MinimumWidth = 50;
            this.Ankunftszeit.Name = "Ankunftszeit";
            this.Ankunftszeit.ReadOnly = true;
            this.Ankunftszeit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ankunftszeit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Ankunftszeit.Width = 175;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(734, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Anzahl Verbindungen";
            // 
            // numericUpDownVerbindungen
            // 
            this.numericUpDownVerbindungen.Location = new System.Drawing.Point(30, 264);
            this.numericUpDownVerbindungen.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownVerbindungen.Name = "numericUpDownVerbindungen";
            this.numericUpDownVerbindungen.Size = new System.Drawing.Size(64, 27);
            this.numericUpDownVerbindungen.TabIndex = 29;
            this.numericUpDownVerbindungen.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownVerbindungen.ValueChanged += new System.EventHandler(this.numericUpDownVerbindungen_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Abfahrtsdatum/-zeit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Endstation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Startstation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Start- / Endstation";
            // 
            // dateTimePickerReise
            // 
            this.dateTimePickerReise.Location = new System.Drawing.Point(537, 264);
            this.dateTimePickerReise.Name = "dateTimePickerReise";
            this.dateTimePickerReise.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerReise.TabIndex = 23;
            this.dateTimePickerReise.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // buttonVerbindungSuch
            // 
            this.buttonVerbindungSuch.Location = new System.Drawing.Point(618, 131);
            this.buttonVerbindungSuch.Name = "buttonVerbindungSuch";
            this.buttonVerbindungSuch.Size = new System.Drawing.Size(169, 29);
            this.buttonVerbindungSuch.TabIndex = 22;
            this.buttonVerbindungSuch.Text = "Verbindung suchen";
            this.buttonVerbindungSuch.UseVisualStyleBackColor = true;
            this.buttonVerbindungSuch.Click += new System.EventHandler(this.buttonVerbindungSuchen_Click);
            // 
            // groupBoxAbfahrtstafel
            // 
            this.groupBoxAbfahrtstafel.Controls.Add(this.comboBoxAbfahrtstafel);
            this.groupBoxAbfahrtstafel.Controls.Add(this.dataGridViewAbfahrtstafel);
            this.groupBoxAbfahrtstafel.Controls.Add(this.buttonVerbindungenSuchen);
            this.groupBoxAbfahrtstafel.Controls.Add(this.label7);
            this.groupBoxAbfahrtstafel.Location = new System.Drawing.Point(30, 24);
            this.groupBoxAbfahrtstafel.Name = "groupBoxAbfahrtstafel";
            this.groupBoxAbfahrtstafel.Size = new System.Drawing.Size(817, 956);
            this.groupBoxAbfahrtstafel.TabIndex = 35;
            this.groupBoxAbfahrtstafel.TabStop = false;
            this.groupBoxAbfahrtstafel.Text = "Abfahrtstafel";
            this.groupBoxAbfahrtstafel.Visible = false;
            // 
            // comboBoxAbfahrtstafel
            // 
            this.comboBoxAbfahrtstafel.FormattingEnabled = true;
            this.comboBoxAbfahrtstafel.Location = new System.Drawing.Point(125, 85);
            this.comboBoxAbfahrtstafel.Name = "comboBoxAbfahrtstafel";
            this.comboBoxAbfahrtstafel.Size = new System.Drawing.Size(654, 28);
            this.comboBoxAbfahrtstafel.TabIndex = 40;
            this.comboBoxAbfahrtstafel.TextChanged += new System.EventHandler(this.comboBoxAbfahrtstafel_TextChanged);
            // 
            // dataGridViewAbfahrtstafel
            // 
            this.dataGridViewAbfahrtstafel.AllowUserToAddRows = false;
            this.dataGridViewAbfahrtstafel.AllowUserToDeleteRows = false;
            this.dataGridViewAbfahrtstafel.AllowUserToResizeColumns = false;
            this.dataGridViewAbfahrtstafel.AllowUserToResizeRows = false;
            this.dataGridViewAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridViewAbfahrtstafel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAbfahrtstafel.Location = new System.Drawing.Point(19, 176);
            this.dataGridViewAbfahrtstafel.Name = "dataGridViewAbfahrtstafel";
            this.dataGridViewAbfahrtstafel.RowHeadersWidth = 51;
            this.dataGridViewAbfahrtstafel.RowTemplate.Height = 29;
            this.dataGridViewAbfahrtstafel.Size = new System.Drawing.Size(775, 753);
            this.dataGridViewAbfahrtstafel.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Startstation";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn5.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Endstation";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn6.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Reisedauer";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Abfahrtszeit";
            this.dataGridViewTextBoxColumn8.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn8.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Ankunftszeit";
            this.dataGridViewTextBoxColumn9.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn9.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // buttonVerbindungenSuchen
            // 
            this.buttonVerbindungenSuchen.Location = new System.Drawing.Point(306, 121);
            this.buttonVerbindungenSuchen.Name = "buttonVerbindungenSuchen";
            this.buttonVerbindungenSuchen.Size = new System.Drawing.Size(169, 29);
            this.buttonVerbindungenSuchen.TabIndex = 36;
            this.buttonVerbindungenSuchen.Text = "Verbindungen suchen";
            this.buttonVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.buttonVerbindungenSuchen.Click += new System.EventHandler(this.buttonVerbindungenSuchen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Startstation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 1153);
            this.Controls.Add(this.groupBoxAbfahrtstafel);
            this.Controls.Add(this.groupBoxReisen);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel.ResumeLayout(false);
            this.groupBoxReisen.ResumeLayout(false);
            this.groupBoxReisen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerbindungen)).EndInit();
            this.groupBoxAbfahrtstafel.ResumeLayout(false);
            this.groupBoxAbfahrtstafel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbfahrtstafel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonStationSuche;
        private System.Windows.Forms.Button buttonReisen;
        private System.Windows.Forms.Button buttonNaheStationen;
        private System.Windows.Forms.Button buttonAbfahrtstafel;
        private System.Windows.Forms.GroupBox groupBoxReisen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownVerbindungen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerReise;
        private System.Windows.Forms.Button buttonVerbindungSuch;
        private System.Windows.Forms.DataGridView dataGridViewVerbindungen;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.GroupBox groupBoxAbfahrtstafel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonVerbindungenSuchen;
        private System.Windows.Forms.Button buttonClearReisen;
        private System.Windows.Forms.DataGridView dataGridViewAbfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Startstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftszeit;
        private System.Windows.Forms.ComboBox comboBoxEndPos;
        private System.Windows.Forms.ComboBox comboBoxStartPos;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.ComboBox comboBoxAbfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

