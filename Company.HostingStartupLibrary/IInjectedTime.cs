using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.HostingStartupLibrary
{
    public interface IInjectedTime
    {
        string Format { get; }
        DateTime Now { get; }
    }
}
