// Copyright (c) Florin Bobis. All Rights Reserved.

using NormeVenit.Library.Models;

namespace NormeVenit.Library.Services
{
    public interface INormeVenitService
    {
        List<NormaVenit> GetNormaVenit(string caen, string judet, string codActivitate = null);
    }
}
