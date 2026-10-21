using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_02
{
    internal class question
    {
        public string header { set; get; }
        public string body { set; get; }
        public int mark { set; get; }
        public answer[] answerslist { get; set; }
        public answer rightanswer { set; get; }
        public question(string header, string body, int mark, answer[]answerslist,answer rightanswer)
        {
            this.header = header;
            this.body = body;
            this.mark = mark;
            this.answerslist= answerslist;
            this.rightanswer = rightanswer;
        }
        public override string ToString()
        {
            return $"Header: {header}\nBody: {body}\nMark: {mark}";
        }
    }
   
    }
