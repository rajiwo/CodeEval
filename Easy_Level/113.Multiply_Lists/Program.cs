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
            line = "9 0 6 | 15 14 9";
            MyLogic(line);

            line = "5 | 8";
            MyLogic(line);

            line = "13 4 15 1 15 5 | 1 4 15 14 8 2";
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
        string[] nums = line.Split('|');
        string[] left = nums[0].Trim().Split(' ');
        string[] right = nums[1].Trim().Split(' ');

        StringBuilder sb = new StringBuilder();


        for (int i = 0; i < left.Length; i++)
        {

            sb.AppendFormat("{0} ",Int32.Parse(left[i]) * Int32.Parse(right[i]));
        }
        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());
    }

}