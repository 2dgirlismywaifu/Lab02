using System;
using System.Linq;
using System.Collections.Generic;

namespace BT06
{
    internal class BT06
    {
        static void Main()
        {
            //Khai bao mang luu tru 
            List<int> a = new List<int>();

            int i;

            Console.Write("Nhap so phan tu trong mang: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao mang: ", n);
            Console.WriteLine(" ");
            //vong lap for bat dau tu i = 0 cho den i < n
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu {0}: ", i);
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //In mang ban dau
            Console.WriteLine("Mang ban dau:");
            foreach (int c in a)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine(" ");

        

        Start:
            Console.WriteLine("======================================================");
            Console.WriteLine("Lua chon chuc nang: ");
            Console.WriteLine("1. Sap xep mang theo thu tu tang dan");
            Console.WriteLine("2. Sap xep mang theo thu tu giam dan");
            Console.WriteLine("3. Chen phan tu vao trong mang (da sap xep)");
            Console.WriteLine("4. Chen phan tu vao trong mang (khong co thu tu)");
            Console.WriteLine("5. Xoa phan tu co trong mang");
            Console.WriteLine("6. Tim phan tu lon thu hai trong mang");
            Console.WriteLine("7. Tim phan tu nho thu hai trong mang");
            Console.Write("Nhap lua chon: ");
            int opt = Convert.ToInt32(Console.ReadLine());

        
            switch (opt)
            {
                case 1:
                    //for (i = 0; i < n; i++)
                    //{
                    //    for (j = i + 1; j < n; j++)
                    //    {
                    //        if (a[i] < a[j])
                    //        {
                    //            // Nếu a[i] < a[j] thì hoán đổi giá trị của a[i] và a[j]
                    //            temp = a[i];
                    //            a[i] = a[j];
                    //            a[j] = temp;
                    //        }
                    //    }
                    //}
                    //Console.WriteLine("In cac phan tu mang theo thu tu tang dan: ");
                    //for (i = 0; i < n; i++)
                    //{
                    //    Console.Write("{0}  ", a[i]);
                    //}
                    Console.WriteLine("In cac phan tu mang theo thu tu tang dan: ");
                    a.Sort();
                    foreach (int c in a)
                    {
                        Console.Write(c + " ");
                    }
                    Console.WriteLine(" ");
                    break;
                case 2:
                    //for (i = 0; i < n; i++)
                    //{
                    //    for (j = i + 1; j < n; j++)
                    //    {
                    //        if (a[i] > a[j])
                    //        {
                    //            // Nếu a[i] > a[j] thì hoán đổi giá trị của a[i] và a[j]
                    //            temp = a[i];
                    //            a[i] = a[j];
                    //            a[j] = temp;
                    //        }
                    //    }
                    //}
                    Console.WriteLine("In cac phan tu mang theo thu tu giam dan: ");
                    a.Reverse();
                    foreach (int c in a)
                    {
                        Console.Write(c + " ");
                    }
                    Console.WriteLine(" ");
                    break;
                case 3:
                    Console.WriteLine("Data bi override nen chua giai quyet dc");

                    break;
                case 4:
                    Console.Write("Nhap gia tri phan tu moi can chen: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap vi tri can chen phan tu moi nay: ");
                    int p = Convert.ToInt32(Console.ReadLine());
                    //Ham Insert
                    a.Insert(p, x);

                    Console.WriteLine("Sau khi chen phan tu, mang co dang: ");
                    foreach (int c in a)
                    {
                        Console.Write(c + " ");
                    }
                    Console.WriteLine(" ");
                    break;
                case 5:
                    Console.Write("Nhap vi tri trong mang can xoa: ");
                    int del = Convert.ToInt32(Console.ReadLine());
                    a.RemoveAt(del);
                    Console.WriteLine("Mang moi: ");
                    foreach (int c in a)
                    {
                        Console.Write(c + " ");
                    }
                    Console.WriteLine(" ");
                    break;
                case 6:
                    var secondmax = a.OrderByDescending(r => r).Take(2).LastOrDefault();
                    Console.WriteLine("So lon thu hai trong mang: " + secondmax);
                    break;
                case 7:
                    var secondmin = a.OrderBy(r => r).Take(2).LastOrDefault();
                    Console.WriteLine("So nho nhat thu hai trong mang: " + secondmin);
                    break;
                default:
                    Console.WriteLine("Lua chon {0} khong ton tai. Thu lai.....", opt);
                    goto Start;
            }
        
        
        Decide:
            Console.WriteLine("Tiep tuc (C/K): ");
            String decide_opt = Console.ReadLine();

           
            switch(decide_opt.ToUpper())
            {
                case "C":
                    goto Start;
                case "K":
                    break;
                default:
                    Console.WriteLine("Lua chon {0} khong ton tai. Thu lai.....", decide_opt);
                    goto Decide;
            }

            Console.ReadKey();

        }
    }
}
