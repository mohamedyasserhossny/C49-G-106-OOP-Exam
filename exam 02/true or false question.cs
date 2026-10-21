using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    internal class true_or_false_question : question
    {
        public true_or_false_question(string header, string body, int mark, answer[] answerslist, answer rightanswer) : base(header, body, mark, answerslist, rightanswer)
        {
        }
    }
}
