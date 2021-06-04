using System;
namespace Projects
{
    class Card:Account
    {
        public static Double operator- (Card obj, int amt)// object-2000
        {
            if(obj.getAccBal()>=amt)
            {
                obj.setAccBal(obj.getAccBal()-amt);
                Console.WriteLine(amt+" Amount debited");
            }
            else{
                Console.WriteLine("Insufficient amount");
            }
            return obj.getAccBal();
        }
    }
    class Wallet:Account
    {
        public static String operator*(Wallet obj,int tarrif)
        {
            if(tarrif==200 || tarrif==399 || tarrif==599)
            {
                if(obj.getAccBal()>=tarrif)
                {
                    obj.setAccBal(obj.getAccBal()-tarrif);
                    return tarrif+" has reacherged";
                }
                else{
                    return tarrif+" is not due to insufficient balance";
                }
            }
            else{
                return tarrif+" amount is invalid";
            }
        }
    }
}