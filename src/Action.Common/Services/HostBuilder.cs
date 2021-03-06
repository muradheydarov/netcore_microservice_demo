﻿using Microsoft.AspNetCore.Hosting;
using RawRabbit;
using System;

namespace Action.Common.Services
{
    public class HostBuilder : BuilderBase
    {
        private IWebHost _webHost;
        private IBusClient _bus;

        public HostBuilder(IWebHost webHost)
        {
            this._webHost = webHost;
        }

        public BusBuilder UseRabbitMq()
        {
            _bus = (IBusClient)_webHost.Services.GetService(typeof(IBusClient));

            return new BusBuilder(_webHost, _bus);
        }

        public override ServiceHost Build()
        {
            return new ServiceHost(_webHost);
        }
    }
}