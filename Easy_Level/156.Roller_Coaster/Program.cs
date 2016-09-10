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
        bool nowUpper = true;
        StringBuilder sb = new StringBuilder();

        foreach(char ch in line)
        {
            if(char.IsLetter(ch))
            {
                //アルファベットの場合
                sb.Append(nowUpper ? char.ToUpper(ch) : char.ToLower(ch));
                nowUpper = !nowUpper;
            }
            else
            {
                //アルファベット以外の場合
                sb.Append(ch);
            }
        }

        Console.WriteLine(sb.ToString());
    }
}