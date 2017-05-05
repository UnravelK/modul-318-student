using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Connections
    {
        [JsonProperty("connections")]
        public List<Connection> ConnectionList { get; set; }
    }
    /// <summary>
    /// Enthält formatierte Informationen über eine Verbindung.
    /// </summary>
    public class ConnectionInfo
    {
        private Connection _Connection;
        public string _travelDuration;
        public string _departureTime;
        public string _arrivalTime;
        public string _startStationName;
        public string _endStationName;
        public string _startPlatform;

        /// <summary>
        /// Formatiert die mitgegebenen Informationen.
        /// </summary>
        /// <param name="Connection">Die Verbindung von welcher Infos angezeigt werden sollen.</param>
        public ConnectionInfo(Connection Connection)
        {
            _Connection = Connection;
            SetTimes();
            SetDuration();
            SetNames();
            SetStartPlatform();
        }
        /// <summary>
        /// Erstellt ein Stringarray aus den formatierten Informationen.
        /// </summary>
        /// <returns>Die formatierten Informationen.</returns>
        public string[] GetInfos()
        {
            return new string[] { _startStationName,_startPlatform, _departureTime, _endStationName, _arrivalTime, _travelDuration };
        }

        private void SetTimes()
        {
            _departureTime = Convert.ToDateTime(_Connection.From.Departure).ToShortTimeString();
            _arrivalTime = Convert.ToDateTime(_Connection.To.Arrival).ToShortTimeString();
        }

        private void SetDuration()
        {
            //Duration-Format = 00d00:00:00
            string[] temp = _Connection.Duration.Split('d')[1].Split(':');
            string hours = temp[0];
            string minutes = temp[1];
            if (hours == "00")
            {
                _travelDuration = minutes + " min";
                return;
            }
            else if (hours[0] == '0')
            {
                _travelDuration = hours[1] + " h " + minutes + " m";
                return;
            }
            _travelDuration = hours + " h " + minutes + " m";
        }

        private void SetNames()
        {
            _startStationName = _Connection.From.Station.Name;
            _endStationName = _Connection.To.Station.Name;
        }

        private void SetStartPlatform()
        {
            _startPlatform = _Connection.From.Platform;
        }
    }

    public class Connection
    {
        [JsonProperty("from")]
        public ConnectionPoint From { get; set; }

        [JsonProperty("to")]
        public ConnectionPoint To { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ConnectionPoint
    {
        [JsonProperty("station")]
        public Station Station { get; set; }

        public string Arrival { get; set; }

        public string ArrivalTimestamp { get; set; }

        public string Departure { get; set; }

        public string DepartureTimestamp { get; set; }

        public int? Delay { get; set; }

        public string Platform { get; set; }

        public string RealtimeAvailability { get; set; }
    }
}