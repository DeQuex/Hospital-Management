using System.Collections.Generic;

namespace Account_Management
{
    public class AppointmentList
    {
        private List<Appointment> list;

        public AppointmentList() => list = new List<Appointment>();

        public void Add(Appointment appointment) => list.Add(appointment);

        public void Remove(Appointment appointment) => list.Remove(appointment);

        public List<Appointment> GetList() => list;
    }
}
