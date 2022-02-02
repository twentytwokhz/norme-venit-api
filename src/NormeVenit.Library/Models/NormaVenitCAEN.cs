// Copyright (c) Florin Bobis. All Rights Reserved.

using System.Text.Json.Serialization;

namespace NormeVenit.Library.Models
{
    public class NormaVenitCAEN
    {
        [JsonPropertyName("CAEN")]
        public string CAEN { get; set; }
        [JsonPropertyName("NormeVenit")]
        public List<NormaVenit> NormeVenit { get; set; } = new List<NormaVenit>();
    }

    public class NormaVenit
    {
        public string CodActivitate { get; set; }
        public string Judet { get; set; }
        public int MunicipiuResedintaJudet { get; set; }
        public int Municipiu { get; set; }
        public int Oras { get; set; }
        public int ComunaSat { get; set; }
    }
}
