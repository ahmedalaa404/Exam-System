using System.Collections;
using System.Diagnostics;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            //Exam e1= new Exam();
            //Console.WriteLine(e1.AnswersUser);


            Subject s1 = new Subject("c#", 30);
            s1.createExam();

            Console.WriteLine("Do u Want to Start the The Exam ??? { Y || N} ");
            char Start = char.Parse(Console.ReadLine());
            if (Start == 'Y' || Start == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                s1.EXAM.showExam(s1);
                Console.WriteLine($"The Elapsed Time == {sw.Elapsed} ");
            }




        }
    }
}