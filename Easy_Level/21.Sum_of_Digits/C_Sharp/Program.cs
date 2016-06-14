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
            line = "23";
            MyLogic(line);

            line = "496";
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

        int sum = 0;
        //ここから下に、自分で考えたアルゴリズムを書く。
        foreach(char ch in line)
        {
            sum += Int32.Parse(ch.ToString());
        }
        Console.WriteLine(sum);
    }
}