using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
