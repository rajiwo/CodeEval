using System;
using System.Text;

using System.IO;

class Program
{
    static bool debug = false;
    static void Main(string[] args)
    {
        if(debug)
        {
            string line;

            line = "4 3 2 1 | 1";
            MyLogic(line);

            line = "5 4 3 2 1 | 2";
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

        //strs[0],strs[1] ... cards、strs[3] ... win mark
        string[] strs = line.Split('|');

        string[] nums = strs[0].Trim().Split(' ');
        int iteTime = Int32.Parse(strs[1]);

        for(int i = 0; i < iteTime; i++)
        {
            MySort(ref nums);
        }
        Console.WriteLine(string.Join(" ",nums));

    }

    static void MySort(ref string[] nums)
    {
        for (int i = 0; i + 1 < nums.Length; i++)
        {
            //左の値 > 右の値 なら入れ替えてイテレーション終了
            if(Int32.Parse(nums[i]) > Int32.Parse(nums[i+1]))
            {
                string ws = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = ws;
                break;               
            }
        }
    }
}
