using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    internal class finalexam : exam
    {
        public finalexam(int time, int numberofquestion) : base(time, numberofquestion)
        {
        }
        public override void showexam()
        {
            Console.WriteLine("final");
            Console.WriteLine($"time of exam is {time}");
            Console.WriteLine($"number of question is {numberofquestion}");
            for (int i=0;i<questions.Length;i++)
            {
                if (questions[i]!=null)
                {
                    Console.WriteLine(questions[i].header);
                    Console.WriteLine(questions[i].body);
                    Console.WriteLine(questions[i].mark);
                    if (questions[i].answerslist != null)
                    {
                        foreach (answer answer in questions[i].answerslist)
                        {
                            Console.WriteLine(answer);
                        }
                    }
                }
            }
            
        }
    }
}
