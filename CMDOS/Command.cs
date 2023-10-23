using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMDOS
{
    internal class Command
    {
        public Command(string name, int[] acceptedArgs, Action method, int privilege)
        {
            Name = name;
            AcceptedArgs = acceptedArgs;
            Method = method;
            Privilege = privilege;
        }

        public string Name { get; set; }
        public int[] AcceptedArgs { get; set; }
        public Action Method { get; set; }
        public int Privilege { get; set; }
    }
}
