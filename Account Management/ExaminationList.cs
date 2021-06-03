using System.Collections.Generic;

namespace Account_Management
{
    public class ExaminationList
    {
        private List<Examination> list;

        public ExaminationList() => list = new List<Examination>();

        public void Add(Examination examination) => list.Add(examination);

        public void Remove(Examination examination) => list.Remove(examination);

        public List<Examination> GetList() => list;
    }
}
