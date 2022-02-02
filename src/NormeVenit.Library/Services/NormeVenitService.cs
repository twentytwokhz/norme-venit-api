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

        public List<NormaVenit> GetNormaVenit(string caen, string judet, string codActivitate)
        {
            var result = list.FirstOrDefault(c => c.CAEN == caen);
            if (result == null)
            {
                return null;
            }
            var normeVenit = result.NormeVenit.Where(p =>
                p.Judet.ToLower() == judet.ToLower() &&
                codActivitate != null ? p.CodActivitate.ToLower() == codActivitate.ToLower() : true)
                .ToList();

            return normeVenit;
        }

        public int GetNormaVenit(string caen, string judet, string codActivitate, TipLocalitate tipLocalitate)
        {
            var result = list.FirstOrDefault(p => p.CAEN == caen);
            if (result == null)
            {
                return -1;
            }

            var normaVenit = result.NormeVenit.FirstOrDefault(p =>
                p.CodActivitate.ToLower() == codActivitate.ToLower() &&
                p.Judet.ToLower() == judet.ToLower());
            if (normaVenit == null)
            {
                return -1;
            }

            switch (tipLocalitate)
            {
                case TipLocalitate.MunicipiuResedintaJudet:
                    return normaVenit.MunicipiuResedintaJudet;
                case TipLocalitate.Municipiu:
                    return normaVenit.Municipiu;
                case TipLocalitate.Oras:
                    return normaVenit.Oras;
                case TipLocalitate.ComunaSat:
                    return normaVenit.ComunaSat;
                default:
                    return -1;
            }
        }
    }
}
