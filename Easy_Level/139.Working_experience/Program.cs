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
        System.Collections.Hashtable ht = new System.Collections.Hashtable();

        foreach (string term in line.Split(';'))
        {
            string trimedTerm = term.Trim();
            Int32 beginYear = 0, beginMonth = 0, endYear = 0, endMonth = 0;
            GetTerm(trimedTerm, ref beginYear, ref beginMonth, ref endYear, ref endMonth);

            //Console.WriteLine("{0} -> {1}{2:00} - {3}{4:00}", trimedTerm, beginYear,beginMonth,endYear,endMonth);

            int y = beginYear;
            int m = beginMonth;

            while(y*1000+m <= endYear*1000+endMonth)
            {
                if (!ht.ContainsKey(String.Format("{0}{1:00}", y, m)))
                {
                    ht.Add(String.Format("{0}{1:00}", y, m), 1);
                }
                m++;
                if(m == 13)
                {
                    m = 1;
                    y++;
                }
            }
        }
        /*
        foreach(string key in ht.Keys)
        {
            Console.WriteLine(key);
        }
        Console.WriteLine(ht.Keys.Count);
        */
        Console.WriteLine(ht.Keys.Count / 12);
    }

    public static void GetTerm(string inStr, ref Int32 beginYear, ref Int32 beginMonth, ref Int32 endYear, ref Int32 endMonth)
    {
        beginMonth = GetMonthFig(inStr.Substring(0, 3));
        beginYear = Int32.Parse(inStr.Substring(4,4));

        endMonth = GetMonthFig(inStr.Substring(9, 3));
        endYear = Int32.Parse(inStr.Substring(13, 4));

    }

    public static int GetMonthFig(string inStr)
    {
        switch(inStr)
        {
            case "Jan":
                return 1;
            case "Feb":
                return 2;
            case "Mar":
                return 3;
            case "Apr":
                return 4;
            case "May":
                return 5;
            case "Jun":
                return 6;
            case "Jul":
                return 7;
            case "Aug":
                return 8;
            case "Sep":
                return 9;
            case "Oct":
                return 10;
            case "Nov":
                return 11;
            case "Dec":
                return 12;
            default:
                return 0;
        }
    }
}