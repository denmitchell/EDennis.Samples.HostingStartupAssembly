using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.HostingStartupLibrary
{
    public class InjectedTime : IInjectedTime
    {
        public InjectedTime(IOptionsMonitor<InjectedTimeOptions> options)
        {
            Format = options.CurrentValue.Format;
        }

        public string Format { get; }
        public DateTime Now => DateTime.Now;
    }
}
