using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        if (args.Length == 0)
        {
            string line;

            //サンプルの入力を渡す
            line = "Rkbs,5453; Wdqiz,1245; Rwds,3890; Ujma,5589; Tbzmo,1303;";
            MyLogic(line);

            line = "Vgdfz,70; Mgknxpi,3958; Nsptghk,2626; Wuzp,2559; Jcdwi,3761;";
            MyLogic(line);

            line = "Yvnzjwk,5363; Pkabj,5999; Xznvb,3584; Jfksvx,1240; Inwm,5720;";
            MyLogic(line);

            line = "Ramytdb,2683; Voclqmb,5236;";
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
        string[] delimiter = { ",", ";" };
        string[] strs = line.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder();

        System.Collections.Generic.List<Int32> distances = new System.Collections.Generic.List<Int32>();

        foreach (string str in line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries))
        {
            Int32 w;
            if (Int32.TryParse(str.Trim(),out w))
            {
                distances.Add(w);
            }
        }
        distances.Sort();

        sb.AppendFormat("{0},", distances[0]);

        for (Int32 i = 1;i < distances.Count;i++)
        {
            sb.AppendFormat("{0},",distances[i] - distances[i - 1]);
        }

        sb.Remove(sb.Length - 1, 1);
        Console.WriteLine(sb.ToString());
    }
}