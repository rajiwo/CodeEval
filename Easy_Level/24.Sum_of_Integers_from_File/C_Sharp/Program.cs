using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Int32 sum = 0;
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                sum += Int32.Parse(line);
            }
        Console.WriteLine(sum);
    }

}