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
        string[] nums = line.Split(' ');
        int min = -1;
        for(int i = 1; i < nums.Length; i++)
        {
            int total = 0;
            for(int j = 1; j < nums.Length; j++)
            {
                total += Math.Abs(int.Parse(nums[j]) - int.Parse(nums[i]));
            }
            if (min < 0 || total < min)
            {
                min = total;
            }
        } 

         Console.WriteLine(min);
    }

}