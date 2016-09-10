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
            line = "";
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

        //ここから下に、自分で考えたアルゴリズムを書く。今は単に引数の文字列をそのまま出力するだけ

        int total = 2;
        int cnt = 1;
        int num = 3;

        while(true)
        {
            if(CheckPrime(num))
            {
                //素数の場合は合計に加える
                total += num;
                cnt++;
                //Console.WriteLine(num);

                if (cnt == 1000) break;
            }

            //奇数だけ調べる
            num += 2;
            if(num > 100000)
            {
                Console.WriteLine("over 10000");
                break;
            }
        }

        Console.WriteLine(total);
    }

    static bool CheckPrime(int num)
    {
        bool ret = true;

        for(int i=3; i <= Math.Sqrt(num); i++)
        {
            if(num%i == 0)
            {
                ret = false;
                break;
            }
        }
        return ret;
    }
}