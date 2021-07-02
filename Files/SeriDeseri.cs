using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Files
{
    class SeriDeseri
    {
        static FileStream fileStream=null;
        static BinaryFormatter format=new BinaryFormatter();

        public static void serialize()
        {
            fileStream=new FileStream("objects.txt",FileMode.OpenOrCreate);
            
            Game game=new Game(){Name="Free Fire",Org="Garena",Size=0.700,isCostLess=true,Device="Mobile"};

            format.Serialize(fileStream,game);

            fileStream.Close();

            Console.WriteLine("Serialization Done");
        }

        public static void deserialize()
        {
            fileStream=new FileStream("objects.txt",FileMode.OpenOrCreate);

            Game mine=(Game)format.Deserialize(fileStream);
            
            fileStream.Close();

            Console.WriteLine("Deserialized Object's data is: \n"+mine.Name+" "+mine.Device+" "+mine.isCostLess+" "+mine.Org+" "+mine.Size);
        }
    }
}