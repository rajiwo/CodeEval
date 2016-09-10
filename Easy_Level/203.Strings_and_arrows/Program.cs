﻿using System;
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
        int cnt = 0;
        for (int i = 0; i < line.Length - 5 + 1; i++)
        {
            if(line.Substring(i,5) == "<--<<" || line.Substring(i, 5) == ">>-->")
            {
                cnt++;
            }
        }
        Console.WriteLine(cnt);
    }
}