using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CMDOS
{
    internal class Session
    {
        private List<Account> _accounts = new List<Account>();
        private Account? _user;
        private bool _running = true;

        AppData Data = AppData.Default;

        public ReturnCode.Login Login()
        {
            Console.Write("CMDOS Login: ");
            string? userInput = Input.Lower();
            Console.Write("Password: ");
            string? passInput = Console.ReadLine();
            Account? attemptAcc = Accounts.FirstOrDefault(x => x.Username == userInput && x.Password == userInput);
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
            
        }

        public void LoadSession()
        {
            if (Data.FirstBoot)
            {
                Data.FirstBoot = false;
                
            }
        }

        public List<Account> Accounts
        {
            get { return _accounts; }
            set { _accounts = value; }
        }
        public Account? User
        {
            get { return _user; }
            set { _user = value; }
        }
        public bool Running
        {
            get { return _running; }
            set { _running = value; }
        }
    }
}
