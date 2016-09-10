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
            line = "abcdefghik";
            MyLogic(line);

            line = "Xa,}A#5N}{xOBwYBHIlH,#W";
            MyLogic(line);

            line = "(ABW>'yy^'M{X-K}q,";
            MyLogic(line);

            line = "6240488";
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
        StringBuilder sb = new StringBuilder();

        foreach (char ch in line)
        {
            switch(ch)
            {
                case 'a':
                case '0':
                    sb.Append("0");
                    break;
                case 'b':
                case '1':
                    sb.Append("1");
                    break;
                case 'c':
                case '2':
                    sb.Append("2");
                    break;
                case 'd':
                case '3':
                    sb.Append("3");
                    break;
                case 'e':
                case '4':
                    sb.Append("4");
                    break;
                case 'f':
                case '5':
                    sb.Append("5");
                    break;
                case 'g':
                case '6':
                    sb.Append("6");
                    break;
                case 'h':
                case '7':
                    sb.Append("7");
                    break;
                case 'i':
                case '8':
                    sb.Append("8");
                    break;
                case 'j':
                case '9':
                    sb.Append("9");
                    break;
            }
        }
        
        if (sb.Length == 0)
        {
            Console.WriteLine("NONE");
        }
        else
        {
            Console.WriteLine(sb.ToString());
        }
    }

}