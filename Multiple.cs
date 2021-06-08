using System;
namespace Projects
{
    class CheckSome:Card, CardOperations
    {
        int pinNum;
        public CheckSome(){}
        public CheckSome(int p)=>pinNum=p;
        public bool validation(int pin)
        {
            if(pinNum==pin)
            {
                return true;
            }
            else
                return false;
        }
        public void billPay(int bill,String vendor)
        {
            Console.WriteLine("Enter the pin to validate: ");
            if(validation(Int32.Parse(Console.ReadLine()))==true)
            {
                if(bill<=getAccBal())
                {
                    setAccBal(getAccBal()-bill);
                    Console.WriteLine(bill+" bill paid to "+vendor);
                }
                else
                {
                    Console.WriteLine("Insufficient balance to pay "+bill+" to "+vendor);
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
        }
    }
    interface CardOperations
    {
        bool validation(int pin);
        void billPay(int bill, String vendor);
    }
}