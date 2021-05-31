using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
