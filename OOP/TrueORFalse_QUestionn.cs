using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class TrueORFalse_QUestionn:Question
    {
         
        
            public bool RightAnswer { get; set; }

            public TrueORFalse_QUestionn(string header, string body, int mark, bool _rightAnswer)
                : base(header, body, mark)
            {
                RightAnswer = _rightAnswer;
                

            }

        public override void Show()
        {
            Console.WriteLine($"{Header}: {Body} (Mark: {Mark})");
            Console.WriteLine("1. True\n2. False");
        }


    }
}
