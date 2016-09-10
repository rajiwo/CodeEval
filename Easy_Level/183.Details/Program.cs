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
        string[] patterns = line.Split(',');
        int min = 10;

        foreach(string pattern in patterns)
        {
            int spcCnt = 0;
            int lastIndexX, startIndexY;

            lastIndexX = pattern.LastIndexOf('X');
            startIndexY = pattern.IndexOf('Y');

            int startIndex = pattern.IndexOf('.',lastIndexX +1);
            if(startIndex == -1 || startIndex > startIndexY)
            {
                min = 0;
                break;
            }

            for(int i = startIndex; i < pattern.Length; i++)
            {
                if(pattern[i] == '.')
                {
                    spcCnt++;
                } else
                {
                    break;
                }
            }
            if(min > spcCnt)
            {
                min = spcCnt;
            }
        }
        Console.WriteLine(min);
    }

}