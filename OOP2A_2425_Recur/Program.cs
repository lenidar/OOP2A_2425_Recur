using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2A_2425_Recur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(multiplication(2,2,0));
            Console.WriteLine(multiplication(11, 12, 0));
            Console.WriteLine(multiplication(11, 5, 0));
            Console.WriteLine(multiplication(11, 5));
            Console.ReadKey();
        }

        static int multiplication(int a, int b, int ans)
        {
            ans += a;
            b--;
            if(b <= 0)
                return ans;
            else
                return multiplication(a,b,ans);
        }

        static int multiplication(int a, int b)
        {
            int ans = a;
            b--;
            if (b > 0)
                ans += multiplication(a, b);

            return ans;
        }
    }
}
