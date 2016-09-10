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
        string[] times = line.Split(' ');
        System.Collections.Generic.List<int> nums = new System.Collections.Generic.List<int>();
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < times.Length; i++)
        {
            nums.Add(int.Parse(string.Format("{0}{1}{2}", times[i].Substring(0, 2), times[i].Substring(3, 2), times[i].Substring(6, 2))));
        }
        nums.Sort();
        nums.Reverse();

        for (int i = 0; i < times.Length; i++)
        {
            string hhmmss = string.Format("{0:000000}", nums[i]);
            sb.AppendFormat("{0}:{1}:{2} ", hhmmss.Substring(0, 2), hhmmss.Substring(2, 2), hhmmss.Substring(4, 2));
        }
        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());
    }
}