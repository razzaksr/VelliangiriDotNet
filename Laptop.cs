using System;

namespace Projects
{
    class Laptop
    {
        String model, brand;
        Int32 ram, ssd, hdd;
        Double price;

        public void setModel(String model)
        {
            this.model=model;
        }
        public String getModel()
        {
            return model;
        }
        public void setBrand(String brand)
        {
            this.brand=brand;
        }
        public String getBrand(){return brand;}
        public void setRam(Int32 ram)
        {
            this.ram=ram;
        }
        public Int32 getRam(){return ram;}
        public void setSsd(Int32 ssd)
        {
            this.ssd=ssd;
        }
        public Int32 getSsd(){return ssd;}
        public void setHdd(Int32 hdd)
        {
            this.hdd=hdd;
        }
        public Int32 getHdd(){return hdd;}
        public void setPrice(Double price)
        {
            this.price=price;
        }
        public Double getPrice(){return price;}
        public Laptop()
        {
            Console.WriteLine("Default constructor");
        }

        public Laptop(String mod, String bnd, Int32 rm,Int32 sd,Int32 hd,Double cost)
        {
            model=mod;brand=bnd;ram=rm;ssd=sd;hdd=hd;price=cost;
        }

        public override String ToString()
        {
            return "Laptop Model "+model+" brand of "+brand+" with RAM capacity "+ram+" SSD of "+ssd+" HDD of "+hdd+" comes the price of "+price+"\n";
        }
    }
}