using System;

namespace BT07
{
    internal class BT07
    {
        static void Main()
        {
            int i, j, n;
            int r1, c1; //hang va cot ma tran thu nhat
            int r2, c2; //hang va cot ma tran thu hai
            int flag = 1; //so sanh hai ma tran

            int[,] a = new int[100, 100];
            int[,] b = new int[100, 100];
            int[,] total = new int[100, 100];
            //ma tran thu nat
            int[] total1_column = new int[10];
            int[] total1_row= new int[10];
            //ma tran thu hai
            int[] total2_column = new int[10];
            int[] total2_row = new int[10];

            Console.WriteLine("Ma tran thu nhat");
            Console.Write("Nhap so hang: ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ma tran thu hai");
            Console.Write("Nhap so hang: ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            c2 = Convert.ToInt32(Console.ReadLine());

            //Nhap thong tin cac phan tu trong ma tran
            if (c1 != r2)
            {
                Console.WriteLine("Khong the nhan hai ma tran tren !!!");
                Console.WriteLine("So cot cua ma tran thu nhat phai bang so hang cua ma tran thu hai.");
            }
            else
            {
                Console.WriteLine("Nhap cac phan tu cua ma tran thu nhat:");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Nhap cac phan tu cua ma tran thu hai:");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                        b[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("In ma tran thu nhat: ");
                for (i = 0; i < r1; i++)
                {
                    Console.WriteLine(" ");
                    for (j = 0; j < c1; j++)
                        Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine(" ");
                
                Console.WriteLine("In ma tran thu hai: ");
                for (i = 0; i < r2; i++)
                {
                    Console.WriteLine(" ");
                    for (j = 0; j < c2; j++)
                        Console.Write("{0}\t", b[i, j]);
                }
                Console.WriteLine(" ");

            Start:
                Console.WriteLine("===========================================");
                Console.WriteLine("Lua chon chuc nang: ");
                Console.WriteLine("1. Cong hai mang ma tran");
                Console.WriteLine("2. Tru hai ma tran");
                Console.WriteLine("3. Nhan hai ma tran");
                Console.WriteLine("4. Tim ma tran chuyen vi");
                Console.WriteLine("5. Tinh tong hang va cot cua ma tran");
                Console.WriteLine("6. So sanh hai ma tran");
                Console.Write("Nhap lua chon: ");
                int opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        /* cong hai ma tran */
                        for (i = 0; i < r1; i++) //hang cua ma tran thu nhat 
                            for (j = 0; j < c2; j++) //cot cua ma tran thu hai 
                            {
                                total[i, j] = a[i, j] + b[i, j];
                            }
                        Console.WriteLine("Ma tran tong cua hai ma tran tren la: ");
                        for (i = 0; i < r1; i++)
                        {
                            Console.WriteLine(" ");
                            for (j = 0; j < c2; j++)
                                Console.Write("{0}\t", total[i, j]);
                        }
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        /* tru ma tran */
                        for (i = 0; i < r1; i++) //hang cua ma tran thu nhat 
                            for (j = 0; j < c2; j++) //cot cua ma tran thu hai 
                            {
                                total[i, j] = a[i, j] - b[i, j];
                            }
                        Console.WriteLine("Ma tran hieu cua hai ma tran tren la: ");
                        for (i = 0; i < r1; i++)
                        {
                            Console.WriteLine(" ");
                            for (j = 0; j < c2; j++)
                                Console.Write("{0}\t", total[i, j]);
                        }
                        Console.WriteLine(" ");
                        break;
                    case 3:
                        //nhan hai ma tran
                        for (i = 0; i < r1; i++)
                            for (j = 0; j < c2; j++)
                                total[i, j] = 0;
                        for (i = 0; i < r1; i++)    //hang cua ma tran thu nhat 
                        {
                            for (j = 0; j < c2; j++)    //cot cua ma tran thu hai 
                            {
                                int sum = 0;
                                for (int k = 0; k < c1; k++)
                                    sum += a[i, k] * b[k, j];
                                total[i, j] = sum;
                            }
                        }
                        Console.WriteLine("Ma tran tich cua hai ma tran tren la: ");
                        for (i = 0; i < r1; i++)
                        {
                            Console.WriteLine(" ");
                            for (j = 0; j < c2; j++)
                            {
                                Console.Write("{0}\t", total[i, j]);
                            }
                        }
                        Console.WriteLine(" ");

                        break;
                    case 4:
                        //tim ma tran chuyen vi
                        //ma tran thu nhat
                        Console.WriteLine("Tim ma tran chuyen vi cua ma tran thu nhat");
                        for (i = 0; i < r1; i++) //hang cua ma tran thu nhat 
                        {
                            for (j = 0; j < c1; j++) //cot cua ma tran thu nhat 
                            {

                                total[j, i] = a[i, j];
                            }
                        }

                        Console.WriteLine("In ma tran chuyen vi: ");
                        for (i = 0; i < c1; i++)
                        {
                            Console.WriteLine(" ");
                            for (j = 0; j < r1; j++)
                            {
                                Console.Write("{0}\t", total[i, j]);
                            }
                        }
                        Console.WriteLine(" ");

                        //ma tran thu hai
                        Console.WriteLine("Tim ma tran chuyen vi cua ma tran thu nhat");
                        for (i = 0; i < r2 ; i++) //hang cua ma tran thu hai
                        {
                            for (j = 0; j < c2; j++) //cot cua ma tran thu hai 
                            {

                                total[j, i] = a[i, j];
                            }
                        }

                        Console.WriteLine("In ma tran chuyen vi: ");
                        for (i = 0; i < c2; i++)
                        {
                            Console.WriteLine(" ");
                            for (j = 0; j < r1; j++)
                            {
                                Console.Write("{0}\t", total[i, j]);
                            }
                        }
                        Console.WriteLine(" ");
                        break;
                    case 5:
                        /* tinh tong cac hang */
                        //Ma tran thu nhat
                        for (i = 0; i < r1; i++)
                        {
                            total1_row[i] = 0;
                            for (j = 0; j < r1; j++)
                                total1_row[i] = total1_row[i] + a[i, j];
                        }
                        //Ma tran thu hai
                        for (i = 0; i < r2; i++)
                        {
                            total2_row[i] = 0;
                            for (j = 0; j < r2; j++)
                                total2_row[i] = total2_row[i] + b[i, j];
                        }

                        /* tinh tong cac cot */
                        //Ma tran thu nhat
                        for (i = 0; i < c1; i++)
                        {
                            total1_column[i] = 0;
                            for (j = 0; j < c1; j++)
                                total1_column[i] = total1_column[i] + a[j, i];
                        }
                        //Ma tran thu hai
                        for (i = 0; i < c2; i++)
                        {
                            total2_column[i] = 0;
                            for (j = 0; j < c2; j++)
                                total2_column[i] = total2_column[i] + a[j, i];
                        }

                        Console.WriteLine("Tong cua cac hang va cac cot trong ma tran thu nhat la: ");
                        for (i = 0; i < c1; i++)
                        {
                            for (j = 0; j < c1; j++)
                            Console.Write("{0}    ", a[i, j]);
                            Console.Write("| {0}     ", total1_column[i]);
                            Console.WriteLine(" ");
                        }
                        Console.WriteLine(" ");
                        for (j = 0; j < r2; j++)
                        {
                            Console.Write(" | {0}    ", total1_row[j]);
                        }
                        Console.WriteLine(" ");

                        Console.WriteLine("Tong cua cac hang va cac cot trong ma tran thu hai la: ");
                        for (i = 0; i < c2; i++)
                        {
                            for (j = 0; j < c2; j++)
                            Console.Write("{0}    ", b[i, j]);
                            Console.Write("| {0}     ", total2_column[i]);
                            Console.WriteLine(" ");
                        }
                        Console.WriteLine(" ");
                        for (j = 0; j < r2; j++)
                        {
                            Console.Write("| {0}    ", total2_row[j]);
                        }
                        Console.WriteLine(" ");
                        break;
                    case 6:
                        /* so sanh xem hai ma tran co bang nhau khong */

                        if (r1 != r2 && c1 != c2)
                        {
                            Console.WriteLine("Khong the so sanh hai ma tran nay! ");
                        }
                        else
                        {
                            Console.WriteLine("Co the so sanh hai ma tran nay! ");
                            for (i = 0; i < r1; i++)  //hang cua ma tran thu nhat
                            {
                                for (j = 0; j < c2; j++) //cot cua ma tran thu hai
                                {
                                    if (a[i, j] != b[i, j])
                                    {
                                        flag = 0;
                                        break;
                                    }
                                }
                            }
                            if (flag == 1)
                                Console.Write("Hai ma tran bang nhau.\n\n");
                            else
                                Console.Write("Hai ma tran khong bang nhau\n\n");
                        }
                        break;
                    default:
                        Console.WriteLine("Lua chon {0} khong ton tai. Thu lai.....", opt);
                        goto Start;
                }

            Decide:
                Console.WriteLine("Tiep tuc (C/K): ");
                String decide_opt = Console.ReadLine();


                switch (decide_opt.ToUpper())
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
}
