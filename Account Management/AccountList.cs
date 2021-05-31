using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
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
            accounts.Remove(account);
        }

        public bool filterByName(string name)
        {
            var tempBool = false;
            foreach (var acc in accounts)
            {
                if (acc.GetNameSurname()[0] == name)
                {
                    tempBool = true;
                    break;
                }
            }
            return tempBool;
        }

        public string AccountType(string staff_tc)
        {
            return (from x in accounts where x.GetStaffTc() == staff_tc select x.GetDepartment()).FirstOrDefault();
        }

        public List<Account> FindStaff(string name, string department)
        {
            return accounts.Where(x => x.GetNameSurname()[0] == name && x.GetDepartment() == department).ToList();
        }
        
        public List<Account> GetList()
        {
            return accounts;
        }
    }
}
