using System;

namespace BT02
{
    internal class BT02
    {
        static void Main()
        {
            //Khai bao 2 mang luu tru toi da 100
            int[] a = new int[100];
            int[] b = new int[100];

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

            //sao chep mang
            Console.WriteLine(" ");
            a.CopyTo(b,0);
            
            //in cac phan tu trong mang b
            Console.WriteLine("Cac phan tu trong mang b la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", b[i]);
            }
            Console.WriteLine(" ");

            //tong cac phan tu trong mang
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.WriteLine("Tong cac phan tu trong mang a la: {0}", sum);

            Console.ReadKey();
        }
    }
}
