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
            line = "1,1,1,2,2,3,3,4,4";
            MyLogic(line);

            line = "2,3,4,5,5";
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
        StringBuilder sb = new StringBuilder();

        string laststr = "";
        foreach(string num in line.Split(','))
        {
            if (laststr != num) sb.AppendFormat("{0},",num);
            laststr = num;
        }
        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());
    }
}