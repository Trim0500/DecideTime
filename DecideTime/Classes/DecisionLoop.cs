using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecideTime.Classes
{
    public class DecisionLoop
    {
        string[] determinants = {"class in 10min", "more than 30min to spare", "an assignment due tomorrow", "a quiz tomorrow", "test next week", 
                                 "assignments due later (as in in 2 or more days)", "notes to revise", "an extracurricular project to work on", "club affairs to tend to"};

        public void DecideLoop()
        {
            string ans;

            foreach (string tempDeter in determinants)
            {
                Console.Write(string.Format("Do you have {0}? (yes/no : y/n)", tempDeter));
                ans = Console.ReadLine().ToUpper();
                while((ans != "YES" && ans != "Y") && (ans != "NO" && ans != "N"))
                {
                    Console.Write("Quit being coy! Answer the question!");
                    ans = Console.ReadLine().ToUpper();
                }
                if (tempDeter != determinants[1] && (ans == "YES" || ans == "Y"))
                {
                    Console.WriteLine(string.Format("You should do this during your free time: do/prep for {0}", tempDeter));
                    break;
                }
                else if (tempDeter == determinants[1] && (ans == "NO" || ans == "N")) {
                    Console.WriteLine("Find something to kill some time idk");
                    break;
                }
                else if (tempDeter == determinants[6] && (ans == "NO" || ans == "N"))
                    Console.WriteLine("You have nothing to do for school!");
                else if (tempDeter == determinants[8] && (ans == "NO" || ans == "N"))
                    Console.WriteLine("It's up to you with what you want to do during your free time!");
                Console.WriteLine();
            }
        }
    }
}
