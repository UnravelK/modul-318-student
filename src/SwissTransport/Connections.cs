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
        Connection Connection;
        string travelDuration;
        ConnectionInfo(Connection Connection)
        {
            this.Connection = Connection;
        }
        public static DateTime DateTimeFromTimeStamp(double timeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(timeStamp).ToLocalTime();
            return dtDateTime;
        }

        public string GetDuration(string unfromattedDuration)
        {
            string[] tempString = unfromattedDuration.Split('d')[1].Split(':');
            string minutes = tempString[1];
            if (minutes[0] == '0') minutes = minutes[1].ToString();
            string hours = tempString[0];
            if (hours == "00") return minutes + " min";
            if (hours[0] == '0') return hours[1] + " h " + minutes + " min";
            return hours + " h " + minutes + " min"; ;
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
            string returnValue = string.Empty;
            return returnValue;
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