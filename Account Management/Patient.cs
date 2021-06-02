using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Management
{
    public class Patient
    {
        private string patient_id;
        private string name;
        private string surname;
        private string mail;
        private string tc;
        private string password;

        public Patient(string patientİd, string name, string surname, string mail, string tc, string password)
        {
            patient_id = patientİd;
            this.name = name;
            this.surname = surname;
            this.mail = mail;
            this.tc = tc;
            this.password = password;
        }

        public string GetPatientId() => patient_id;

        public string[] GetNameSurname()
        {
            string[] str = {name, surname};
            return str;
        }

        public string GetMail() => mail;

        public string GetTc() => tc;

        public string GetPassword() => password;
    }
}
