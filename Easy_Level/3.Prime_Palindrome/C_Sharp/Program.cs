using System;
using System.Text;

using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int ans;
        for (ans = 999; ans > 0; ans = ans - 2)
        {
            bool prime = true;
            for(int j=2; j < ans; j++)
            {
                //割り切れるものがあれば素数ではない
                if (ans % j == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime == false) continue;

            if (ans>99)
            {
                //3桁の場合は1桁目と3桁目が同じならOK
                if (ans.ToString()[0] == ans.ToString()[2]) break;
            } else
            {
                //2桁の場合は1桁目と2桁目が同じならOK
                if (ans.ToString()[0] == ans.ToString()[1]) break;
            }
        }
        Console.WriteLine(ans);
    }
}
