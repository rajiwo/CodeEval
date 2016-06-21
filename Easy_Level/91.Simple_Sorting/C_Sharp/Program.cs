using System;
using System.Text;
using System.IO;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {

        if (args.Length == 0)
        {
            string line;

            //サンプルの入力を渡す
            line = "70.920 -38.797 14.354 99.323 90.374 7.581";
            MyLogic(line);

            line = "-37.507 -3.263 40.079 27.999 65.213 -55.552";
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
        string[] nums = line.Split(' ');
        float[] flts = new float[nums.Length];

        StringBuilder sb = new StringBuilder();


        for(Int32 i = 0; i < nums.Length; i++)
        {
            flts[i] = float.Parse(nums[i]);
        }

        Array.Sort(flts);

        for (Int32 i = 0; i < flts.Length; i++)
        {
            sb.AppendFormat("{0} ", flts[i].ToString("0.000"));
        }
        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());

    }

}