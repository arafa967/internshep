using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Exam
    {
        public double TimeOfExam { get; set; }
        public int NumnberOFQuestion { get; set; }
        public abstract void ShowExam();
        

        public Question[] Questions { get; set; }
        public Exam(double _time ,int _numberOFquestion)
        {
            TimeOfExam = _time;
            NumnberOFQuestion = _numberOFquestion;
            Question question = new Question[_numberOFquestion];
        }
         
    }
}
