using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Question
    {
        public Question()
        {

        }

        public  int mark  {set; get; }

        public int typeQistion { set; get; }
        public  string Header { get; set; }
        public  string  Body { get; set;  }

        public  string[] answer { get; set; }

        public void createMarks()
        {
            Console.WriteLine($"Enter Mark OF Q");
            int x = 0;
            bool flage=false;
            do
            {
                flage = int.TryParse(Console.ReadLine(), out x);
            } while (!flage);
            mark = x;
        }

        public void createHeader()
        {
            Console.WriteLine($"Enter Header OF Q");
            Header = Console.ReadLine();
        }
        public void createBody()
        {
            Console.WriteLine($"Enter Body OF Q");
            Body = Console.ReadLine();
        }








    }
}
