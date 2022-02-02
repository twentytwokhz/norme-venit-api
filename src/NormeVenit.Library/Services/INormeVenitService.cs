// Copyright (c) Florin Bobis. All Rights Reserved.

using NormeVenit.Library.Models;

namespace NormeVenit.Library.Services
{
    public interface INormeVenitService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="caen"></param>
        /// <param name="judet"></param>
        /// <param name="codActivitate"></param>
        /// <returns></returns>
        List<NormaVenit> GetNormaVenit(string caen, string judet, string codActivitate);
        int GetNormaVenit(string caen, string judet, string codActivitate, TipLocalitate tipLocalitate);
    }
}
