using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblerProblem
{
    internal class Gamblerpgm
    {
        int Totalstakes = 100;
       public static  Random random = new Random();
       int StakePerDay = random.Next(0, 1);
        public void BetMethod()
        { if(StakePerDay ==100)
            {
                Console.WriteLine("you have reached the limit");
            }
            else
            {
                Console.WriteLine("you can play more");
            }
        }
    
    }
}
