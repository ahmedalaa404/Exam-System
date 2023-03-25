using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AnswerOfQRight
    {

        public Hashtable? Answers;


        public AnswerOfQRight(  int CountSize)
        {
             Answers = new Hashtable(CountSize);
        }

    }
}
