﻿namespace SwissTransport.Core
{
    using System.Threading.Tasks;
    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id);

        StationBoardRoot GetStationBoard(string station);

        Connections GetConnections(string fromStation, string toStation, decimal limit);

        Connections GetConnections(string fromStation, string toStation);
    }
}