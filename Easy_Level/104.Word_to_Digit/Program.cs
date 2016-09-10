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
            line = "zero;two;five;seven;eight;four";
            MyLogic(line);

            line = "three;seven;eight;nine;two";
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

        StringBuilder sb = new StringBuilder(line);
        //ここから下に、自分で考えたアルゴリズムを書く。
        sb.Replace("zero", "0");
        sb.Replace("one", "1");
        sb.Replace("two", "2");
        sb.Replace("three", "3");
        sb.Replace("four", "4");
        sb.Replace("five", "5");
        sb.Replace("six", "6");
        sb.Replace("seven", "7");
        sb.Replace("eight", "8");
        sb.Replace("nine", "9");
        sb.Replace(";", "");
        Console.WriteLine(sb.ToString());
    }

}