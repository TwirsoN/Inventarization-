using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventarization
{
    internal class Detect_User
    {
        string userName = "";
        public Detect_User() 
        {
            WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();

            userName = currentIdentity.Name;
        }

        public string Name
        {
            get
            {
                return userName;
            }
        }
    }
}
