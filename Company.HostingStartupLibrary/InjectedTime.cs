using System;
using System.Collections.Generic;
using System.Text;

namespace Company.HostingStartupLibrary
{
    public class InjectedTime : IInjectedTime
    {
        public DateTime Now => DateTime.Now;
    }
}
