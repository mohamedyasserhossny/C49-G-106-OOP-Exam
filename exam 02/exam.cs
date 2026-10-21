using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    internal class exam
    {

        public int time { set; get; }
        public int numberofquestion { set; get; }
        public question[] questions { set; get; } 
        public exam(int time, int numberofquestion )
        {
            this.time= time;
            this.numberofquestion = numberofquestion;
            questions = new question[numberofquestion];
        }
        public virtual void showexam()
        {
            Console.WriteLine("your exam is ");
        }
    }
}
