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
            line = "6";
            MyLogic(line);

            line = "153";
            MyLogic(line);

            line = "351";
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
        Int32 sum = 0;
        foreach(char ch in line)
        {
            sum += (Int32)Math.Pow(Int32.Parse(ch.ToString()),line.Length);
        }

        if(sum == Int32.Parse(line))
        {
            Console.WriteLine("True");
        } else
        {
            Console.WriteLine("False");
        }

    }

}