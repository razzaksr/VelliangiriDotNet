using System;
using System.IO;

namespace Files
{
    class DemoTextReadWrite
    {
        static FileInfo info=null;
        public static void writetoFile()
        {
            info=new FileInfo("D:\\Course backups\\Dotnet\\Velliangiri\\demotexts.xls");

            TextWriter writer=info.CreateText();
            for(int times=1;times<=5;times++)
            {
                String tmp=Console.ReadLine();
                writer.WriteLine(tmp);
            }

            //writer.Flush();
            writer.Close();
        }
        public static void readFromFile()
        {
            //info=new FileInfo("D:\\Course backups\\Dotnet\\Velliangiri\\demotexts.xls");
            info=new FileInfo("D:\\Course backups\\Python\\Kasthuri\\Python\\oop\\Hybrid.py");
            TextReader reader=info.OpenText();
            
            Console.WriteLine(reader.ReadToEnd());
            
            reader.Close();
        }
    }
}