using System;

namespace BT05
{
    internal class BT05
    {
        static void Main()
        {
            //Khai bao mang luu tru toi da 100
            int[] a = new int[100];
            int[] b = new int[100]; //mang chan
            int[] c = new int[100]; //mang le

            int i, j = 0, k = 0;

            Console.Write("Nhap so phan tu trong mang: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao mang: ", n);
            Console.WriteLine(" ");
            //vong lap for bat dau tu i = 0 cho den i < n
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            //chia mang lam mang chan va mang le
            for (i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b[j] = a[i];
                    j++;
                }
                else
                {
                    c[k] = a[i];
                    k++;
                }
            }

            Console.WriteLine("Cac phan tu chan la: ");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", b[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Cac phan tu le la: ");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", c[i]);
            }
            Console.WriteLine(" ");

            Console.ReadKey();
        }
    }
}
