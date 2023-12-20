using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }


        public Subject(int _SubjectId, string _SubjectName)
        {
            SubjectId = _SubjectId;
            SubjectName = _SubjectName;
        }

        public void CreateExam()
        {

            int Type;
            bool flag;
            do
            {
                Console.WriteLine("Enter The Type Of The Exam (1 - Final Exam\t/ 2 - Practical Exam)");
                flag = int.TryParse(Console.ReadLine(), out Type);
                if (Type == 1 || Type == 2)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

                if (flag == false)
                {
                    Console.WriteLine("Please Enter Valid Exam no");
                }
            }
            while (!flag);
            if (Type == 1)
            {

                int Time;

                do
                {
                    Console.WriteLine("Enter the time of exam");
                    flag = int.TryParse(Console.ReadLine(), out Time);

                    if (flag == false)
                    {
                        Console.WriteLine("Please Enter Valid Time");
                    }
                }
                while (!flag);

                int NumberOfQus;

                do
                {
                    Console.WriteLine("Enter the num of q in exam");
                    flag = int.TryParse(Console.ReadLine(), out NumberOfQus);

                    if (flag == false)
                    {
                        Console.WriteLine("Please Enter Valid Number");
                    }
                }
                while (!flag);
                Exam = new FinalExam(Time, NumberOfQus);
            }
            else if (Type == 2)
            {
                int Time;

                do
                {
                    Console.WriteLine("Enter the time of exam");
                    flag = int.TryParse(Console.ReadLine(), out Time);

                    if (flag == false)
                    {
                        Console.WriteLine("Please Enter Valid Time");
                    }
                }
                while (!flag);

                int NumberOfQus;

                do
                {
                    Console.WriteLine("Enter the num of q in exam");
                    flag = int.TryParse(Console.ReadLine(), out NumberOfQus);

                    if (flag == false)
                    {
                        Console.WriteLine("Please Enter Valid Number");
                    }
                }
                while (!flag);
                Exam = new PracticalExam(Time, NumberOfQus);
            }

            Exam.SetQuestion();
        }


    }


}

