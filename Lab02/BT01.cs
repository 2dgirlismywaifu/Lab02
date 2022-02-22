using System;

namespace Lab02
{
    internal class BT01
    {
        static void Main()
        {
            //Khai bao mang luu tru toi da 100
            int[] a = new int[100];

            Console.Write("Nhap so phan tu trong mang: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao mang: ", n);
            Console.WriteLine(" ");
            //vong lap for bat dau tu i = 0 cho den i < n
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            //in cac phan tu theo chieu xuoi
            Console.WriteLine(" ");
            Console.WriteLine("Cac phan tu luu tru trong mang: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }

            //in cac phan tu theo chieu nguoc
            Console.WriteLine(" ");
            Console.WriteLine("In mang theo chieu dao nguoc: ");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
    }
}
