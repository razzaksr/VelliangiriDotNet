using System;

namespace Projects
{
    class Program:Transaction
    {
        static void Main(string[] react)
        {
            Card card=new Card();
            card.setAccBal(2300.7);
            card.setAccNum(87656789L);

            Console.WriteLine(card-4000);

            Wallet wallet=new Wallet();
            wallet.setAccBal(4590.3);
            wallet.setAccNum(9876567834L);

            Console.WriteLine(wallet*400);
        }
    }   
}
