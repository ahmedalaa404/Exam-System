using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class practical:Question
    {


        public void setAnswerMcq()
        {
            string[] answers=new string[5];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter Answer OF ={i}th");
                answers[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter The Right Answer Of Q");
            answers[4]= Console.ReadLine();
            answer = answers;
        }



    }

    
}
