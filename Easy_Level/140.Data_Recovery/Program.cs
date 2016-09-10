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
        string[] words = line.Split(';')[0].Split(' ');
        string[] nums = line.Split(';')[1].Split(' ');

        System.Collections.Hashtable ht = new System.Collections.Hashtable();
        StringBuilder sb = new StringBuilder();

        Int32 i = 0;
        foreach (string num in nums)
        {
            ht.Add(num, words[i]);
            i++;
        }

        for(i = 1; i <= words.Length; i++)
        {
            if(ht.ContainsKey(i.ToString()))
            {
                sb.AppendFormat("{0} ", ht[i.ToString()]);
            } else
            {
                sb.AppendFormat("{0} ", words[words.Length-1]);
            }
        }
        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());
    }

}