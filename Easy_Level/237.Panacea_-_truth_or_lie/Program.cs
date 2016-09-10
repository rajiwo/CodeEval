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
                if (null == line) continue;

                string[] firstSplit = line.Split('|');
                string[] hexs = firstSplit[0].Split(' ');
                string[] bins = firstSplit[1].Split(' ');

                int total_hex = 0;
                foreach (string hex in hexs)
                {
                    if (hex.Trim() == "") continue;
                    //Console.WriteLine("0x{0}={1}",hex, Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber));
                    total_hex += Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber);
                }

                int total_bin = 0;
                foreach (string bin in bins)
                {
                    if (bin.Trim() == "") continue;
                    //Console.WriteLine("0b{0}={1}", bin, Convert.ToInt32(bin, 2));
                    total_bin += Convert.ToInt32(bin, 2);
                }
                //Console.WriteLine("hex total:{0} bin total:{1}",total_hex,total_bin);
                Console.WriteLine(total_hex <= total_bin ? "True":"False");
            }
    }
}
