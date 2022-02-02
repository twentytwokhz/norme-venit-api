// Copyright (c) Florin Bobis. All Rights Reserved.

using NormeVenit.Library.Models;

namespace NormeVenit.Library.Services
{
    public interface INormeVenitService
    {
        /// <summary>
        /// Aduce normele de venit per activitate
        /// </summary>
        /// <param name="caen"></param>
        /// <param name="judet"></param>
        /// <param name="codActivitate"></param>
        /// <returns></returns>
        List<NormaVenit> GetNormaVenit(string caen, string judet, string codActivitate);
        /// <summary>
        /// Aduce norma de venit specifica tipului de localitate
        /// </summary>
        /// <param name="caen"></param>
        /// <param name="judet"></param>
        /// <param name="codActivitate"></param>
        /// <param name="tipLocalitate"></param>
        /// <returns></returns>
        int GetNormaVenit(string caen, string judet, string codActivitate, TipLocalitate tipLocalitate);
    }
}
