namespace Account_Management
{
    public class Examination
    {
        private Patient patient;
        private string ill_definition;
        private string treatment;
        private string result;
        private string id;

        public Examination(Patient patient, string illDefinition, string treatment, string result, string id)
        {
            this.patient = patient;
            ill_definition = illDefinition;
            this.treatment = treatment;
            this.result = result;
            this.id = id;
        }

        public Patient GetPatient() => patient;

        public string GetIllDefinition() => ill_definition;

        public string GetTreatment() => treatment;

        public string GetResult() => result;

        public string GetId() => id;
    }
}
