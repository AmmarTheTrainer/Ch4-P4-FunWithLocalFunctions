using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_P4_FunWithLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lecture 4 - Project 4 - Local Functions ");



            Console.ReadLine();
        }

        static int AddWrapper(int x, int y)
        {
            //Do some validation here
            return Add();


            int Add()
            {
                return x + y;
            }
        }

        static int Add(int x, int y)
        {
            //Do some validation here
            return x + y;
        }
    }
}
