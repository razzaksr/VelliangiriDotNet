using System;
namespace Projects
{
    class Account
    {
        Int64 accNum;
        Double accBal;
        public void setAccNum(Int64 num){this.accNum=num;}
        public void setAccBal(Double bal){this.accBal=bal;}
        public Int64 getAccNum(){return accNum;}
        public Double getAccBal(){return accBal;}
    }   
}