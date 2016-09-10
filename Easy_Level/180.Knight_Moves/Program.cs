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
        int x, y;
        x = GetCol(line[0]);
        y = int.Parse(line[1].ToString());
        StringBuilder sb = new StringBuilder();
        string ans;

        //x-2 y-1 or y+1
        ans = GetPos(x - 2, y - 1);
        if (ans != null)
        {
            sb.AppendFormat("{0} ", ans);
        }

        ans = GetPos(x - 2, y + 1);
        if (ans != null)
        {
            sb.AppendFormat("{0} ", ans);
        }

        //x-1 y-2 or y+2
        ans = GetPos(x - 1, y - 2);
        if (ans != null)
        {
            sb.AppendFormat("{0} ", ans);
        }
        ans = GetPos(x - 1, y + 2);
        if (ans != null)
        {
            sb.AppendFormat("{0} ", ans);
        }

        //x+1 y-2 or y+2
        ans = GetPos(x + 1, y - 2);
        if (ans != null)
        {
            sb.AppendFormat("{0} ", ans);
        }
        ans = GetPos(x + 1, y + 2);
        if (ans != null)
        {
            sb.AppendFormat("{0} ", ans);
        }

        //x+2 y-1 or y+1
        ans = GetPos(x + 2, y - 1);
        if (ans != null)
        {
            sb.AppendFormat("{0} ", ans);
        }
        ans = GetPos(x + 2, y + 1);
        if (ans != null)
        {
            sb.AppendFormat("{0} ", ans);
        }

        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());
    }

    public static int GetCol(char c)
    {
        switch (c)
        {
            case 'a':
                return (1);
            case 'b':
                return (2);
            case 'c':
                return (3);
            case 'd':
                return (4);
            case 'e':
                return (5);
            case 'f':
                return (6);
            case 'g':
                return (7);
            case 'h':
                return (8);
            default:
                return (0);
        }
    }

    public static string GetPos(int x, int y)
    {
        if (1 <= x && x <= 8 && 1 <= y && y <= 8)
        {
            switch (x)
            {
                case 1:
                    return (string.Format("a{0}", y));
                case 2:
                    return (string.Format("b{0}", y));
                case 3:
                    return (string.Format("c{0}", y));
                case 4:
                    return (string.Format("d{0}", y));
                case 5:
                    return (string.Format("e{0}", y));
                case 6:
                    return (string.Format("f{0}", y));
                case 7:
                    return (string.Format("g{0}", y));
                case 8:
                    return (string.Format("h{0}", y));
                default:
                    return (null);
            }
        }
        else
        {
            return (null);
        }

    }
}