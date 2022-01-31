// Copyright (c) Florin Bobis. All Rights Reserved.

using System.Text.Json;
using NormeVenit.Library.Models;

namespace NormeVenit.Library.Services
{
    public class NormeVenitService : INormeVenitService
    {
        private readonly JsonDocument normeVenitStore;
        private readonly List<NormaVenitCAEN> list;
        private const string storePath = "Store\\normevenit.json";

        public NormeVenitService()
        {
            normeVenitStore = JsonDocument.Parse(File.ReadAllText(storePath));
            list = normeVenitStore.Deserialize<List<NormaVenitCAEN>>();
        }

        public NormaVenit? GetNormaVenit(string caen, string judet)
        {
            var result = list.FirstOrDefault(c => c.CAEN == caen);
            if (result == null)
            {
                return null;
            }
            return result.NormeVenit.FirstOrDefault(p => p.Judet.ToLower() == judet.ToLower());
        }

        public int GetNormaVenit(string caen, string judet, TipLocalitate tip)
        {
            var result = list.FirstOrDefault(c => c.CAEN == caen)?
                             .NormeVenit.FirstOrDefault(p => p.Judet.ToLower() == judet.ToLower());
            if (result == null)
            {
                return -1;
            }
            switch (tip)
            {
                case TipLocalitate.MunicipiuResedintaJudet:
                    return result.MunicipiuResedintaJudet;
                case TipLocalitate.Municipiu:
                    return result.Municipiu;
                case TipLocalitate.Oras:
                    return result.Oras;
                case TipLocalitate.ComunaSat:
                    return result.ComunaSat;
                default:
                    return -1;
            }
        }
    }
}
