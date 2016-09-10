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
                @"""id"": [0-9]+, ""label""",
                System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        System.Text.RegularExpressions.MatchCollection mc = r.Matches(line);

        Int32 id = 0;
        foreach(System.Text.RegularExpressions.Match m in mc)
        {
            string str = m.ToString();
            id+=Int32.Parse(str.Substring(6,str.IndexOf(',')-6));
        }
        Console.WriteLine(id);
    }
}