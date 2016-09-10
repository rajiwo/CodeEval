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
        string[] chars = line.Split(' ');
        int n = (int)Math.Sqrt(chars.Length);
        string[] chs = new string[chars.Length];

        StringBuilder sb = new StringBuilder();

        int i = 0;
        for(int x = n-1; x >= 0; x--)
        {
            for(int y = 0; y <= n-1; y++)
            {
                chs[y * n + x] = chars[i];
                i++;
            }
        }

        foreach(string str in chs)
        {
            sb.AppendFormat("{0} ", str);
        }
        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());
    }

}