using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Management
{
    public class AccountList
    {
        private List<Account> accounts;

        public AccountList()
        {
            accounts = new List<Account>();
        }

        public void addAccount(Account account)
        {
            accounts.Add(account);
        }

        public void delAccount(Account account)
        {
            //accounts.Remove(account);
            accounts.Add(account);
        }

        public List<Account> GetList()
        {
            return accounts;
        }
    }
}
