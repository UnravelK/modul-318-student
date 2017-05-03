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
        public string travelDuration;
        public string startTime;
        public string endTime;
        public string startName;
        public string endName;
        public string startPlatform;
        public ConnectionInfo(ConnectionPoint From, ConnectionPoint To, string Duration)
        {
            SetTimes(From, To);
            SetDuration(Duration);
            SetNames(From, To);
            SetStartPlatform(From);
        }
        private void SetTimes(ConnectionPoint From, ConnectionPoint To)
        {
            startTime = Convert.ToDateTime(From.Departure).ToShortTimeString();
            endTime = Convert.ToDateTime(To.Arrival).ToShortTimeString();
        }

        private void SetDuration(string Duration)
        {
            string[] temp = Duration.Split('d')[1].Split(':');
            string hours = temp[0];
            string minutes = temp[1];
            if (hours == "00")
            {
                travelDuration = minutes + " min";
                return;
            }
            else if (hours[0] == '0')
            {
                travelDuration = hours[1] + " h " + minutes + " m";
                return;
            }
            travelDuration = hours + " h " + minutes + " m";
        }

        private void SetNames(ConnectionPoint From, ConnectionPoint To)
        {
            startName = From.Station.Name;
            endName = To.Station.Name;
        }

        private void SetStartPlatform(ConnectionPoint From)
        {
            startPlatform = "Gleis. " + From.Platform;
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
            return CF.startName + "\t" + CF.startPlatform + "\t" + CF.startTime + "\t" + CF.endName + "\t" + CF.endTime;
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