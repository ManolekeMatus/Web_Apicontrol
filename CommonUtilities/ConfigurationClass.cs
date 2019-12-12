using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtilities
{
    public class ConfigurationClass
    {
        private static string loginBDConnection = ConfigurationManager.AppSettings["loginBDConnection"].ToString();
        private static string formatBDConnection = ConfigurationManager.AppSettings["formatBDConnection"].ToString();
        public static string FormatBDConnection
        {
            get { return formatBDConnection; }
        }
        public static string LoginBDConnection
        {
            get { return loginBDConnection; }
        }
    }
}
