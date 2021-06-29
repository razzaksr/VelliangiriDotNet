using System;
using System.IO;

namespace Files
{
    class DemoFileStream
    {
        static FileStream fileStream=null;
        public static void write()
        {
            fileStream=new FileStream("demofstream.doc",FileMode.OpenOrCreate);
            String hai=Console.ReadLine();
            foreach(char c in hai)
            {
                //Console.WriteLine(c);
                fileStream.WriteByte((byte)c);
            }
            fileStream.Close();
            Console.WriteLine(fileStream.Name+" content written");
        }
        public static void read()
        {
            fileStream=new FileStream("demofstream.doc",FileMode.OpenOrCreate);
            int hai=0;
            while((hai=fileStream.ReadByte())!=-1)
            {
                Console.Write((char)hai+" ");
            }
            fileStream.Close();
            Console.WriteLine(fileStream.Name+" content Readed successfully");
        }
    }
}