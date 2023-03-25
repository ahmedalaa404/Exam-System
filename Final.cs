using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Final:practical
    {

        public void setAnswerTrueOrFalse()
        {
            string name;
            bool flage=false;

            do
            {
                name = Console.ReadLine();
                if(name =="true" || name=="false")
                {
                    flage=true;
                }
                else
                {
                    Console.WriteLine("Choose Right Please ");
                    flage = false;
                }

            } while (!flage);

            answer = new string[] { "true", "false", name};
        }
    }
}
