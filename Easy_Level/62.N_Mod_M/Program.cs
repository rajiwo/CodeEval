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
            line = "20,6";
            MyLogic(line);

            line = "2,3";
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
        string[] nums = line.Split(',');
        Int32 amari, wari;
        amari = Int32.Parse(nums[0]);
        wari = Int32.Parse(nums[1]);

        while (amari >= wari)
        {
            amari -= wari;
        }
        Console.WriteLine(amari);
    }
}