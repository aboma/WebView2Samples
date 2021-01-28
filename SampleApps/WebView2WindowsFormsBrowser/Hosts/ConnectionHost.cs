using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace WebView2WindowsFormsBrowser.Hosts
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("CF9E7489-E6DE-43C9-828E-B9D5EE36E242")]
    public class ConnectionHost
    {
        private long counter = 0;

        public long Ping()
        {
            return counter += 1;
        }
    }
}
