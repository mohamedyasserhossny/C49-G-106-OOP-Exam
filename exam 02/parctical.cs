using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    internal class parctical : exam
    {
        public parctical(int time, int numberofquestion) : base(time, numberofquestion)
        {
        }
        public override void showexam()
        {
            Console.WriteLine("practical");
            Console.WriteLine(time);
            Console.WriteLine(numberofquestion);
            for (int i = 0; i < questions.Length; i++)
            {
                if (questions[i] != null)
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
                    Console.WriteLine(questions[i].rightanswer);
                }
               
            }
        }
    }
}
