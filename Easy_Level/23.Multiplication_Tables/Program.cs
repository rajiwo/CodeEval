using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        for (Int32 i = 1; i <=12; i++)
        {
            StringBuilder sb = new StringBuilder();
            for (Int32 j = 1; j <= 12; j++)
            {
                sb.AppendFormat("{0,4}",i*j);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}