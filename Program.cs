using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] react)
        {
            Laptop laptop1=new Laptop();
            laptop1.setModel("Pavilion");laptop1.setBrand("HP");
            laptop1.setRam(8);laptop1.setSsd(512);laptop1.setHdd(0);laptop1.setPrice(43999.5);
            Console.WriteLine(laptop1);

            Laptop laptop2=new Laptop("Vostro1014","Dell",2,0,256,32100.6);
            Console.WriteLine(laptop2.getModel()+" "+laptop2.getPrice());
        }
    }   
}
