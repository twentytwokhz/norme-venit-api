﻿// Copyright (c) Florin Bobis. All Rights Reserved.

using System.Text.Json;
using NormeVenit.Library.Models;

namespace NormeVenit.Library.Services
{
    public class CaenService : ICaenService
    {
        private readonly JsonDocument caenStore;
        private readonly List<Section> list;
        private const string storePath = "Store\\caen.json";

        public CaenService()
        {
            caenStore = JsonDocument.Parse(File.ReadAllText(storePath));
            list = caenStore.Deserialize<List<Section>>();
        }

        public List<CaenCode> GetCodesByFilter(string sectionId = null, string divisionId = null, string groupId = null)
        {
            var result = (from section in list
                          from division in section.Divisions
                          from gr in division.Groups
                          from code in gr.Codes
                          where (sectionId != null ? section.ID.ToLower() == sectionId.ToLower() : true) &&
                                (divisionId != null ? division.ID.ToLower() == divisionId.ToLower() : true) &&
                                (groupId != null ? gr.ID.ToLower() == groupId.ToLower() : true)
                          select code)
                          .Distinct().ToList();
            return result;
        }

        public List<CaenCode> SearchCode(string query)
        {
            var result = (from section in list
                          from division in section.Divisions
                          from gr in division.Groups
                          from code in gr.Codes
                          where section.Search(query.ToLower()) ||
                                division.Search(query.ToLower()) ||
                                gr.Search(query.ToLower()) ||
                                code.Search(query.ToLower())
                          select code)
                          .Distinct().ToList();
            return result;
        }
    }
}
