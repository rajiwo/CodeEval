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
        int sec1, sec2, diff, h, m, s;

        string[] wStr;
        wStr = times[0].Split(':');
        sec1 = int.Parse(wStr[0]) * 3600 + int.Parse(wStr[1]) * 60 + int.Parse(wStr[2]);
        wStr = times[1].Split(':');
        sec2 = int.Parse(wStr[0]) * 3600 + int.Parse(wStr[1]) * 60 + int.Parse(wStr[2]);
        diff = (sec1 > sec2)? sec1 - sec2 : sec2 - sec1;

        h = diff / 3600;
        m = (diff % 3600) / 60;
        s = (diff % 3600) % 60;
        Console.WriteLine("{0:00}:{1:00}:{2:00}",h,m,s);
    }

}