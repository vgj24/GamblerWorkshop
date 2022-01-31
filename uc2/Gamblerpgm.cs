using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblerProblem
{
    internal class Gamblerpgm
    {
        public const int Totalstakes = 100;
       public static  Random random = new Random();
        public static int StakePerDay = random.Next(0, 2);

        public int bet = 1;
        
        public void BetMethod()
        { 
            if(bet == Totalstakes)
            {
                Console.WriteLine("you have reached the limit");
            }
            else
            {
                Console.WriteLine("you can play more");
            }
        }
        public int WinLoose()
        {
            
            if(StakePerDay==1)
            {
                bet = bet + 1;
                Console.WriteLine("gambler win"+bet);
                
            }
            else
            {   bet= bet - 1;
                Console.WriteLine("Gambler loose"+bet);
            }
            return bet;
        }
    
    }
}
