using System;
namespace Projects
{
    class Netbanking:Card
    {
        public Netbanking(){}
        public Netbanking(Int64 num,Double bal)
        {
            setAccBal(bal);
            setAccNum(num);
        }
        public static String operator + (Netbanking netbanking,int amt)
        {
            netbanking.setAccBal(netbanking.getAccBal()+amt);
            return netbanking.getAccNum()+" has deposited with "+amt;
        }
        public override String ToString()
        {
            return getAccNum()+" has "+getAccBal()+" as available balance";
        }
    }
}