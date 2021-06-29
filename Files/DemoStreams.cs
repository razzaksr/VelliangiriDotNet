using System;
using System.IO;

namespace Files
{
    class DemoStreams
    {
        static FileStream fileStream=null;
        public static void write()
        {
            fileStream=new FileStream("D:\\Course backups\\Dotnet\\Velliangiri\\demostreams.txt",FileMode.OpenOrCreate);
            StreamWriter writer=new StreamWriter(fileStream);

            Console.WriteLine("Tell us anything u wish to add into file: ");
            String users=Console.ReadLine();
            writer.WriteLine(users);

            writer.Close();
            fileStream.Close();

            Console.WriteLine(fileStream.Name+" has written");
        }
        public static void read()
        {
            fileStream=new FileStream("D:\\Course backups\\Java\\Warehouse.java",FileMode.OpenOrCreate);
            StreamReader reader=new StreamReader(fileStream);

            String line="";
            while((line=reader.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }

            reader.Close();
            fileStream.Close();

            Console.WriteLine(fileStream.Name+" has written");
        }
    }
}