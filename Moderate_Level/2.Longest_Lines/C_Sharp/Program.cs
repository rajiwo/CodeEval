using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int num = 0;
        List<string> list = new List<string>();

        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == "") continue;

                if (num == 0)
                {
                    num = Int32.Parse(line);
                    continue;
                }

                if(list.Count == 0)
                {
                    list.Add(line);
                    continue;
                }

                for(int i = 0; i<list.Count; i++)
                {
                    if(list[i].Length < line.Length)
                    {
                        list.Insert(i, line);
                        if(list.Count > num) list.RemoveAt(num);
                        break;
                    }
                }
            }
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}