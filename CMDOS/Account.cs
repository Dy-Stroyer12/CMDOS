using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDOS
{
    internal class Account
    {
        public Account() { }
        public Account(string username, string password, int privilege)
        {
            Id = Guid.NewGuid();
            Username = username;
            Password = password;
            Privilege = privilege;
            MailAccount = new MailAccount();
        }
        public Account(string username, string password, int privilege, bool deletable)
            : this(username, password, privilege)
        {
            Deletable = deletable;
        }

        public string? Username { get; set; }
        public string? Password { get; set; }
        public Guid? Id { get; set; }
        public int? Privilege { get; set; }
        public MailAccount? MailAccount { get; set; }
        public bool? Deletable { get; set; }
    }
}
