using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Int32[,] cells = new Int32[256, 256];

        for (Int32 i = 0; i < 256; i++)
        {
            for (Int32 j = 0; j < 256; j++)
            {
                cells[i, j] = 0;
            }
        }

        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                Int32 ans = 0;

                string line = reader.ReadLine();
                if (null == line)
                    continue;

                string[] strs = line.Split(' ');
                
                switch (strs[0])
                {
                    case "SetRow":
                        for (Int32 i = 0; i < 256; i++) cells[Int32.Parse(strs[1]), i] = Int32.Parse(strs[2]);
                        break;
                    case "SetCol":
                        for (Int32 i = 0; i < 256; i++) cells[i, Int32.Parse(strs[1])] = Int32.Parse(strs[2]);
                        break;
                    case "QueryRow":
                        ans = 0;
                        for (Int32 i = 0; i < 256; i++) ans += cells[Int32.Parse(strs[1]),i];
                        Console.WriteLine(ans);
                        break;
                    case "QueryCol":
                        ans = 0;
                        for (Int32 i = 0; i < 256; i++) ans += cells[i,Int32.Parse(strs[1])];
                        Console.WriteLine(ans);
                        break;
                    default:
                        break;
                }

            }
    }
}