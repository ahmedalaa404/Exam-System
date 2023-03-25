using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Subject
    {

        public Subject(string name, int ID)
        {
            SubjName = name;
            IdSubject = ID;
        }
        public int IdSubject { get; set; }
        public string SubjName { get; set; }
        public Exam EXAM { get; set; }

        public Final[] Finals { get; set; }
        public practical[] ExPractical { get; set; }




        public void createExam()
        {
                 Exam F = new Exam();
            bool flageCheck;
      
            Console.WriteLine("Enter Number of examnation want do you exam it ");

            Console.WriteLine("(1)== Final Exam ");
            Console.WriteLine("(2)== Practicals Exam");
            int NumberOFType;
            do
            {
                flageCheck = int.TryParse(Console.ReadLine(), out NumberOFType);
                if (NumberOFType == 1 || NumberOFType == 2)
                {
                    flageCheck = true;
                }
                else
                {
                    Console.WriteLine("Please Sir Enter Valid Number , Don`t Small US please Sir");
                    flageCheck = false;
                }

            } while (!flageCheck);
         

            Console.WriteLine("-------------------");
         



            Console.WriteLine("Enter Time of Exam ");

            int TimeMinuts;
            do
            {
                flageCheck = int.TryParse(Console.ReadLine(),out TimeMinuts);

                if(flageCheck==false)
                {
                    Console.WriteLine("Enter time valid Of Exam , i don't handle The wrong Number here ");
                }
            } while (!flageCheck);
            Console.WriteLine("-------------------");
           





            Console.WriteLine("Enter Count of Question Exam ");

            int CountQuestionsOfExam;
            do
            {
               flageCheck= int.TryParse(Console.ReadLine(),out CountQuestionsOfExam);

            } while (!flageCheck);
            //Console.WriteLine("--------------------------------");
            F.EntandQnumber(TimeMinuts, CountQuestionsOfExam);
            EXAM = F;






            if (NumberOFType==1)
            {
                Finals = new Final[CountQuestionsOfExam];
                for (int i = 0; i < CountQuestionsOfExam; i++)
                {

                    Console.WriteLine($"Please Choose type of number Q{i+1}==>");
                    Console.WriteLine($"(1) ==True Or false");
                    Console.WriteLine($"(2)==MCQ");
                    int TypeQ;

                    do
                    {
                        flageCheck = int.TryParse(Console.ReadLine(), out TypeQ);
                        if (TypeQ==1 || TypeQ==2)
                        {
                            flageCheck = true;
                        }
                        else
                        {
                            Console.WriteLine("Please Enter Valid Number Of choose The Questons Of Exam");
                            flageCheck = false;
                        }
                    } while (!flageCheck);
                    Console.WriteLine("--------------------------------");


              

                    Finals[i] = new Final { typeQistion = TypeQ };
                    Finals[i].createHeader();
                    Finals[i].createBody();
                    Finals[i].createMarks();
                    if (TypeQ==1)
                    {
                        Console.WriteLine("Enter the Right Answer {true || false }");
                        Finals[i].setAnswerTrueOrFalse ();    
                    }
                    else
                    {
                        Finals[i].setAnswerMcq();
                    }
                    Console.WriteLine("--------------------------------");
                }
            }

            else
            {
                    
                ExPractical=new practical[CountQuestionsOfExam];
                for (int i = 0; i < CountQuestionsOfExam; i++)
                {
                        ExPractical[i] = new practical();
                        ExPractical[i].createHeader();
                        ExPractical[i].createBody();
                        ExPractical[i].createMarks();
                        ExPractical[i].setAnswerMcq();
                    Console.WriteLine("--------------------------------");
                }
            }
            Console.WriteLine("--------------------------------");
            Console.Clear();
        }
    }

}

