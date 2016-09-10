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
        float wFloat;
        Int32 angle1, angle2, angle3;
        angle1 = Int32.Parse(line.Split('.')[0]);

        //小数部分のみ取り出して*60
        //wFloat = float.Parse(string.Format("0.{0}",line.Split('.')[1])) * 60;
        wFloat = (float.Parse(line) - angle1) * 60;
        angle2 = (Int32)System.Math.Truncate(wFloat);

        wFloat = (wFloat - angle2) * 60;
        angle3 = (Int32)System.Math.Truncate(wFloat);

        Console.WriteLine("{0}.{1:00}'{2:00}\"",angle1,angle2,angle3);
    }

}