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
            line = "3 5 10";
            MyLogic(line);

            line = "2 7 15";
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
        string[] strNums = line.Split(' ');
        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= Int32.Parse(strNums[2]); i++)
        {
            string ans = i.ToString();
            if (i % Int32.Parse(strNums[0]) == 0 && i % Int32.Parse(strNums[1]) == 0)
            {
                ans = "FB";
            } else if (i % Int32.Parse(strNums[0]) == 0)
            {
                ans = "F";
            } else if (i % Int32.Parse(strNums[1]) == 0)
            {
                ans = "B";
            }
            sb.AppendFormat("{0} ",ans);
        }
        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());
    }
}