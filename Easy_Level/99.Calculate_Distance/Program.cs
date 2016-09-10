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
            line = "(25, 4) (1, -6)";
            MyLogic(line);

            line = "(47, 43) (-25, -11)";
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
        //Regexオブジェクトを作成
        System.Text.RegularExpressions.Regex r =
            new System.Text.RegularExpressions.Regex(
                @"-*[0-9]+",
                System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        System.Text.RegularExpressions.MatchCollection mc = r.Matches(line);

        Console.WriteLine(Math.Sqrt(Math.Pow(double.Parse(mc[2].ToString()) - double.Parse(mc[0].ToString()), 2) + Math.Pow(double.Parse(mc[3].ToString()) - double.Parse(mc[1].ToString()), 2)));
    }
}