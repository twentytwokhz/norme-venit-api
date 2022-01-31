// Copyright (c) Florin Bobis. All Rights Reserved.

using NormeVenit.Library.Models;

namespace NormeVenit.Library.Services
{
    public interface INormeVenitService
    {
        int GetNormaVenit(string caen, string judet, TipLocalitate tip);
        NormaVenit? GetNormaVenit(string caen, string judet);
    }
}
