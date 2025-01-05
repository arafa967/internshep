using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Practial_Exam : Exam
    {


        public Practial_Exam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam:");
            foreach (var question in Questions)
            {
                question.Show();
            }
        }
    }

}
