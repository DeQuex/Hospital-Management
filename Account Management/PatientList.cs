using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Management
{
    class PatientList
    {
        private List<Patient> list;

        public PatientList() => list = new List<Patient>();

        public void Add(Patient patient) => list.Add(patient);

        public void Remove(Patient patient) => list.Remove(patient);

        public List<Patient> GetList() => list;
    }
}
