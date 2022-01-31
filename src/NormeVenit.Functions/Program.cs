// Copyright (c) Florin Bobis. All Rights Reserved.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NormeVenit.Library.Services;

namespace NormeVenit.Functions
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices((ctx, svc) =>
                {
                    svc.AddSingleton<INormeVenitService, NormeVenitService>();
                })
                .Build();

            host.Run();
        }
    }
}
