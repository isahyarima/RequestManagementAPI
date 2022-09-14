using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
   public static class GetIPAddress
    {

        static string hostName = Dns.GetHostName();
        public static string IP()
        {
            return Dns.GetHostByName(hostName).AddressList[0].ToString();
        }
    }
}
