using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть номер закінчення послідовності n");
            Int64 n= Int64.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonachi(i)+" ");
            }
            
        }
        static Int64 Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}
