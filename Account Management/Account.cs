namespace Account_Management
{
    public class Account
    {
        private string id;
        private string name;
        private string surname;
        private string staff_tc;
        private string password;
        private string mail;
        private string deparment;
        private string approve_status;
        private string staff_id;
        public Account(string uId, string uName, string uSurname, string uStaffTc, string uPassword, string uMail, string uDeparment, string uApproveStatus, string uStaffİd)
        {
            id = uId;
            name = uName;
            surname = uSurname;
            staff_tc = uStaffTc;
            password = uPassword;
            mail = uMail;
            deparment = uDeparment;
            approve_status = uApproveStatus;
            staff_id = uStaffİd;
        }

        public string GetId() => id;

        public string[] GetNameSurname()
        {
            string[] str = { name, surname };
            return str;
        }

        public string GetStaffTc() => staff_tc;

        public string GetPassword() => password;

        public string GetMail() => mail;

        public string GetDepartment() => deparment;

        public string GetApproveStatus() => approve_status;

        public string GetStaffId() => staff_id;
    }
}
