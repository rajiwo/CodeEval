using System;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        if (args.Length == 0)
        {
            string line;

            //サンプルの入力を渡す
            line = "3 3 9 1 6 5 8 1 5 3";
            MyLogic(line);

            line = "9 2 9 9 1 8 8 8 2 1 1";
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

        //ここから下に、自分で考えたアルゴリズムを書く。
        Hashtable ht_unique = new Hashtable();
        Hashtable ht_index = new Hashtable();
        List<Int32> nums = new List<Int32>();

        Int32 pos = 1;
        foreach (string str in line.Split(' ')) {
            if(ht_unique.ContainsKey(str)) {
                ht_unique[str] = false;                
            } else {
                ht_unique[str] = true;
                ht_index.Add(str,pos);
            }
            nums.Add(Int32.Parse(str));
            pos++;
        }

        nums.Sort();

        string ans="0";
        foreach (int num in nums) {
            if((bool)ht_unique[num.ToString()]) {
                ans = ht_index[num.ToString()].ToString();
                break;
            }   
        }
        Console.WriteLine(ans);
    }
}