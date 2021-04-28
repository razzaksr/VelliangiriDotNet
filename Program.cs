using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome to Indian Oil Gas Refilling booking system----------");
            Console.WriteLine("1. Verify your connection\n2. Book new refil\n3. Check status of refil\n4. Cancel refil\n5. Change connection detail");
            int option=Int32.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                Console.WriteLine("Enter the connection number to verify:");
                break;
                case 2:
                Console.WriteLine("You are requested an new refil; press 1 to confirm: ");
                int confirm=Int32.Parse(Console.ReadLine());
                if(confirm==1)
                {
                    var refer=new Random().Next(100000);
                    Console.WriteLine("Refil booked "+refer);
                }
                else
                {
                    Console.WriteLine("Booking cancelled");
                }
                break;
                case 3:
                Console.WriteLine("Enter the refernce number of refil to check");
                break;
                case 4:
                Console.WriteLine("Enter the reference number to cancel refil");
                break;
                case 5:
                Console.WriteLine("Enter the connection number to Change detail of ur wish:");
                break;
            }
        }
    }   
}
