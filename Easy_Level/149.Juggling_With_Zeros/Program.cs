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
            line = "00 0 0 00 00 0";
            MyLogic(line);

            line = "00 0";
            MyLogic(line);

            line = "00 0 0 000 00 0000000 0 000";
            MyLogic(line);

            line = "0 000000000 00 00";
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
        string[] zeros = line.Split(' ');
        StringBuilder sb = new StringBuilder();

        for(Int32 i = 0; i< zeros.Length; i+=2)
        {
            if(zeros[i] == "0")
            {
                //0をつなげる
                sb.Append(zeros[i + 1]);
            } else
            {
                //1をつなげる
                sb.Append(new string('1',zeros[i+1].Length));
            }
        }
        //Console.WriteLine(sb.ToString());
        Console.WriteLine(Convert.ToInt64(sb.ToString(),2));
    }

}