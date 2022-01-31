// Copyright (c) Florin Bobis. All Rights Reserved.

using NormeVenit.Library.Models;

namespace NormeVenit.Library.Services
{
    public interface ICaenService
    {
        List<CaenCode> GetCodesByFilter(string sectionId = null, string divisionId = null, string groupId = null);
        List<CaenCode> SearchCode(string query);
    }
}
