using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Final_Exam : Exam
    {
         
        
            public Final_Exam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

            public override void ShowExam()
            {
                Console.WriteLine("Final Exam:");
                foreach (var question in Questions)
                {
                    question.Show();
                }
            }

        
    }

}
