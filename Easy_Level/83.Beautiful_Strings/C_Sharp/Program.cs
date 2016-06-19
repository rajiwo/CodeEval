using System;
using System.Text;
using System.IO;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {

        if (args.Length == 0)
        {
            string line;

            //サンプルの入力を渡す
            line = "ABbCcc";
            MyLogic(line);

            line = "Good luck in the Facebook Hacker Cup this year!";
            MyLogic(line);

            line = "Ignore punctuation, please :)";
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
        Hashtable ht = new Hashtable();

        //ここから下に、自分で考えたアルゴリズムを書く。
        foreach(char ch in line)
        {
            if(char.IsLetter(ch)) {
                string str = ch.ToString().ToLower();
                if(ht.ContainsKey(str))
                {
                    ht[str] = (Int32)ht[str] + 1;
                } else
                {
                    ht.Add(str, 1);
                }
            }
        }

        Int32[] ints = new Int32[ht.Count];
        int i = 0;
        foreach(Int32 value in ht.Values)
        {
            ints[i] = value;
            i++;
        }
        Array.Sort(ints);
        Array.Reverse(ints);

        Int32 answer = 0;
        for(i = 0; i < ints.Length; i++)
        {
            answer += ints[i] * (26-i);
        }

        Console.WriteLine(answer);
    }
}