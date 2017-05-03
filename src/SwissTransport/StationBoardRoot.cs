using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class StationBoardRoot
    {
        [JsonProperty("Station")]
        public Station Station { get; set; }

        [JsonProperty("stationboard")]
        public List<StationBoard> Entries { get; set; }
    }
    /// <summary>
    /// Enthält formatierte Informationen über eine Stations-Anzeige.
    /// </summary>
    public class StationBoardInfo
    {
        public string _name;
        public string _targetLocation;
        public string _depatureTime;
        public StationBoardInfo(DateTime dtDeparture, string name, string to)
        {
            SetName(name);
            SetTargetLocation(to);
            SetDepartureTime(dtDeparture);
        }
        private void SetName(string name)
        {
            _name = name;
        }

        private void SetTargetLocation(string to)
        {
            _targetLocation = to;
        }

        private void SetDepartureTime(DateTime dtDeparture)
        {
            _depatureTime = dtDeparture.ToShortTimeString();
        }
    }

    public class StationBoard
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("stop")]
        public Stop Stop { get; set; }

        public override string ToString()
        {
            StationBoardInfo SBI = new StationBoardInfo(Stop.Departure, Name, To);
            return SBI._name + "\t" + SBI._targetLocation + "\t" + SBI._depatureTime;
        }
    }

    public class Stop
    {
        [JsonProperty("departure")]
        public DateTime Departure { get; set; }
    }
}