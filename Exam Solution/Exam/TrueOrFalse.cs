using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class TrueOrFalse : Question
    {

        public TrueOrFalse()
        {

            Console.Write("Enter Your Question: ");
            Body = Console.ReadLine();

            int X;
            bool flag;
            do
            {
                Console.Write("Enter The Grade of the Question: ");
                flag = int.TryParse(Console.ReadLine(), out X);

                if (flag == false)
                {
                    Console.WriteLine("Please Enter Valid Number");
                }
                Mark = X;
            }
            while (!flag);

            Answers = new Answers[2];
            Answer = new Answers();
            Console.WriteLine();

        }
        public override void SetAnswer()
        {
            
            Answers[0] = new Answers()
            {
                AnswerId = 1,
                AnswerText = "True"

            };
            Answers[1] = new Answers()
            {
                AnswerId = 2,
                AnswerText = "False"
            };
            int Type;
            bool flag;
            do
            {
                Console.Write("correct Answer: ");
                flag = int.TryParse(Console.ReadLine(), out Type);
                if (Type == 1 || Type == 2 )
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

                if (flag == false)
                {
                    Console.WriteLine("Please Enter Valid Answer");
                }
            }
            while (!flag);
            Answer.AnswerId = Type;
        }

    }
}
