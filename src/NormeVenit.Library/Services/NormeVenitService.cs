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

        public List<NormaVenit> GetNormaVenit(string caen, string judet, string codActivitate = null)
        {
            var result = list.FirstOrDefault(c => c.CAEN == caen);
            if (result == null)
            {
                return null;
            }
            return result.NormeVenit.Where(p =>
                p.Judet.ToLower() == judet.ToLower() &&
                codActivitate != null ? p.CodActivitate.ToLower() == codActivitate.ToLower() : true)
                .ToList();
        }
    }
}
