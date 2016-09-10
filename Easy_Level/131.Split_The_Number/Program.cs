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
            line = "1,2,3,4;4,5,6";
            MyLogic(line);

            line = "20,21,22;45,46,47";
            MyLogic(line);

            line = "7,8,9;8,9,10,11,12";
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
        string[] strs = line.Split(' ');
        StringBuilder sb = new StringBuilder();
        char[] ope = { '+', '-' };

        Int32 opeIndex = strs[1].Trim().IndexOfAny(ope);
        Int32 a = Int32.Parse(strs[0].Substring(0, opeIndex));
        Int32 b = Int32.Parse(strs[0].Substring(opeIndex));
        //Console.WriteLine("{0} {1} {2}",a,strs[1][opeIndex],b);

        switch(strs[1][opeIndex])
        {
            case '+':
                Console.WriteLine(a+b);
                break;
            case '-':
                Console.WriteLine(a-b);
                break;
        }
    }

}