using System.Collections.Generic;
using System.Linq;

namespace Account_Management
{
    public class AccountList
    {
        private List<Account> accounts;
        public AccountList() => accounts = new List<Account>();

        public void AddAccount(Account account) => accounts.Add(account);

        public void DelAccount(Account account) => accounts.Remove(account);

        public string AccountType(string staffTc)
        {
            return (from x in accounts where x.GetStaffTc() == staffTc select x.GetDepartment()).FirstOrDefault();
        }

        public List<Account> FindStaff(string name, string department)
        {
            return accounts.Where(x => x.GetNameSurname()[0] == name && x.GetDepartment() == department).ToList();
        }

        public List<Account> GetList() => accounts;
    }
}
