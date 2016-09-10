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
        int x1 = int.Parse(line.Split(' ')[0]);
        int y1 = int.Parse(line.Split(' ')[1]);
        int x2 = int.Parse(line.Split(' ')[2]);
        int y2 = int.Parse(line.Split(' ')[3]);

        if(x1 == x2 && y1 == y2)
        {
            Console.WriteLine("here");
        } else
        {
            StringBuilder sb = new StringBuilder();
            if(y1 < y2)
            {
                sb.Append("N");
            } else if (y1 > y2)
            {
                sb.Append("S");
            }

            if (x1 < x2)
            {
                sb.Append("E");
            }
            else if (x1 > x2)
            {
                sb.Append("W");
            }
            Console.WriteLine(sb.ToString());
        }
    }

}