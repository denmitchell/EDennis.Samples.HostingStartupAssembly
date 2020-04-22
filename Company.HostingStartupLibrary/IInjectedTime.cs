using System;
using System.Collections.Generic;
using System.Text;

namespace Company.HostingStartupLibrary
{
    public interface IInjectedTime
    {
        DateTime Now { get; }
    }
}
