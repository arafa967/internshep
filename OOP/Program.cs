using System.Drawing;

namespace OOP
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Enter Subject ID: ");
            int subjectId = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Name: ");
            string subjectName = Console.ReadLine();

            Console.Write("Enter Exam Time (minutes): ");
            int examTime = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Questions: ");
            int numQuestions = int.Parse(Console.ReadLine());

            Final_Exam finalExam = new Final_Exam(examTime, numQuestions);

            for (int i = 0; i < numQuestions; i++)
            {
                Console.Write($"Enter Question {i + 1} Type (1-True/False, 2-MCQ): ");
                int qType = int.Parse(Console.ReadLine());

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark: ");
                int mark = int.Parse(Console.ReadLine());

                if (qType == 1)
                {
                    Console.Write("Enter Correct Answer (1-True, 2-False): ");
                    bool correctAnswer = int.Parse(Console.ReadLine()) == 1;
                   finalExam.Questions[i] = new TrueORFalse_QUestionn(header, body, mark, correctAnswer);
                }
                else
                {
                    Console.Write("Enter Number of Choices: ");
                    int numChoices = int.Parse(Console.ReadLine());
                    string[] choices = new string[numChoices];

                    for (int j = 0; j < numChoices; j++)
                    {
                        Console.Write($"Enter Choice {j + 1}: ");
                        choices[j] = Console.ReadLine();
                    }

                    Console.Write("Enter Correct Choice (1, 2, etc.): ");
                    int correctChoice = int.Parse(Console.ReadLine()) - 1;
                    finalExam.Questions[i] = new MCQ_Question(header, body, mark, choices, correctChoice);
                }
            }

            Subject subject = new Subject(subjectId, subjectName, finalExam);
            subject.ShowSubjectDetails();


        }
        


    }   

    

     
}
