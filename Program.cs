using System;

namespace Projects
{
    class Program
    {
        Laptop[] stock=new Laptop[5];
        /* public void addToStock(Laptop laptop)
        {
            for(int index=0;index<stock.Length;index++)
            {
                if(stock[index]==null)
                {
                    stock[index]=laptop;
                    Console.WriteLine(laptop.getModel()+" has added to the stock");
                    break;
                }
            }
        } */
        public static String operator + (Program program,Laptop laptop)
        {
            for(int index=0;index<program.stock.Length;index++)
            {
                if(program.stock[index]==null)
                {
                    program.stock[index]=laptop;
                    return laptop.getModel()+" has added to the stock";
                }
            }
            return "Stock limit exceeded";
        }
        public override string ToString()
        {
            String tmp="";
            foreach(Laptop ptr in stock)
            {
                tmp+=ptr+"\n";
            }
            return tmp;
        }
        public static String operator / (Program program,double budget)
        {
            Console.WriteLine("Finding laptops matches with the cost: "+budget);
            String tmp="";
            foreach(Laptop ptr in program.stock)
            {
                if(ptr.getPrice()<=budget)
                {
                    tmp+=ptr+"\n";
                }
            }
            return tmp;
        }
        /* public String enquiry(Double budget)
        {
            Console.WriteLine("Finding laptops matches with the cost: "+budget);
            String tmp="";
            foreach(Laptop ptr in stock)
            {
                if(ptr.getPrice()<=budget)
                {
                    tmp+=ptr+"\n";
                }
            }
            return tmp;
        } */
        public String enquiry(Int32 SSD)
        {
            Console.WriteLine("Finding laptops matches with the SSD capacity: "+SSD);
            String tmp="";
            foreach(Laptop ptr in stock)
            {
                if(ptr.getSsd()<=SSD)
                {
                    tmp+=ptr+"\n";
                }
            }
            return tmp;
        }
        static void Main(string[] react)
        {
            Laptop laptop1=new Laptop();
            laptop1.setModel("Pavilion");laptop1.setBrand("HP");
            laptop1.setRam(8);laptop1.setSsd(512);laptop1.setHdd(0);laptop1.setPrice(43999.5);
            Laptop laptop2=new Laptop("Vostro1014","Dell",2,0,256,32100.6);
            Laptop laptop3=new Laptop("Satellite","Toshiba",2,0,500,29800.1);
            Laptop laptop4=new Laptop("Predator","Acer",6,128,1024,39100.6);
            Laptop laptop5=new Laptop("MacBook","Apple",8,512,1024,89340.9);

            Program program=new Program();
            Console.WriteLine(program+laptop1);
            Console.WriteLine(program+laptop2);
            Console.WriteLine(program+laptop3);
            Console.WriteLine(program+laptop4);
            Console.WriteLine(program+laptop5);
            //program.addToStock(laptop1);program.addToStock(laptop2);
            //program.addToStock(laptop3);program.addToStock(laptop4);program.addToStock(laptop5);

            //Console.WriteLine(program);

            //Console.WriteLine(program.enquiry(20000.4));
            Console.WriteLine(program/35000.4);
            Console.WriteLine(program.enquiry(256));
        }
    }   
}
