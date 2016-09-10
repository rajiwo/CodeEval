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
        string[] words = line.Split(' ');
        StringBuilder sb = new StringBuilder();

        foreach (string word in words)
        {
            sb.Append(word[word.Length - 1]);
            sb.Append(word.Substring(1,word.Length-2));
            sb.Append(word[0]);
            sb.Append(" ");
        }

        if (sb.Length > 0) sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());
    }
}