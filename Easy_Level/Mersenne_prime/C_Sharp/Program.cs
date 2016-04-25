using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line) continue;


                int w = int.Parse(line);

                // do something with line
                if (w > 2047)
                {
                    Console.WriteLine("3, 7, 31, 127, 2047");
                    continue;
                }
                if (w > 127)
                {
                    Console.WriteLine("3, 7, 31, 127");
                    continue;
                }
                if (w > 31)
                {
                    Console.WriteLine("3, 7, 31");
                    continue;
                }
                if (w > 7)
                {
                    Console.WriteLine("3, 7");
                    continue;
                }
                Console.WriteLine("3");
            }
    }
}
