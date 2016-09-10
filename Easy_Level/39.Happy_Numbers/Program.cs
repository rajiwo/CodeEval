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
            line = "1";
            MyLogic(line);

            line = "7";
            MyLogic(line);

            line = "22";
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
        Int32 start = Int32.Parse(line);
        string str;
        System.Collections.Hashtable ht = new System.Collections.Hashtable();

        while(true)
        {
            Int32 nextnum = 0;
            foreach(char digit in line)
            {
                nextnum += (Int32) Math.Pow(double.Parse(digit.ToString()),2);
            }
            if(nextnum == 1)
            {
                str = "1";
                break;

            } else if (ht.ContainsKey(nextnum))
            {
                str = "0";
                break;
            }
            ht.Add(nextnum, nextnum);
            line = nextnum.ToString();
        }
        Console.WriteLine(str);
    }
}