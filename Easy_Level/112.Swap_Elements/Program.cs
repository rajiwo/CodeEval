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
            line = "1 2 3 4 5 6 7 8 9 : 0-8";
            MyLogic(line);

            line = "1 2 3 4 5 6 7 8 9 10 : 0-1, 1-3";
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
        string[] strs = line.Split(':');
        StringBuilder sb = new StringBuilder();
        System.Collections.Generic.List<string> nums = new System.Collections.Generic.List<string>();
        System.Collections.Generic.List<string> cmds = new System.Collections.Generic.List<string>();

        foreach (string str in strs[0].Split(' '))
        {
            if (str.Trim() == "") continue;
            nums.Add(str);
        }

        foreach (string str in strs[1].Split(','))
        {
            if (str.Trim() == "") continue;
            cmds.Add(str.Trim());
        }

        foreach (string cmd in cmds)
        {
            string[] indxs = cmd.Split('-');
            string wk_str;
            wk_str = nums[Int32.Parse(indxs[0])];
            nums[Int32.Parse(indxs[0])] = nums[Int32.Parse(indxs[1])];
            nums[Int32.Parse(indxs[1])] = wk_str;
        }

        foreach (string str in nums)
        {
            sb.AppendFormat("{0} ",str);
        }
        if (sb.Length > 0) sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());
    }

}