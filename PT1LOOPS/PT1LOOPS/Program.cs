using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT1LOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOOPS

            for (int i = 0; i < 100; i++)
            {
                if (i > 0)
                {
                    Console.WriteLine("Input 1st Exam Score");
                    int ExamScore1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input 2nd Exam Score");
                    int ExamScore2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input 3rd Exam Score");
                    int ExamScore3 = Convert.ToInt32(Console.ReadLine());
                    int AverageExamScores = ExamScore1 / 3 + ExamScore2 / 3 + ExamScore3 / 3;
                    Console.WriteLine("Your Average Exam Score is: " + AverageExamScores + "%");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Would You Like to Enter New Exam Scores? y/n");
                    string YN = Console.ReadLine();
                    if (YN == "n")
                    {
                        System.Environment.Exit(0);
                    }
                    

                }
                Console.WriteLine("git remote add origin https://github.com/MartinCarrion/THEHW1.git git push - u origin master");



            }







            Console.ReadKey();
        }
    }
}
