using System;
using System.IO;
using System.Text;

namespace Files
{
    class DemoStringWriteRead
    {
        static StringBuilder builder=new StringBuilder();

        public static void writeToTemp()
        {
            StringWriter writer=new StringWriter(builder);

            Console.WriteLine("Tell us something to write via string writer class: ");
            String hai=Console.ReadLine();
            writer.WriteLine(hai);

            writer.Flush();
            writer.Close();
        }
        public static void readFromTemp()
        {
            StringReader reader=new StringReader(builder.ToString());
            
            //Console.WriteLine(reader.ReadLine());
            Console.WriteLine(reader.ReadToEnd());
            
            reader.Close();
        }
    }
}