using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{

    public class Exam
    {


        public int Time { get; set; }
        public int NoOfQuestions { get; set; }
        internal Question[] Questions { get; set; }
        //public Exam()
        //{

        //}
        public Exam(int _Time, int _NoOfQuestions)
        {
            Time = _Time;
            NoOfQuestions = _NoOfQuestions;

        }

        public virtual void ShowExam()
        {

        }

        public virtual void SetQuestion()
        {

        }


    }

}
