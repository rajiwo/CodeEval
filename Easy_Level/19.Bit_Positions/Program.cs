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
            line = "86,2,3";
            MyLogic(line);

            line = "125,1,2";
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
        int n = Int32.Parse(nums[0]);
        int p1 = Int32.Parse(nums[1]);
        int p2 = Int32.Parse(nums[2]);
        string bit = Convert.ToString(n,2);

        if(bit[bit.Length -1 -p1 +1] == bit[bit.Length -1 -p2 +1]) {
            Console.WriteLine("true");
        } else {
            Console.WriteLine("false");
        }

    }
}