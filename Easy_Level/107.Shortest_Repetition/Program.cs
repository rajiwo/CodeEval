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
            line = "abcabcabcabc";
            MyLogic(line);

            line = "adcdefg";
            MyLogic(line);

            line = "dddd";
            MyLogic(line);

            line = "abacabacabac";
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

        char start_ch = ' ';
        Int32 len = 0;
        //ここから下に、自分で考えたアルゴリズムを書く。
        for(len = 0; len < line.Length; len++)
        {
            if (len == 0)
            {
                start_ch = line[len];
                continue;
            }
            if(start_ch == line[len])
            {
                if(line.Substring(0, len) == line.Substring(len, len)) break;
            }

        }
        Console.WriteLine(len);

    }
}