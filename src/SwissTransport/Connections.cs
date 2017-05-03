using System.Collections.Generic;
using Newtonsoft.Json;
using System;

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
        public string _travelDuration;
        public string _departureTime;
        public string _arrivalTime;
        public string _startStationName;
        public string _endStationName;
        public string _startPlatform;
        public ConnectionInfo(ConnectionPoint From, ConnectionPoint To, string Duration)
        {
            SetTimes(From, To);
            SetDuration(Duration);
            SetNames(From, To);
            SetStartPlatform(From);
        }
        private void SetTimes(ConnectionPoint From, ConnectionPoint To)
        {
            _departureTime = Convert.ToDateTime(From.Departure).ToShortTimeString();
            _arrivalTime = Convert.ToDateTime(To.Arrival).ToShortTimeString();
        }

        private void SetDuration(string Duration)
        {
            string[] temp = Duration.Split('d')[1].Split(':');
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

        private void SetNames(ConnectionPoint From, ConnectionPoint To)
        {
            _startStationName = From.Station.Name;
            _endStationName = To.Station.Name;
        }

        private void SetStartPlatform(ConnectionPoint From)
        {
            _startPlatform = "Gleis. " + From.Platform;
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

        public override string ToString()
        {
            ConnectionInfo CF = new ConnectionInfo(From, To, Duration);
            return CF._startStationName + "\t" + CF._startPlatform + "\t" + CF._departureTime + "\t" + CF._endStationName + "\t" + CF._arrivalTime;
        }
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