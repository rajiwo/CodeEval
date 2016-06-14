using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        FileInfo fi = new System.IO.FileInfo(args[0]);
        //ファイルのサイズを取得
        Console.WriteLine(fi.Length);
    }
}