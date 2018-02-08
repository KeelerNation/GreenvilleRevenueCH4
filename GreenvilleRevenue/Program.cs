using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GreenvilleRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            string numPeopleOne, numPeopleTwo;
            int rev, num1, num2;

            

            Write("Number of contestants entered in last year's competition ... ");
            numPeopleOne = ReadLine();
            num1 = Convert.ToInt32(numPeopleOne);


            Write("Number of contestants entered in this year's competition ... ");
            numPeopleTwo = ReadLine();
            num2 = Convert.ToInt32(numPeopleTwo);

            rev = num1 * 25;
            WriteLine("Revenue for this year: ${0}", rev);


            if (num1 < num2 )
            {
                if (num1 * 2 <= num2)
                    WriteLine("The competition is more than twice as big this year!");

                else
                    WriteLine("The competition is bigger than ever");

            }

            else if (num1 * 2 < num2)
                WriteLine("The competition is more than twice as big this year!");

            else if (num1 > num2)
                WriteLine("A tighter race this year! Come out and cast your vote!");


            

            


           




        }
    }
}
