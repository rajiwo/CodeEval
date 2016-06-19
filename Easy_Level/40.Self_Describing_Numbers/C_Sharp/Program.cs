using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        if (args.Length == 0)
        {
            string line;

            //サンプルの入力を渡す
            line = "2020";
            MyLogic(line);

            line = "22";
            MyLogic(line);

            line = "1210";
            MyLogic(line);

        }
        else
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
    }

    static void MyLogic(string line)
    {

        //ここから下に、自分で考えたアルゴリズムを書く。
        for (Int32 i = 0; i < line.Length; i++) {
            if(CountChar(line,i.ToString()[0]) != Int32.Parse(line[i].ToString()))
            {
                Console.WriteLine("0");
                return;
            }
        }
        Console.WriteLine("1");
    }

    // 文字の出現回数をカウント
    public static Int32 CountChar(string s, char c)
    {
        return s.Length - s.Replace(c.ToString(), "").Length;
    }
}