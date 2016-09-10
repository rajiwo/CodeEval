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
        bool inWord = false;
        StringBuilder sb = new StringBuilder();
        foreach (char ch in line)
        {
            if (char.IsLetter(ch))
            {
                if (!inWord && sb.Length > 0)
                {
                    sb.Append(" ");
                }
                inWord = true;
                sb.Append(char.ToLower(ch));
            } else
            {
                inWord = false;
            }
        }
        Console.WriteLine(sb.ToString());
    }
}