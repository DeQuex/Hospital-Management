using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Management
{
    class ExaminationList
    {
        private List<Examination> list;

        public ExaminationList() => list = new List<Examination>();

        public void Add(Examination examination) => list.Add(examination);

        public void Remove(Examination examination) => list.Remove(examination);

        public List<Examination> GetList() => list;
    }
}
