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
            line = "0";
            MyLogic(line);

            line = "1";
            MyLogic(line);

            line = "2";
            MyLogic(line);

            line = "5";
            MyLogic(line);

            line = "12";
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

        Int32 a = 1, b = 0;
        Int32 ans = 0;

        //ここから下に、自分で考えたアルゴリズムを書く。
        for (Int32 i = 1; i <= Int32.Parse(line); i++)
        {
            ans = a + b;
            a = b;
            b = ans;
        }

        Console.WriteLine(ans);
    }
}