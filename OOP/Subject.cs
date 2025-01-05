using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Subject
    {
        public int Subject_Id { get; set; }
        public string Subject_Name { get; set; }
        public Exam Exam { get; set; }

        public Subject(int _id, string _name, Exam _exam)
        {
            Subject_Id = _id;
            Subject_Name = _name;
            Exam = _exam;
        }

        public void ShowSubjectDetails()
        {
            Console.WriteLine($"Subject ID: {Subject_Id}, Name: {Subject_Name}");
            Exam.ShowExam();
        }

    }
}
