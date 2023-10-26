using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMDOS;
using static CMDOS.Machine;

namespace CMDOS
{
    internal static class Commands
    {
        public static List<Command> Registered = new List<Command> { };

        public static void RegisterCommands()
        {
            Registered.Add(new Command("echo", EchoMethod, 1));
            Registered.Add(new Command("logout", LogoutMethod, 1));
        }

        private static CommandReturn EchoMethod(IEnumerable<string> args)
        {
            return new CommandReturn(ReturnCode.Command.Success, string.Join(" ", args));
        }
        private static CommandReturn LogoutMethod(IEnumerable<string> args)
        {
            session.User = null;
            return new CommandReturn(ReturnCode.Command.Success, string.Empty);
        }
    }
}
