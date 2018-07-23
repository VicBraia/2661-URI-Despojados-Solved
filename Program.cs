using System;
using System.Collections.Generic;
using System.Linq;

namespace despojados
{
    class Program
    {
        public static List<int> factors_N = new List<int>();
        public static List<long> resp = new List<long>();

        public static long N;

        public static bool IsDespojado(long n)
        {
            if (n == 1)
                return false;
            bool primo = true;
            bool resultado = true;

            int i = 2;
            long raiz = Convert.ToInt64(Math.Sqrt(n));

            while(resultado && i <= raiz)
            {
                long pow = Convert.ToInt64(Math.Pow(i, 2));
                if (n % pow == 0)
                {
                    resultado = false;
                }
                else if (n % i == 0)
                {
                    primo = false;
                }
                i++;
            }
            if (primo && resultado)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            N = long.Parse(Console.ReadLine());
            int cont = 0;
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    if (IsDespojado(i))
                    {
                        cont++;
                    }
                    if (i != N / i && IsDespojado(N/i))
                    {
                        cont++;
                    }
                }
            }
            int pow = Convert.ToInt32(Math.Pow(2, cont));
            cont = pow - cont - 1;
            Console.WriteLine(cont);

        }
    }
}
