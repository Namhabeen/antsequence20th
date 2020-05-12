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
            string suyeol = "1";
            int n = 1;
            while (n <= 20)
            {

                Console.WriteLine(n + "번째 수열 : " + suyeol);
                char token = suyeol[0];
                int count = 0;
                string temp_suyeol = "";
                for (int i = 0; i < suyeol.Length; i++)
                {
                    if (token == suyeol[i])
                        count++;
                    else
                    {
                        temp_suyeol += "" + token + count;
                        count = 0;
                        token = suyeol[i];
                        count++;
                    }
                    if (i + 1 == suyeol.Length)
                        temp_suyeol += "" + token + count;
                }
                suyeol = temp_suyeol;
                n++;
            }

        }
    }
}
