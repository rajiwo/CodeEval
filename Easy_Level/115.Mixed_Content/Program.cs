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
            line = "8,33,21,0,16,50,37,0,melon,7,apricot,peach,pineapple,17,21";
            MyLogic(line);

            line = "24,13,14,43,41";
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
        string[] strs = line.Split(',');
        StringBuilder sb_letter = new StringBuilder(), sb_figure = new StringBuilder();


        foreach (string str in strs)
        {
            Int32 w;
            if (Int32.TryParse(str, out w))
            {
                sb_figure.AppendFormat("{0},", str);
            } else
            {
                sb_letter.AppendFormat("{0},", str);
            }
        }

        if (sb_letter.Length > 0) sb_letter.Remove(sb_letter.Length - 1, 1);
        if (sb_figure.Length > 0) sb_figure.Remove(sb_figure.Length - 1, 1);

        Console.Write(sb_letter);
        if (sb_letter.Length > 0 && sb_figure.Length > 0) Console.Write("|");
        Console.Write(sb_figure);
        Console.WriteLine();

    }

}