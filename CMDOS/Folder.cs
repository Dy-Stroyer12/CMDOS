using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDOS
{
    internal class Folder : FileSystemObject
    {
        public Folder(string name, Folder? parentFolder)
            : base(name, parentFolder) { }

        public Dictionary<string, FileSystemObject> Children = new Dictionary<string, FileSystemObject> { };
    }
}
