using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class MCQ_Question : Question
    {


        public string[] Choices { get; set; }
        public int RightChoice { get; set; }

        public MCQ_Question(string header, string body, int mark, string[] choices, int rightChoice)
            : base(header, body, mark)
        {
            Choices = choices;
            RightChoice = rightChoice;
        }
        public override void Show()
        {
            Console.WriteLine($"{Header}: {Body} (Mark: {Mark})");
            for (int i = 0; i < Choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Choices[i]}");
            }
        }
    }   
}
