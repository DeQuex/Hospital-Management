using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Management
{
    public class Account
    {
        private string account_type;
        private string account_username;
        private string account_password;

        public Account(string uAccountType, string uAccountUsername, string uAccountPassword)
        {
            account_type = uAccountType;
            account_username = uAccountUsername;
            account_password = uAccountPassword;
        }

        public string GetAccountType()
        {
            return account_type;
        }

        public string GetAccountUsername()
        {
            return account_username;
        }

        public string GetAccountPassword()
        {
            return account_password;
        }

        public void SetAccountType(string type)
        {
            account_type = type;
        }

        public void SetAccountUsername(string username)
        {
            account_username = username;
        }

        public void SetAccountPassword(string password)
        {
            account_password = password;
        }
    }
}
