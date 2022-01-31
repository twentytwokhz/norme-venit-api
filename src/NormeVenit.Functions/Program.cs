﻿// Copyright (c) Florin Bobis. All Rights Reserved.

using NormeVenit.Library.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
                    svc.AddSingleton<ICaenService, CaenService>();
                })
                .Build();

            host.Run();
        }
    }
}
