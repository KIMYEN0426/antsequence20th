using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "1";
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine(i + "번째 수열 : " + ans);
                int count = 0;
                char token = ans[0];
                string ans2 = "";
                for (int j=0; j<ans.Length; j++)
                {
                    if (token == ans[j])
                    {
                        count++;
                    }
                    else
                    {
                        ans2 += "" + token + count;
                        count = 0;
                        token = ans[j];
                        count++;
                    }
                    if (j + 1 == ans.Length)
                    {
                        ans2 += "" + token + count;
                    }
                }
                ans = ans2;
                i++;
            }
        }
    }
}
