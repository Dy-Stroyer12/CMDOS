using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDOS
{
    internal class CommandReturn
    {
        public CommandReturn(ReturnCode.Command fReturn, string output)
        {
            Return = fReturn;
            Output = output;
        }

        public ReturnCode.Command Return { get; set; }
        public string Output { get; set; }
    }
}
