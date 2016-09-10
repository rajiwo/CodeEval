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
            line = "Hello world!";
            MyLogic(line);

            line = "JavaScript language 1.8";
            MyLogic(line);

            line = "A letter";
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
        string upper, lower;
        upper = line.ToUpper();
        lower = line.ToLower();

        char[] chrs = new char[line.Length];
        StringBuilder sb = new StringBuilder();

        for(Int32 i = 0; i < line.Length; i++)
        {
            if(line[i] == upper[i])
            {
                sb.Append(lower[i]);
            } else
            {
                sb.Append(upper[i]);
            }
        }
        Console.WriteLine(sb.ToString());
    }
}