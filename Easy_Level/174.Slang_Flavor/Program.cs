using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        int sNo = 1,cnt = 0;
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                StringBuilder sb = new StringBuilder();
                foreach (char ch in line)
                {
                    if(ch == '.' || ch == '!' || ch == '?')
                    {
                        cnt++;
                        if(cnt == 2)
                        {
                            //2回目の文章にスラングをつける
                            sb.Append(GetSlang(sNo));
                            //カウンタリセット
                            cnt = 0;
                            // 次のスラングにしておく
                            sNo++;
                            if (sNo > 8) sNo = 1;
                        }
                        else
                        {
                            sb.Append(ch);
                        }
                    }
                    else
                    {
                        sb.Append(ch);
                    }
                }
                Console.WriteLine(sb.ToString());
            }
    }

    public static string GetSlang(int sNo)
    {
        switch(sNo)
        {
            case 1:
                return (", yeah!");
            case 2:
                return (", this is crazy, I tell ya.");
            case 3:
                return (", can U believe this?");
            case 4:
                return (", eh?");
            case 5:
                return (", aw yea.");
            case 6:
                return (", yo.");
            case 7:
                return ("? No way!");
            case 8:
                return (". Awesome!");
            default:
                return ("");
        }
    }
}