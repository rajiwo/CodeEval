using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
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

    static void MyLogic(string line)
    {

        //ここから下に、自分で考えたアルゴリズムを書く。
        int count = int.Parse(line.Split(';')[0]);
        string[] nums = line.Split(';')[1].Split(' ');
        int max = 0;

        for(int i=0; i <= nums.Length - count; i++)
        {
            int tmp = 0;
            for(int j=i; j < i + count; j++)
            {
                tmp += int.Parse(nums[j]);
            }
            if (max < tmp) max = tmp;
        }
        Console.WriteLine(max);
    }

}