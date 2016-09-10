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
                if (null == line)
                    continue;
                MyLogic(line);

            }
    }

    static void MyLogic(string line)
    {

        //ここから下に、自分で考えたアルゴリズムを書く。
        Int32 age = Int32.Parse(line);
        if (0 <= age && age <= 2)
        {
            Console.WriteLine("Still in Mama's arms");
        }
        else if (3 <= age && age <= 4)
        {
            Console.WriteLine("Preschool Maniac");
        }
        else if (5 <= age && age <= 11)
        {
            Console.WriteLine("Elementary school");
        }
        else if (12 <= age && age <= 14)
        {
            Console.WriteLine("Middle school");
        }
        else if (15 <= age && age <= 18)
        {
            Console.WriteLine("High school");
        }
        else if (19 <= age && age <= 22)
        {
            Console.WriteLine("College");
        }
        else if (23 <= age && age <= 65)
        {
            Console.WriteLine("Working for the man");
        }
        else if (66 <= age && age <= 100)
        {
            Console.WriteLine("The Golden Years");
        } else
        {
            Console.WriteLine("This program is for humans");
        }
    }
}