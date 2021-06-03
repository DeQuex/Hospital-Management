using System.Collections.Generic;

namespace Account_Management
{
    public class PatientList
    {
        private List<Patient> list;

        public PatientList() => list = new List<Patient>();

        public void Add(Patient patient) => list.Add(patient);

        public void Remove(Patient patient) => list.Remove(patient);

        public List<Patient> GetList() => list;
    }
}
