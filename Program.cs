using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell us annual salary: ");
            double salary=Double.Parse(Console.ReadLine());
            /* switch(salary)
            {
                case 3:Console.WriteLine("Personal Loan worth 1lack will be offered");break;
                case 2:Console.WriteLine("Credit card worth 50k eligible for u");break;
                default:Console.WriteLine("Nothing eligibile");break;
            } */
            if(salary>=3.5&&salary<6.1)
            {
                Console.WriteLine("Personal Loan worth 1lack will be offered");
            }
            else if(salary>=2.5&&salary<5)
            {
                Console.WriteLine("Credit card worth 50k offered");
            }
            else if(salary>=6)
            {
                Console.WriteLine("Business loan 3Lack will be offered");
            }
            else{
                Console.WriteLine("Nothing eligibile");
            }
        }
    }   
}
