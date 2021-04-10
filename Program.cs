using System;
using System.IO;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "Z:\\.net programming lab\\lab 6.txt";
            Console.WriteLine("WRITING TO A FILE");
            WriteToFile(filepath);
            Console.WriteLine("READING FROM A FILE");
            ReadFromFile(filepath);
        }
        public static void ReadFromFile(string filepath)
        {
            StreamReader reader = new StreamReader(filepath);
            int count = 0;
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
                count++;
            }
            reader.Close();
        }
        public static void WriteToFile(string filepath)
        {
            StreamWriter writer = new StreamWriter(filepath, true);
            string temp = string.Empty;
            Console.WriteLine("enter name[-1 to exit]:");
            do
            {

                temp = Console.ReadLine();
                if (temp != "-1")
                {
                    writer.WriteLine(temp);
                }
            } while (temp != "-1");
            writer.Close();
            Console.ReadLine();
        }
    }
}




