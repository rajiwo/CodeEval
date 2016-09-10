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
            line = "thisTHIS";
            MyLogic(line);

            line = "AAbbCCDDEE";
            MyLogic(line);

            line = "N";
            MyLogic(line);

            line = "UkJ";
            MyLogic(line);

            line = "Ullllll";
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
        float upper = 0;
        float lower = 0;

        foreach (char ch in line)
        {
            if(char.IsUpper(ch))
            {
                upper++;
            } else
            {
                lower++;
            }
        }
        Console.WriteLine("lowercase: {0:0.00} uppercase: {1:0.00}",lower/(upper+lower)*100, upper / (upper + lower) * 100);
    }
}