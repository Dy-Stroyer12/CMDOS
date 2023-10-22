using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDOS
{
    internal static class ReturnCode
    {
        internal enum Login
        {
            IncorrectPassword,
            NonexistentUser,
            Success
        }
    }
}
