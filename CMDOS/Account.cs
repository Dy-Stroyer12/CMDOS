using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDOS
{
    internal class Account
    {
        private string? _username;
        private string? _password;
        private Guid? _id;
        private int? _privilege;
        private MailAccount? _mailAccount;

        public Account(string username, string password, int privilege)
        {
            Id = Guid.NewGuid();
            Username = username;
            Password = password;
            Privilege = privilege;
            MailAccount = new MailAccount();
        }

        public string? Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string? Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public Guid? Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int? Privilege
        {
            get { return _privilege; }
            set { _privilege = value; }
        }
        public MailAccount? MailAccount
        {
            get { return _mailAccount; }
            set { _mailAccount = value; }
        }
    }
}
