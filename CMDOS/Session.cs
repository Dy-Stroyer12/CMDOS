using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CMDOS
{
    internal class Session
    {
        AppData Data = AppData.Default;
        public static Folder rootFolder = new Folder("", null);

        public ReturnCode.Login Login()
        {
            Console.Write("CMDOS Login: ");
            string? userInput = Input.Lower();
            Console.Write("Password: ");
            string? passInput = Input.Password();
            Account? attemptAcc = Accounts.FirstOrDefault(x => x.Username == userInput && x.Password == passInput);
            if (attemptAcc != null)
            {
                User = attemptAcc;
                return ReturnCode.Login.Success;
            }
            else if (Accounts.FirstOrDefault(x => x.Username == userInput) != null)
            {
                return ReturnCode.Login.IncorrectPassword;
            }
            return ReturnCode.Login.NonexistentUser;
        }

        public Session()
        {
            Accounts = JsonConvert.DeserializeObject<List<Account>>(Data.Accounts) ?? new List<Account>();
        }

        public void LoadSession()
        {
            if (Data.FirstBoot)
            {
                Data.FirstBoot = false;
                Accounts.Add(new Account("root", "root", 999, false));
                Data.Accounts = JsonConvert.SerializeObject(Accounts);

                rootFolder.Children.Add("home", new Folder("home", rootFolder));

                Data.Save();
            }
            Commands.RegisterCommands();
        }

        public CommandReturn InputCommand(int privilege)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return new CommandReturn(ReturnCode.Command.Success, string.Empty);
            }
            string[] inputSplit = input.Split(" ");
            string[] args = inputSplit.Skip(1).ToArray();
            Command? inputCmd = Commands.Registered.FirstOrDefault(x => x.Name == inputSplit[0]);
            if (inputCmd != null)
            {
                return inputCmd.Run(args);
            }
            else
            {
                return new CommandReturn(ReturnCode.Command.Nonexistent, string.Empty);
            }
        }

        public List<Account> Accounts { get; set; }
        public Account? User { get; set; }
        public bool Running { get; set; } = true;
    }
}
