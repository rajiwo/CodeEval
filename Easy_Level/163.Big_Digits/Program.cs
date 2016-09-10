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
        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        StringBuilder sb3 = new StringBuilder();
        StringBuilder sb4 = new StringBuilder();
        StringBuilder sb5 = new StringBuilder();
        StringBuilder sb6 = new StringBuilder();

        string[] digits;
        foreach(char ch in line)
        {
            digits = GetDigits(ch);
            sb1.Append(digits[0]);
            sb2.Append(digits[1]);
            sb3.Append(digits[2]);
            sb4.Append(digits[3]);
            sb5.Append(digits[4]);
            sb6.Append(digits[5]);
        }
        Console.WriteLine(sb1.ToString());
        Console.WriteLine(sb2.ToString());
        Console.WriteLine(sb3.ToString());
        Console.WriteLine(sb4.ToString());
        Console.WriteLine(sb5.ToString());
        Console.WriteLine(sb6.ToString());
    }

    static string[] GetDigits(char ch)
    {

        switch (ch)
        {
            case '0':
                return new string[] { "-**--", "*--*-", "*--*-", "*--*-", "-**--", "-----" };
            case '1':
                return new string[] { "--*--", "-**--", "--*--", "--*--", "-***-", "-----" };
            case '2':
                return new string[] { "***--", "---*-", "-**--", "*----", "****-", "-----" };
            case '3':
                return new string[] { "***--", "---*-", "-**--", "---*-", "***--", "-----" };
            case '4':
                return new string[] { "-*---", "*--*-", "****-", "---*-", "---*-", "-----" };
            case '5':
                return new string[] { "****-", "*----", "***--", "---*-", "***--", "-----" };
            case '6':
                return new string[] { "-**--", "*----", "***--", "*--*-", "-**--", "-----" };
            case '7':
                return new string[] { "****-", "---*-", "--*--", "-*---", "-*---", "-----" };
            case '8':
                return new string[] { "-**--", "*--*-", "-**--", "*--*-", "-**--", "-----" };
            case '9':
                return new string[] { "-**--", "*--*-", "-***-", "---*-", "-**--", "-----" };
            default:
                return new string[] { "", "", "", "", "","" };
        }

    }


}