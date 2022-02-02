// Copyright (c) Florin Bobis. All Rights Reserved.

namespace NormeVenit.Library.Models
{
    public class NormaVenitCAEN
    {
        public string CAEN { get; set; }
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

    public enum TipLocalitate
    {
        MunicipiuResedintaJudet = 0,
        Municipiu = 1,
        Oras = 2,
        ComunaSat = 3,
    }
}
