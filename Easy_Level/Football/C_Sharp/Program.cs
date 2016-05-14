using System;
using System.Text;

using System.IO;

class Program
{
    static bool debug = false;
    static void Main(string[] args)
    {
        if (debug)
        {
            string line;

            line = "1 2 3 4 | 3 1 | 4 1";
            MyLogic(line);

            line = "19 11 | 19 21 23 | 31 39 29";
            MyLogic(line);
        }
        else
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
    }

    static void MyLogic(string line)
    {

        string[] teams = line.Split('|'); 
        string[] strAllNums = line.Replace(" | ", " ").Split(' ');
        Int32[] allNums = new Int32[strAllNums.Length];
        for(int i = 0; i < strAllNums.Length; i++)
        {
            allNums[i] = Int32.Parse(strAllNums[i]);
        }
        Array.Sort(allNums);

        StringBuilder ans = new StringBuilder("");
        int lastNum = 0;

        foreach (Int32 num in allNums)
        {
            if (num == lastNum) continue;
            ans.AppendFormat("{0}:{1}; ",num, GetTeamNo(num, teams));
            lastNum = num;
        }

        Console.WriteLine(ans.ToString());
    }

    static string GetTeamNo(Int32 num, string[] teams)
    {
        StringBuilder ans = new StringBuilder("");
        int teamNo = 1;
        foreach(string strTeamNums in teams)
        {
            foreach(string strTeamNum in strTeamNums.Split(' '))
            {
                if (strTeamNum == "") continue;
                if (num == Int32.Parse(strTeamNum))
                {
                    ans.AppendFormat("{0},",teamNo);
                    break;
                }
            }

            teamNo++;
        }

        //最後の","を削除
        ans.Remove(ans.Length - 1, 1);

        return ans.ToString();
    }
}
