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
        string[] words = line.Split('|')[0].Trim().Split(' ');
        string chars = line.Split('|')[1].Trim();
        StringBuilder sb = new StringBuilder();
        System.Collections.Hashtable ht = new System.Collections.Hashtable();

        foreach (char ch in chars)
        {
            if(ht.ContainsKey(ch))
            {

                ht[ch] = (int)ht[ch] + 1;
            }
            else
            {
                ht.Add(ch, 1);
            }
        }
        foreach (string word in words)
        {
            bool flg = true;
            foreach (char key in ht.Keys)
            {
                if (CountChar(word, key) >= (int)ht[key])
                {
                    flg = true;
                }
                else
                {
                    flg = false;
                    break;
                }
            }
            if (flg) sb.AppendFormat("{0} ", word);

        }
        if (sb.Length > 0) sb.Remove(sb.Length - 1, 1);
        if (sb.Length == 0)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine(sb.ToString());
        }
    }

    // 文字の出現回数をカウント
    public static int CountChar(string s, char c)
    {
        return s.Length - s.Replace(c.ToString(), "").Length;
    }
}