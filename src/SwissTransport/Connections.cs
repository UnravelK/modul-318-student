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
    /// Enth�lt formatierte Informationen �ber eine Verbindung.
    /// </summary>
    internal class ConnectionInfo
    {
        internal string _travelDuration;
        internal string _departureTime;
        internal string _arrivalTime;
        internal string _startStationName;
        internal string _endStationName;
        internal string _startPlatform;

        /// <summary>
        /// Formatiert die mitgegebenen Informationen.
        /// </summary>
        /// <param name="ConnectionPointFrom">Der ConnectionPoint von welchem gestartet wird.</param>
        /// <param name="ConnectionPoinTo">Der ConnectionPoint des Zieles.</param>
        /// <param name="duration">Die Dauer der Reise.</param>
        internal ConnectionInfo(ConnectionPoint ConnectionPointFrom, ConnectionPoint ConnectionPoinTo, string duration)
        {
            SetTimes(ConnectionPointFrom, ConnectionPoinTo);
            SetDuration(duration);
            SetNames(ConnectionPointFrom, ConnectionPoinTo);
            SetStartPlatform(ConnectionPointFrom);
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
        /// <summary>
        /// �berschreibt die ToString-Methode von der Klasse Connection.
        /// </summary>
        /// <returns>Die formatierten Verbindungsinformationen.</returns>
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