using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    internal class subject
    {
        public int subjectid { set; get; }
        public string subjectname { set; get; }
        public exam examofthesubject { set; get; }
        public subject (int subjectid, string subjectname)
        {
            this.subjectid = subjectid;
            this.subjectname = subjectname;
        }
        public void createofxam(exam exam)
        {
            examofthesubject = exam;
        }
    }
}
