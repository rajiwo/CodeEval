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
            line = "Hello World";
            MyLogic(line);

            line = "Hello CodeEval";
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

        //ここから下に、自分で考えたアルゴリズムを書く。今は単に引数の文字列をそのまま出力するだけ
        string[] words = line.Split(' ');
        StringBuilder sb = new StringBuilder();

        for (int i = words.Length -1; i >= 0 ; i--)
        {
            sb.AppendFormat("{0} ", words[i]);
        }
        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());
    }
}