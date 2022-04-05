using System;

namespace BaiTapMang
{
    class Program
    {
        static int[] taoMang(int n, int min, int max)
        {
            int[] arr = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rd.Next(min, max);
            }

            return arr;
        }

        static void xuatMang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }
        //Bai 61
        static void tinhTong(int[] arr, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    tong += arr[i];
                }
            }
            Console.WriteLine("\nTong cac so nguyen duong cua mang =  " + tong);

        }

        static void xoaphantu(int[] arr, int n, int p)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == p)
                {
                    arr[i] = arr[i + 1];
                    n--;
                }
            }
            
            Console.WriteLine("Mang sau khi xoa phan tu thu {0}: ", p);
            xuatMang(arr, n);
            Console.WriteLine("");
        }
        //end bai 61


        //bai 62

        static void kiemTraChanLe(int[] arr, int n)
        {
            int tchan = 0, tle = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0 && i % 2 != 0)
                {
                    tchan += arr[i];
                }
                if (arr[i] % 2 != 0 && i % 2 == 0)
                {
                    tle += arr[i];
                }
            }

            if (tchan != tle)
            {
                Console.WriteLine("\nTong le vi tri chan ({0}) khac tong chan vi tri le ({1})", tchan, tle);
            }
            else
            {
                Console.WriteLine("\nTong le vi tri chan ({0}) bang tong chan vi tri le ({1})", tchan, tle);
            }
        }

        static int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }

        static void kiemTraNT(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        arr[j--] = arr[--n];
                    }
                }
            }



            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (UCLN(arr[i], arr[j]) == 1)
                    {
                        Console.Write("\n{0}, {1}", arr[i], arr[j]);
                        Console.WriteLine("");
                    }
                }
            }
        }
        //end bai 62

        //bai 60

        static int[] perfectShuffle(int[] arr, int n)
        {
            int[] arr_PS = new int[n];
            for (int i = 0; i < n / 2; i++)
            {
                arr_PS[2 * i] = arr[i];
                arr_PS[2 * i + 1] = arr[n / 2 + i];
            }
            return arr_PS;
        }

        static bool soSanhMang(int[] a, int[] b, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        //end bai 60


        //bai 58

        static bool soNT(int n)
        {
            for(int i = 2; i <= n/2 ; i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void insoNT(int n)
        {
            
            for(int i = 2; i <= n; i++)
            {
                if(soNT(i))
                {
                    Console.Write(" " + i);
                }
            }
        }
        //end bai 58

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int chonBT;
            int n;
            Console.WriteLine("\t\t=================== Chon Bai Tap ====================");
            Console.WriteLine("Bai 58: Viết chương trình thực hiện thuật toán sàng Erastosthenes10 (Sieve of Erastosthenes) để in ra các số nguyên tố nhỏ hơn số n cho trước(n < 100)");
            Console.WriteLine("\t\t=====================================================");
            Console.WriteLine("Bai 59: Nhập vào năm Dương lịch, xuất tên năm Âm lịch. Xuất năm Dương lịch kế tiếp có cùng tên năm Âm lịch");
            Console.WriteLine("\t\t=====================================================");
            Console.WriteLine("Bai 60: Viết chương trình thực hiện những yêu cầu sau:\n" +
                                "\ta.Tạo ngẫu nhiên mảng một chiều n phần tử nguyên(n chẵn) có giá trị chứa " +
                                "trong đoạn[-100, 100] và xuất mảng.\n" +
                                "\tb.Viết hàm thực hiện việc trộn hoàn hảo(perfect shuffle) một mảng: sao cho " +
                                "các phần tử của một nửa mảng sau xen kẽ với các phần tử của một nửa mảng " +
                                "đầu.Xuất mảng sau khi trộn.\n" +
                                "\tc.Xác định số lần trộn hoàn hảo để mảng trở về như ban đầu");
            Console.WriteLine("\t\t=====================================================");
            Console.WriteLine("Bai 61: Viết chương trình thực hiện những yêu cầu sau:\n" +
                                "\ta.Tạo ngẫu nhiên mảng một chiều n phần tử nguyên có giá trị chứa trong đoạn " +
                                "[-100, 100] và xuất mảng.\n" +
                                "\tb.Tính tổng các số nguyên dương có trong mảng.\n" +
                                "\tc.Xóa phần tử có chỉ số p(p nhập từ bàn phím) trong mảng.");
            Console.WriteLine("\t\t=====================================================");
            Console.WriteLine("Bai 62: Viết chương trình thực hiện những yêu cầu sau:\n" +
                                "\ta.Tạo ngẫu nhiên mảng một chiều n phần tử nguyên dương có giá trị chứa " +
                                "trong đoạn[10, 20] và xuất mảng.\n" +
                                "\tb.Kiểm tra xem tổng các số chẵn ở vị trí lẻ có bằng tổng các số lẻ ở vị trí chẵn " +
                                "hay không ?\n" +
                                "\tc.Xác định xem mảng có cặp số nguyên tố cùng nhau(coprime) nào không.");
            do
            {
                Console.WriteLine("===============================================");
                Console.Write("Chon bai tap so (Nhap 0 de thoat!): ");
                chonBT = Convert.ToInt32(Console.ReadLine());
                switch (chonBT)
                {
                    case 58:
                        Console.WriteLine("===============================================");
                        Console.Write("Nhap n: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        insoNT(n);
                        Console.WriteLine("");
                        Console.WriteLine("===============================================");
                        break;
                    case 59:
                        Console.WriteLine("===============================================");
                        string[] can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
                        string[] chi = { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };
                        Console.Write("Nhap nam: ");
                        n = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("{0} - {1} {2}", n, can[n % 10], chi[n % 12]);

                        Console.WriteLine("{0} - {1} {2}", n += 60, can[n % 10], chi[n % 12]);
                        Console.WriteLine("===============================================");
                        break;
                    case 60:
                        Console.WriteLine("===============================================");
                        Console.WriteLine("Nhap n [1, 99] va n chan : ");
                        n = Convert.ToInt32(Console.ReadLine());

                        int[] arr = new int[n];
                        int[] b = new int[n];
                        int count = 0;
                        arr = b = taoMang(n, 10, 20);
                        Console.WriteLine("Mang vua tao ngau nhien: ");
                        xuatMang(arr, n);

                        Console.Write("\nMang sau khi perfect shuffle: ");
                        xuatMang(perfectShuffle(arr, n), n);

                        do
                        {
                            b = perfectShuffle(b, n);
                            count++;
                        } while (!soSanhMang(arr, b, n));
                        Console.WriteLine("\nCan {0} lan tron de mang quay tro ve lai ban dau", count);
                        Console.WriteLine("===============================================");
                        break;
                    case 61:
                        Console.WriteLine("===============================================");
                        Console.WriteLine("Nhap n [1, 99]: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        arr = taoMang(n, 10, 20);
                        Console.WriteLine("Mang vua tao ngau nhien: ");
                        xuatMang(arr, n);

                        tinhTong(arr, n);

                        Console.Write("nhap p [0, {0}]: ", n);
                        int p = Convert.ToInt32(Console.ReadLine());

                        xoaphantu(arr, n, p);
                        Console.WriteLine("===============================================");
                        break;
                    case 62:
                        Console.WriteLine("===============================================");
                        Console.WriteLine("Nhap n [1, 99]: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        arr = taoMang(n, 10, 20);
                        Console.WriteLine("Mang vua tao ngau nhien: ");
                        xuatMang(arr, n);

                        kiemTraChanLe(arr, n);

                        kiemTraNT(arr, n);
                        Console.WriteLine("===============================================");
                        break;
                    default:
                        if (chonBT == 0)
                        {
                            Console.WriteLine("Thoat!");
                            Console.WriteLine("===============================================");
                        }

                        else
                        {

                            Console.WriteLine("Khong co bai tap: {0}!", chonBT);
                            Console.WriteLine("===============================================");
                        }
                        break;
                }
            } while (chonBT != 0);

            #region bai 61
            /* arr = taomang(n, -100, 100);

             xuatmang(arr, n);

             tinhtong(arr, n);

             console.write("nhap p [0, {0}]: ", n);
             int p = convert.toint32(console.readline());

             xoaphantu(arr, n, p);*/

            #endregion


            #region bai 62

            //arr = taoMang(n, 10, 20);

            //xuatMang(arr, n);

            //kiemTraChanLe(arr, n);

            //kiemTraNT(arr, n);

            #endregion


            #region bai 60
            //int[] b = new int[n];
            //int count = 0;
            //arr = b = taoMang(n, 10, 20);

            //xuatMang(arr, n);

            //Console.Write("\nMang sau khi perfect shuffle ");
            //xuatMang(perfectShuffle(arr,n), n);

            //do
            //{
            //    b = perfectShuffle(b, n);
            //    count++;
            //} while (!soSanhMang(arr, b, n));
            //Console.WriteLine("\nCan {0} lan tron de mang quay tro ve lai ban dau", count);
            #endregion


            #region bai 59

            //string[] can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            //string[] chi = { "Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };
            //Console.Write("Nhap nam: ");
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("{0} - {1} {2}", n, can[n % 10], chi[n % 12]);

            //Console.WriteLine("{0} - {1} {2}", n += 60, can[n % 10], chi[n % 12]);
            //Console.ReadLine();

            #endregion


            Console.ReadKey();

        }
    }
}
