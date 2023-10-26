using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMDOS;
using static CMDOS.Machine;

namespace CMDOS
{
    internal class osFile : FileSystemObject
    {
        public osFile(string name, Folder parentFolder)
            : base(name, parentFolder) { }

        public Dictionary<string, string> Metadata { get; set; }
    }
}
