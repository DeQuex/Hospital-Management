using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Management
{
    class AppointmentList
    {
        private List<Appointment> list;

        public AppointmentList() => list = new List<Appointment>();

        public void Add(Appointment appointment) => list.Add(appointment);

        public void Remove(Appointment appointment) => list.Remove(appointment);

        public List<Appointment> GetList() => list;
    }
}
