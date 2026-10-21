using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    internal class answer
    {
        public int answerid { set; get; }
        public string answertext { set; get; }
        public answer(int answerid, string answertext) {
            this.answerid = answerid;
            this.answertext = answertext;
        }
        public override string ToString()
        {
            return $"{answerid},{answertext}";
        }
    }
}
