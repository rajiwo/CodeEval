using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {


        Int32 lastIndex = -1;
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                StringBuilder sb = new StringBuilder();
                Int32 newIndex;
                if (null == line)
                    continue;

                //1行目は"C"か"_"を"|"にする
                if (lastIndex == -1)
                {
                    sb.Append(line.Replace('_', '|'));
                    lastIndex = getTargetIndex(line);
                    Console.WriteLine(sb.ToString());
                    continue;
                }

                //2行目は以降"C"か"_"を"|"にする
                newIndex = getTargetIndex(line);
                if(lastIndex == newIndex)
                {
                    sb.AppendFormat("{0}|{1}",line.Substring(0, newIndex),line.Substring(newIndex+1));
                } else if (lastIndex < newIndex)
                {
                    sb.AppendFormat("{0}\\{1}", line.Substring(0, newIndex), line.Substring(newIndex + 1));
                }
                else
                {
                    sb.AppendFormat("{0}/{1}", line.Substring(0, newIndex), line.Substring(newIndex + 1));
                }
                Console.WriteLine(sb.ToString());
                lastIndex = newIndex;
            }
    }

    static Int32 getTargetIndex(string line)
    {
        if (line.Contains("C"))
        {
            // Cを通る
            return(line.IndexOf('C'));
        }
        else
        {
            // _を通る
            return (line.IndexOf('_'));
        }
    }
}