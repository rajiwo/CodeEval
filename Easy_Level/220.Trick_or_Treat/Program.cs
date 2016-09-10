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
        string[] strs = line.Split(":,".ToCharArray());
        int vampires = int.Parse(strs[1].Trim());
        int zombies = int.Parse(strs[3].Trim());
        int witches = int.Parse(strs[5].Trim());
        int houses = int.Parse(strs[7].Trim());
        int candies = (vampires * 3 + zombies * 4 + witches * 5) * houses;
        Console.WriteLine(Math.Truncate((double)candies / (double)(vampires + zombies + witches)));
    }
}