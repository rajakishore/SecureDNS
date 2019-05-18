﻿using DNS.Client;
using DNS.Server;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Texnomic.DNS.Pages
{
    public class TesterBase : ComponentBase
    {
        [Inject]
        protected DnsServer DnsServer { get; set; }

        protected string Input = "google.com";

        protected string Output;

        protected async Task ResolveAsync()
        {
            var Client = new DnsClient("127.0.0.1");

            var Request = Client.Create();

            var IPs = await Client.Lookup(Input);

            Output = string.Join(", ", IPs);

            // Get the domain name belonging to the IP (google.com)
            var Domain = await Client.Reverse("173.194.69.100");
        }
    }
}