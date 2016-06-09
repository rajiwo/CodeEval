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
            line = "2 0 6 3 1 6 3 1 6 3 1";
            MyLogic(line);

            line = "3 4 8 0 11 9 7 2 5 6 10 1 49 49 49 49";
            MyLogic(line);

            line = "1 2 3 1 2 3 1 2 3";
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
        int start_index;

        for (start_index = nums.Length - 2; start_index >= 0; start_index--)
        {
            if (nums[start_index] == nums[nums.Length - 1]) break;
        }
        start_index++;

        StringBuilder sb = new StringBuilder();
        for (int i = start_index; i < nums.Length; i++)
        {
            sb.AppendFormat("{0} ", nums[i]);
        }
        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());

    }
}