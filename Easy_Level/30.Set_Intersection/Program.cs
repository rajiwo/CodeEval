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
        string[] nums = line.Split(';');
        StringBuilder sb = new StringBuilder();

        System.Collections.Hashtable ht = new System.Collections.Hashtable();

        foreach(string num in nums[0].Split(','))
        {
            ht.Add(num, num);
        }

        foreach (string num in nums[1].Split(','))
        {
            if (ht.ContainsKey(num)) sb.AppendFormat("{0},", num);
        }
        if (sb.Length > 0) sb.Remove(sb.Length - 1, 1);
        if(sb.Length == 0)
        {
            Console.WriteLine("");
        } else
        {
            Console.WriteLine(sb.ToString());
        }
    }
}