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
        string left = line.Split('|')[0].Trim();
        string right = line.Split('|')[1].Trim();
        int errCount = 0;

        int i = 0;
        foreach (char ch in left)
        {
            if (ch != right[i]) errCount++;
            i++;
            if (i >= right.Length)
            {
                errCount = errCount + left.Length - right.Length;
                break;
            }
        }

        if (errCount == 0)
        {
            Console.WriteLine("Done");
        }
        else if (errCount <= 2)
        {
            Console.WriteLine("Low");
        }
        else if (errCount <= 4)
        {
            Console.WriteLine("Medium");
        }
        else if (errCount <= 6)
        {
            Console.WriteLine("High");
        }
        else
        {
            Console.WriteLine("Critical");
        }
    }
}