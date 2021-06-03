namespace Account_Management
{
    public class Appointment
    {
        private Patient patient;
        private Account doctorAccount;
        private string appointment_date;
        private string clinic;
        private string inspection;

        public Appointment(Patient patient, Account doctorAccount, string appointmentDate, string clinic, string inspection)
        {
            this.patient = patient;
            this.doctorAccount = doctorAccount;
            appointment_date = appointmentDate;
            this.clinic = clinic;
            this.inspection = inspection;
        }

        public Patient GetPatient() => patient;

        public Account GetAccount() => doctorAccount;

        public string GetAppointmentDate() => appointment_date;

        public string GetClinic() => clinic;

        public string GetInspection() => inspection;
    }
}
