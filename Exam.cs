using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Exam
    {
        public int sumationMarks { get; set; }
        public int TotalMarks { get; set; }
        public int TimeExam { get; set; }
        public int NumberOFQuestion { get; set; }
        public Subject subject { get; set; }

        public AnswerOfQRight AnswersUser;


        public Exam()
        {
            

        }


        public void EntandQnumber(int x, int y)
        {
            TimeExam = x;
            NumberOFQuestion = y;
        }



        public void showExam(Subject s)
        {
            bool flageCheck;
            sumationMarks = 0;
            TotalMarks = 0;
            if (s.Finals is not null)
            {

                //Hashtable AnswersUserInExam = new Hashtable(s.Finals.Length);
                AnswersUser = new AnswerOfQRight(s.Finals.Length);
                Console.WriteLine("Final is not null");
                for (int i = 0; i < s.Finals.Length; i++)
                {
                    Console.WriteLine($"---Header OF Q{i + 1} ---- \n  {s.Finals[i].Header} \t marks ({s.Finals[i].mark})");
                    Console.WriteLine($"---body OF Q{i + 1}   ---- \n {s.Finals[i].Body}");
                    if (s.Finals[i].typeQistion == 1)
                    {
                        Console.WriteLine("------ choose answers { (1)== true ||(2) false }-----");

                        int AnswerNumberTrueOrFalse = 1;
                        do
                        {
                            flageCheck = int.TryParse(Console.ReadLine(), out AnswerNumberTrueOrFalse);
                            if (AnswerNumberTrueOrFalse == 1)
                            {
                                AnswersUser.Answers.Add(i, "true");
                            }
                            else if (AnswerNumberTrueOrFalse == 2)
                            {
                                AnswersUser.Answers.Add(i, "false");
                            }
                            else
                            {
                                Console.WriteLine("PLease Enter Valid Number Of Choose Answer");
                                flageCheck = false;

                            }

                        } while (!flageCheck);



                        if ((string)AnswersUser.Answers[i] == s.Finals[i].answer[2])
                        {
                            sumationMarks += s.Finals[i].mark;
                        }
                       


                    }





                    else
                    {
                        Console.WriteLine(s.Finals[i].answer.Length);
                        for (int n = 0; n < s.Finals[i].answer.Length - 1; n++)
                        {
                            Console.Write($"------({n + 1})={s.Finals[i].answer[n]} ------ \n");
                        }
                        int McqAnswers;

                        Console.WriteLine("Enter Number Of  Answers");
                        do
                        {

                            flageCheck = int.TryParse(Console.ReadLine(), out McqAnswers);
                            if (McqAnswers > 0 && McqAnswers < s.Finals[i].answer.Length)
                            {
                                flageCheck = true;
                                AnswersUser.Answers.Add(i, s.Finals[i].answer[McqAnswers - 1]);
                            }
                            else
                            {
                                flageCheck = false;
                                Console.WriteLine("Choose Valid Answer , Don't make me give you an exception that prevents your device from turning on again ");
                            }

                        } while (!flageCheck);
                        if ((string)AnswersUser.Answers[i] == s.Finals[i].answer[4])
                        {
                            sumationMarks += s.Finals[i].mark;
                        }
                    }
                    TotalMarks += s.Finals[i].mark;
                    Console.Clear();
                }
                Console.WriteLine("");
            }




            



            if (s.ExPractical is not null)
            {
                //Hashtable AnswersUserInExam = new Hashtable(s.ExPractical.Length);
                AnswersUser = new AnswerOfQRight(s.ExPractical.Length);

                Console.WriteLine("practicals is not null");
                for (int i = 0; i < s.ExPractical.Length; i++)
                {
                    Console.WriteLine($"---Header OF Q{i + 1} ---- \n  {s.ExPractical[i].Header}");
                    Console.WriteLine($"---body OF Q{i + 1}   ---- \n {s.ExPractical[i].Body}");

                    Console.WriteLine(s.ExPractical[i].answer.Length);


                    for (int n = 0; n < s.ExPractical[i].answer.Length - 1; n++)
                    {
                        Console.WriteLine($" ({n + 1}) == ({s.ExPractical[i].answer[n]})");
                    }
                    Console.WriteLine("\n-------------------------------------------------------");

                    int McqAnswers;

                    Console.WriteLine("Enter Number Of  Answers");
                    do
                    {

                                flageCheck = int.TryParse(Console.ReadLine(), out McqAnswers);
                        if (McqAnswers > 0 && McqAnswers <= s.ExPractical[i].answer.Length - 1)
                        {
                            flageCheck = true;
                            AnswersUser.Answers.Add(i, s.ExPractical[i].answer[McqAnswers - 1]);
                        }
                        else
                            Console.WriteLine("Choose Valid Answer , Don't make me give you an exception that prevents your device from turning on again ");
                            flageCheck = false;

                    } while (!flageCheck);

                    if ((string)AnswersUser.Answers[i] == s.ExPractical[i].answer[4])
                    {
                        sumationMarks += s.ExPractical[i].mark;
                    }
                    TotalMarks += s.ExPractical[i].mark;
                }
                Console.WriteLine("");
                Console.WriteLine("Enter Right Answers");
                AnswersUser.Answers = AnswersUser.Answers;
            }

            Console.Clear();
            GetMarksandSolutions(s);



        }





        public void GetMarksandSolutions(Subject s)
        {
            if (s.Finals is not null)
            {
                for (int i = 0; i < s.Finals.Length; i++)
                {
                    if (s.Finals[i].typeQistion == 1)
                    {
                        Console.WriteLine($"Q{i + 1}===={s.Finals[i].Body} (sloutions is == {s.Finals[i].answer[2]})\t({s.Finals[i].mark})");
                    }
                    else
                    {
                        Console.WriteLine($"Q{i + 1}===={s.Finals[i].Body} (sloutions is == {s.Finals[i].answer[4]})\t({s.Finals[i].mark})");
                    }
                }

                Console.WriteLine($"\n your Grade Is Equal == {sumationMarks} from {TotalMarks}");

            }

            if (s.ExPractical is not null)
            {
                for (int i = 0; i < s.ExPractical.Length; i++)
                {
                    Console.WriteLine($"Q{i + 1}:{s.ExPractical[i].Body}==({s.ExPractical[i].answer[4]}) \t ({s.ExPractical[i].mark}) ");
                }
                Console.WriteLine($"\n your Grade Is Equal == {sumationMarks} from {TotalMarks}");
            }
        }
    }
}





