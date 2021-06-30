using System;
using System.IO;

namespace Files
{
    class DemoBinaries
    {
        public static void write()
        {
            using(BinaryWriter writer=new BinaryWriter(File.Open("demobins.txt",FileMode.OpenOrCreate)))
            {
                writer.Write(12);
                writer.Write("Free fire");
                writer.Write(false);
                writer.Write(8.9);
                Console.WriteLine("Content written in file");
            }
        }
        public static void read()
        {
            using(BinaryReader reader=new BinaryReader(File.Open("demobins.txt",FileMode.Open)))
            {
                Console.WriteLine(reader.ReadInt32());
                Console.WriteLine(reader.ReadString());
                Console.WriteLine(reader.ReadBoolean());
                Console.WriteLine(reader.ReadDouble());
            }
        }
    }
}