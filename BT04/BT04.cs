using System;

namespace BT04
{
    internal class BT04
    {
        static void Main()
        {
            int i, j, count = 0;
            //Khai bao mang luu tru toi da 100
            int [] a = new int[100];
            int [] b = new int[100];

            Console.Write("Nhap so phan tu trong mang: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao mang: ", n);
            Console.WriteLine(" ");
            //vong lap for bat dau tu i = 0 cho den i < n
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
                b[i] = -1;
            }

            //dem so lan  xuat hien cua tung phan tu trong mang
            for (i = 0; i < n; i++)
            {
                count = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        b[j] = 0;
                    }
                }

                if (b[i] != 0)
                {
                    b[i] = count;
                }
            }
            Console.WriteLine("So lan xuat hien cua tung phan tu trong mang la: ");
            for (i = 0; i < n; i++)
            {
                if (b[i] != 0)
                {
                    Console.WriteLine("Phan tu {0} xuat hien {1} lan.", a[i], b[i]);
                }
            }

            //Tim phan tu lon nhat va phan tu nho nhat
            Console.WriteLine("Tim phan tu lon nhat va phan tu nho nhat trong mang");
            
            int max = a[0];
            int min = a[0];

            for (i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }


                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Phan tu lon nhat trong mang la: " + max);
            Console.WriteLine("Phan tu nho nhat trong mang la: " + min);

            Console.ReadKey();

        }
    }
}
