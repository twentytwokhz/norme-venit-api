// Copyright (c) Florin Bobis. All Rights Reserved.

using System.Net;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using NormeVenit.Library.Models;
using NormeVenit.Library.Services;

namespace NormeVenit.Functions.Api
{
    public class GetNormeVenit
    {
        private readonly INormeVenitService normeVenitService;

        public GetNormeVenit(INormeVenitService normeVenitService)
        {
            this.normeVenitService = normeVenitService;
        }

        [Function("normavenit/{caen}/{judet}/{tip?}")]
        public async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequestData req,
            string caen, string judet, string tipActivitate)
        {
            HttpResponseData response = req.CreateResponse();
            response.Headers.Add("Content-Type", "application/json; charset=utf-8");

            var result = normeVenitService.GetNormaVenit(caen, judet, tipActivitate);
            if (result == null)
            {
                response.StatusCode = HttpStatusCode.NotFound;
            }
            else
            {
                response = req.CreateResponse(HttpStatusCode.OK);
                await response.WriteAsJsonAsync<NormaVenit>(result);
            }

            return response;
        }
    }
}
