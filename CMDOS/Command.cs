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
        public Command(string name, Func<IEnumerable<string>, CommandReturn> run, int privilege)
        {
            Name = name;
            Run = run;
            Privilege = privilege;
        }

        public string Name { get; set; }
        public Func<IEnumerable<string>, CommandReturn> Run { get; set; }
        public int Privilege { get; set; }
    }
}
