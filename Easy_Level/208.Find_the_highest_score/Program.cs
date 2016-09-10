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
        string[] rows = line.Split('|');

        StringBuilder sb = new StringBuilder();

        int rowLength = rows.Length;
        int colLength = rows[0].Trim().Split(' ').Length;

        //Console.WriteLine("colLength={0} rowLength={1}", colLength, rowLength);

        for (int col = 0; col < colLength; col++)
        {
            int max = -2000;
            int now = 0;

            for (int row = 0; row < rowLength; row++)
            {
                now = int.Parse(rows[row].Trim().Split(' ')[col]);
                if (max < now) max = now;
            }
            sb.AppendFormat("{0} ", max);
        }
        
        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());
    }
}