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
        string word = line.Split(' ')[0];
        string mask = line.Split(' ')[1];
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < word.Length; i++)
        {
            if (mask[i] == '1')
            {
                sb.Append(word.ToUpper()[i]);
            }
            else
            {
                sb.Append(word[i]);
            }
        }
        Console.WriteLine(sb.ToString());
    }
}