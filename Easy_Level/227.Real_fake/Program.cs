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
        string[] groups = line.Split(' ');

        System.Collections.Hashtable ht = new System.Collections.Hashtable();

        int sum = 0;
        foreach (string nums in groups)
        {
            sum += int.Parse(nums[0].ToString()) * 2;
            sum += int.Parse(nums[1].ToString());
            sum += int.Parse(nums[2].ToString()) * 2;
            sum += int.Parse(nums[3].ToString());
        }

        if(sum % 10 == 0)
        {
            Console.WriteLine("Real");
        }
        else
        {
            Console.WriteLine("Fake");
        }
    }
}