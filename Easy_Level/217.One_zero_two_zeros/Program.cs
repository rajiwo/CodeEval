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
        int zeros = int.Parse(line.Split(' ')[0]);
        int num = int.Parse(line.Split(' ')[1]);
        int ans = 0;

        for (int i = 1; i <= num; i++)
        {
            string bits = Convert.ToString(i, 2);
            if (CountChar(bits, '0') == zeros)
            {
                ans++;
            } else
            {

            }
        }

        Console.WriteLine(ans);
    }

    // 文字の出現回数をカウント
    public static int CountChar(string s, char c)
    {
        return s.Length - s.Replace(c.ToString(), "").Length;
    }
}