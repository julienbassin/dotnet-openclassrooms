using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation.Cmdlet;
using System.Management.Automation.PSCmdlet;

namespace AuditAD
{
    class AuditAD : PScmdlet
    {
        public string[] DomainController;

        AuditAD()
        {

        }

        // multiple signature of this method
        bool ConnectAD (string[] DomainController, int port)
        {
            return true;
        }

        // method search into LDAP

        // method get computer info

        // getter accessor to get user info  

        // getter accessor to get site info

        // getter accessor to get domain info

        // getter accessor to get forest info

        // getter accessor to get GPO info
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
