using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecideTime.Classes;

namespace DecideTime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Time to figure out what to do during free time:");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            DecisionLoop DL = new DecisionLoop();

            DL.DecideLoop();

            Console.ReadKey();
        }
    }
}
