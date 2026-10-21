namespace exam_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            subject s1 = new subject(1, "software");

            parctical e1 = new parctical(60, 2);
            s1.createofxam(e1);
            answer a1 = new answer(1, "True");
            answer a2 = new answer(2, "False");

            answer a3 = new answer(1, "software");
            answer a4 = new answer(2, "logic design");
            answer a5 = new answer(3, "Python");
            answer a6 = new answer(4, "testing");
            answer[] answers1 = { a1, a2 };
            question q1 = new true_or_false_question("True Or False","software has importnant lesons",5,answers1,a1);
            e1.questions[0] = q1;
            answer[] answers2 = { a3, a4, a5, a6 };
            question q2 = new mcq_question("MCQ","what are you favourite subject",5,answers2,a3);
            e1.questions[1] = q2;
            s1.examofthesubject.showexam();
        }
    }
}
