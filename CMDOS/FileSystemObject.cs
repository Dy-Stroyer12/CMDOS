using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using CMDOS;
using static CMDOS.Machine;

namespace CMDOS
{
    internal class FileSystemObject
    {
        public FileSystemObject(string name, Folder? parentFolder)
        {
            Name = name;
            ParentFolder = parentFolder;

            Metadata = new Dictionary<string, string?>();
            Metadata.Add("created", DateTime.UtcNow.ToString());
            //Metadata.Add("creator", session.User.Username);
        }

        public string Name { get; set; }
        public Folder? ParentFolder { get; set; }
        public Dictionary<string, string?> Metadata { get; set; }
    }
}
