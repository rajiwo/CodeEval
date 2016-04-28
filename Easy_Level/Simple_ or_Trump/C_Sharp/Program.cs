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
                myLogic(line);

            }
        /*
                string line = "JH 10S | H";
                myLogic(line);
        */
    }

    static void myLogic(string line)
    {

        //strs[0],strs[1] ... cards、strs[3] ... win mark
        string[] strs = line.Split(' ');

        string card0_kind = strs[0].Substring(strs[0].Length - 1, 1);
        int card0_val = GetCardVal(strs[0].Substring(0, strs[0].Length - 1));

        string card1_kind = strs[1].Substring(strs[1].Length - 1, 1);
        int card1_val = GetCardVal(strs[1].Substring(0, strs[1].Length - 1));

        if (card0_kind == strs[3] && card1_kind != strs[3])
        {
            Console.WriteLine(strs[0]);
            return;
        }

        if (card1_kind == strs[3] && card0_kind != strs[3])
        {
            Console.WriteLine(strs[1]);
            return;
        }

        if (card0_val == card1_val)
        {
            Console.WriteLine("{0} {1}", strs[0], strs[1]);
            return;
        }
        if (card0_val > card1_val)
        {
            Console.WriteLine(strs[0]);
            return;
        } else
        {
            Console.WriteLine(strs[1]);
        }
    }

    // strong<- A K Q J 10 9 8 7 6 5 4 3 2 ->weak
    static int GetCardVal(string cardString)
    {
        switch (cardString)
        {
            case "A":
                return 14;
            case "J":
                return 11;
            case "Q":
                return 12;
            case "K":
                return 13;
            default:
                return Int32.Parse(cardString);
        }

    }
}
