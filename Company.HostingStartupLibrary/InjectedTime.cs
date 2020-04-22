using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.HostingStartupLibrary
{
    public class InjectedTime : IInjectedTime
    {
        public InjectedTime(IOptions<InjectedTimeOptions> options)
        {
            Format = options.Value.Format;
        }

        public string Format { get; }
        public DateTime Now => DateTime.Now;
    }
}
