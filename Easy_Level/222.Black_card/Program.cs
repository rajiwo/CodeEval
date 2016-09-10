using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

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
        string names = line.Split('|')[0];
        int num = int.Parse(line.Split('|')[1].Trim());

        List<string> list_names = new List<string>();

        //名前をリストに格納する
        foreach (string name in names.Split(' '))
        {
            if (name.Trim() == "") continue;

            list_names.Add(name);
        }

        //数字以上のものは順番に消えていくだけなのでカットする
        if(list_names.Count >= num) {
            list_names.RemoveRange(num - 1, list_names.Count - num + 1);
        }

        while (list_names.Count > 1)
        {
            int amari = num % list_names.Count;

            if (amari == 0) amari = list_names.Count;
            list_names.RemoveAt(amari - 1);
        }
        Console.WriteLine(list_names[0]);
    }
}