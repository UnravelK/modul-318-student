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
        private StationBoard _StationBoard;
        public string _name;
        public string _targetLocation;
        public string _depatureTime;

        /// <summary>
        /// Formatiert die mitgegebenen Informationen.
        /// </summary>
        /// <param name="StationBoard">Das StationBoard von welchem die Informationen angezeigt werden soll.</param>
        public StationBoardInfo(StationBoard StationBoard)
        {
            _StationBoard = StationBoard;
            SetName();
            SetTargetLocation();
            SetDepartureTime();
        }
        /// <summary>
        /// Erstellt ein Stringarray aus den formatierten Informationen.
        /// </summary>
        /// <returns>Die formatierten Informationen.</returns>
        public string[] GetInfos()
        {
            return new string[] {_name, _depatureTime , _targetLocation };
        }
        private void SetName()
        {
            _name = _StationBoard.Name;
        }

        private void SetTargetLocation()
        {
            _targetLocation = _StationBoard.To;
        }

        private void SetDepartureTime()
        {
            _depatureTime = _StationBoard.Stop.Departure.ToShortTimeString();
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
    }

    public class Stop
    {
        [JsonProperty("departure")]
        public DateTime Departure { get; set; }
    }
}