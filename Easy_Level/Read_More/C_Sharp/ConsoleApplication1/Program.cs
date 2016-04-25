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

                // do something with line
                if (line.Length > 55)
                {

                    string ws = line.Substring(0, 40);
                    int iFind1 = ws.LastIndexOf(' ');
                    if(iFind1 > 0)
                    {
                        ws = ws.Substring(0, iFind1);
                    }
                    ws = ws.TrimEnd();

                    StringBuilder sb = new StringBuilder(ws);
                    sb.Append("... <Read More>");
                    Console.WriteLine(sb.ToString());
                }
                else
                {
                    Console.WriteLine(line);
                }

            }
    }
}
