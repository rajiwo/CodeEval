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
            line = "159";
            MyLogic(line);

            line = "296";
            MyLogic(line);

            line = "3992";
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
        Int32 in_num = Int32.Parse(line);
        Int32 wk_num;
        Int32 nokori_num;
        StringBuilder sb = new StringBuilder();

        //Console.WriteLine(line);

        // 1000の位
        wk_num = in_num / 1000; //言語仕様で少数以下は切り捨てられる
        nokori_num = in_num - wk_num * 1000;
        sb.Append(string.Concat(System.Linq.Enumerable.Repeat("M", wk_num)));
        //Console.WriteLine(wk_num);

        // 100の位
        wk_num = nokori_num / 100;
        nokori_num -= wk_num * 100;
        //Console.WriteLine(wk_num);

        switch (wk_num)
        {
            case 1:
            case 2:
            case 3:
                sb.Append(string.Concat(System.Linq.Enumerable.Repeat("C", wk_num)));
                break;
            case 4:
                sb.Append("CD");
                break;
            case 5:
                sb.Append("D");
                break;          
            case 6:
            case 7:
            case 8:
                sb.Append("D");
                sb.Append(string.Concat(System.Linq.Enumerable.Repeat("C", wk_num - 5)));
                break;
            case 9:
                sb.Append("CM");
                break;

        }

        // 10の位
        wk_num = nokori_num / 10;
        nokori_num -= wk_num * 10;
        //Console.WriteLine(wk_num);

        switch (wk_num)
        {
            case 1:
            case 2:
            case 3:
                sb.Append(string.Concat(System.Linq.Enumerable.Repeat("X", wk_num)));
                break;
            case 4:
                sb.Append("XL");
                break;
            case 5:
                sb.Append("L");
                break;
            case 6:
            case 7:
            case 8:
                sb.Append("L");
                sb.Append(string.Concat(System.Linq.Enumerable.Repeat("X", wk_num - 5)));
                break;
            case 9:
                sb.Append("XC");
                break;
        }


        // 1の位
        wk_num = nokori_num;
        //Console.WriteLine(wk_num);
        switch (wk_num)
        {
            case 1:
            case 2:
            case 3:
                sb.Append(string.Concat(System.Linq.Enumerable.Repeat("I", wk_num)));
                break;
            case 4:
                sb.Append("IV");
                break;
            case 5:
                sb.Append("V");
                break;
            case 6:
            case 7:
            case 8:
                sb.Append("V");
                sb.Append(string.Concat(System.Linq.Enumerable.Repeat("I", wk_num-5)));
                break;

            case 9:
                sb.Append("IX");
                break;

        }

         Console.WriteLine(sb.ToString());
    }
}