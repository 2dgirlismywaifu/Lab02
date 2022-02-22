using System;

namespace BT03
{
    internal class BT03
    {
        static void Main()
        {
            int i, j, k, count = 0; //bien dem
            int count1 = 0; //dem so phan tu xuat hien duy nhat 1 lan

            //Khai bao mang luu tru toi da 100
            int[] a = new int[100];

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
            Console.WriteLine(" ");

            Console.WriteLine("Vui long lua chon: ");
            Console.WriteLine("1. Tim cac phan tu giong nhau trong mang");
            Console.WriteLine("2. Tim cac phan tu duy nhat trong mang");
            Console.Write("Nhap lua chon: ");
            int opt  = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.WriteLine("Cac phan tu giong nhau trong mang: ");
                    for (i = 0; i < n; i++)
                    {
                        for (j = i + 1; j < n; j++)
                        {
                            //tang bien dem khi tim thay phan tu giong nhau
                            if (a[i] == a[j])
                            {
                                count++;
                                Console.Write("{0} ", a[i]);
                                break;
                            }
                        }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("So phan tu giong nhau trong mang: " + count);


                    //Tim cac phan tu co duy nhat trong mang
                    Console.WriteLine("Cac phan tu duy nhat trong mang: ");
                    break;
                case 2:
                    //tim cac phan tu duy nhat trong mang
                    Console.WriteLine("Cac phan tu duy nhat trong mang la: ");                  
                    for (i = 0; i < n; i++)
                    {
                        count = 0;

                        /*kiem tra cac phan tu giong nhau truoc vi tri hien tai va  
                        tang count them 1 neu tim thay.*/
                        for (j = 0; j <= i - 1; j++)
                        {
                            /*tang bien dem khi tim thay phan tu giong nhau.*/
                            if (a[i] == a[j])
                            {
                                count++;
                            }
                        }
                        /*kiem tra cac phan tu giong nhau sau vi tri hien tai va  
                        tang bien_dem them 1 neu tim thay.*/
                        for (k = i + 1; k < n; k++)
                        {
                            /*tang bien dem khi tim thay phan tu giong nhau.*/
                            if (a[i] == a[k])
                            {
                                count++;
                            }
                        }
                        /*In gia tri cua vi tri hien tai trong mang - la gia tri duy nhat 
                        khi con tro van chua gia tri ban dau cua no.*/
                        if (count == 0)
                        {
                            count1++;
                            Console.Write("{0} ", a[i]);
                        }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("So phan tu xuat hien duy nhat trong mang: " + count1);
                    

                    break;
                default:
                    Console.WriteLine("Lua chon khong ton tai");
                    break;

            }
            Console.ReadKey();
        }
        
    }
}
