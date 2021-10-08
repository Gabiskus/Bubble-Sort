using System;

namespace Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0,x = 0, i= 0,prom,n;
            Console.WriteLine("Unesi velicinu");
            n = Convert.ToInt32(Console.ReadLine());
            int[] niz = new int [n];
            while (i < n)
            {
                niz[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            while (y < n-1)
            {
                while (x < n-1)
                {
                    if (niz[x] < niz[x+1]) {
                        prom = niz[x];
                        niz[x] = niz[x + 1];
                        niz[x + 1] = prom;

                    }
                    x++;                     
                }
                x = 0;
                y++;
            }
            Console.WriteLine();
            i = 0;
            while ( i < n)
            {
                Console.WriteLine(niz[i]);
                i++;
            }


        }
    }
}
