using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Question
    {

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answers[] Answers { get; set; }
        public Answers Answer { get; set; }


        public Question()
        {

        }

        public Question(int Number)
        {

            Question[] questions = new Question[Number];


        }
        public virtual void SetAnswer()
        {

        }



    }

}




