using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw0105_module11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            Console.WriteLine($"i:{i}");
            i+= 3; // =>i = i+3;
            Console.WriteLine($"i += 3:{i}");
            i-=3; // =>i = i-3;
            Console.WriteLine($"i -= 3:{i}");
            i*=3; // i = i*3;
            Console.WriteLine($"i *= 3:{i}");
            i/=3; // i = i/3;
            Console.WriteLine($"i /= 3:{i}");
            i%=3; // i = i%3;
            Console.WriteLine($"i %= 3:{i}");
            i++; // i = i+1;
            Console.WriteLine($"i ++= :{i}");
            i--; // i = i-1;
            Console.WriteLine($"i --= :{i}");

            int tall;
            tall = 170;
            //tall+=5;
            //變數可以作加減
            Console.WriteLine($"tall:{tall}");
            double pi;
            pi = 3.141526;
            Console.WriteLine($"pi:{pi}");

            const int C1 = 5;
            Console.WriteLine($"C1:{C1}");
            const int C2 = C1+5;
            //C2=C1+5;
            //常數不能隨意做加減
            Console.WriteLine($"C2:{C2}");
        }
    }
}
