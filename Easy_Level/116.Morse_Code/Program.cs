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
            line = ".- ...- ..--- .-- .... .. . -.-. -..-  ....- .....";
            MyLogic(line);

            line = "-... .... ...--";
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
        string[] delimiter = { "  " };
        string[] words = line.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);

        StringBuilder sb = new StringBuilder();
        foreach (string word in words)
        {
            foreach(string morse in word.Split(' '))
            {
                string letter = "";

                switch(morse)
                {
                    case ".-":
                        letter = "A";
                        break;
                    case "-...":
                        letter = "B";
                        break;
                    case "-.-.":
                        letter = "C";
                        break;
                    case "-..":
                        letter = "D";
                        break;
                    case ".":
                        letter = "E";
                        break;
                    case "..-.":
                        letter = "F";
                        break;
                    case "--.":
                        letter = "G";
                        break;
                    case "....":
                        letter = "H";
                        break;
                    case "..":
                        letter = "I";
                        break;
                    case ".---":
                        letter = "J";
                        break;
                    case "-.-":
                        letter = "K";
                        break;
                    case ".-..":
                        letter = "L";
                        break;
                    case "--":
                        letter = "M";
                        break;
                    case "-.":
                        letter = "N";
                        break;
                    case "---":
                        letter = "O";
                        break;
                    case ".--.":
                        letter = "P";
                        break;
                    case "--.-":
                        letter = "Q";
                        break;
                    case ".-.":
                        letter = "R";
                        break;
                    case "...":
                        letter = "S";
                        break;
                    case "-":
                        letter = "T";
                        break;
                    case "..-":
                        letter = "U";
                        break;
                    case "...-":
                        letter = "V";
                        break;
                    case ".--":
                        letter = "W";
                        break;
                    case "-..-":
                        letter = "X";
                        break;
                    case "-.--":
                        letter = "Y";
                        break;
                    case "--..":
                        letter = "Z";
                        break;
                    case ".----":
                        letter = "1";
                        break;
                    case "..---":
                        letter = "2";
                        break;
                    case "...--":
                        letter = "3";
                        break;
                    case "....-":
                        letter = "4";
                        break;
                    case ".....":
                        letter = "5";
                        break;
                    case "-....":
                        letter = "6";
                        break;
                    case "--...":
                        letter = "7";
                        break;
                    case "---..":
                        letter = "8";
                        break;
                    case "----.":
                        letter = "9";
                        break;
                    case "-----":
                        letter = "0";
                        break;
                }

                sb.Append(letter);
            }

            sb.Append(" ");
        }
        sb.Remove(sb.Length - 1, 1);
         Console.WriteLine(sb.ToString());
    }
}