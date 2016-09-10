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
        string[] nums = line.Split(',');
        Int32 L = nums.Length;
        System.Collections.Hashtable htNumCount = new System.Collections.Hashtable();

        StringBuilder sb = new StringBuilder();


        foreach (string num in line.Split(','))
        {
            if (htNumCount.ContainsKey(num))
            {
                htNumCount[num] = (Int32)htNumCount[num] + 1;
            } else
            {
                htNumCount.Add(num, 0);
            }
        }

        string ans = "None";
        foreach (string key in htNumCount.Keys)
        {
            if ((Int32)htNumCount[key] >= L / 2)
            {
                ans = key;
            }
        }
        Console.WriteLine(ans);
    }

}