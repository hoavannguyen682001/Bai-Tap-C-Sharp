using System;

namespace tong_hop_11_bai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int chonBT;
            Console.WriteLine("=================== Chon Bai Tap ====================");
            Console.WriteLine("Bai 1: Nhập vào diện tích S của một mặt cầu. Tính thể tích V của hình cầu này");
            Console.WriteLine("Bai 2: Nhập vào tọa độ 2 điểm A(xA, yA) và B(xB, yB). Tính khoảng cách AB.");
            Console.WriteLine("Bai 6: Viết chương trình nhập vào ba số nguyên. Hãy in ba số này ra màn hình theo thứ tự tăng dần và chỉ dùng tối đa một biến phụ.");
            Console.WriteLine("Bai 7: Viết chương trình giải phương trình bậc 1: ax + b = 0 (a, b nhập từ bàn phím) Xét tất cả các trường hợp có thể.");
            Console.WriteLine("Bai 11: Viết trò chơi bao - đá - kéo");
            Console.WriteLine("Bai 13: Viết chương trình nhập vào ngày, tháng, năm. Kiểm tra ngày và tháng nhập có hợp lệ hay không. Tính thứ trong tuần của ngày đó");
            Console.WriteLine("Bai 20: Viết chương trình nhập số kW điện đã tiêu thụ");
            Console.WriteLine("Bai 22: Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n ");
            Console.WriteLine("Bai 23: Viết chương trình tìm các số hoàn hảo (perfect number) nhỏ hơn một số nguyên dương n cho trước");
            Console.WriteLine("Bai 31: Viết chương trình in bảng cửu chương từ 2 đến 9 ra màn hình");
            Console.WriteLine("Bai 36: Viết chương trình in ra n số nguyên tố đầu tiên (n nhập từ bàn phím)");
            Console.WriteLine("=================== Nhap 0 de thoat ====================");


            do
            {
                Console.WriteLine("\nChon bai tap so: ");
                chonBT = Convert.ToInt32(Console.ReadLine());
                switch (chonBT)
                {
                    case 1:
                        {
                            Console.WriteLine("Bai 1: Nhập vào diện tích S của một mặt cầu. Tính thể tích V của hình cầu này");
                            double S, r, V;
                            const double pi = 3.141593;

                            Console.Write("Nhap vao dien tich S cua mat cau: ");
                            S = Convert.ToDouble(Console.ReadLine());
                            r = Math.Sqrt(S / (4 * pi));
                            V = (4 * pi * Math.Pow(r, 3)) / 3;
                            Console.Write("The tich V : " + V + " " + r);
                        }

                        break;
                    case 2:
                        {
                            Console.WriteLine("Bai 2: Nhập vào tọa độ 2 điểm A(xA, yA) và B(xB, yB). Tính khoảng cách AB.");
                            double xA, yA, xB, yB, AB;
                            Console.Write("A(xA, yA)? ");
                            xA = Convert.ToDouble(Console.ReadLine());
                            yA = Convert.ToDouble(Console.ReadLine());
                            Console.Write("B(xB, yB)? ");
                            xB = Convert.ToDouble(Console.ReadLine());
                            yB = Convert.ToDouble(Console.ReadLine());

                            AB = Math.Abs(Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2)));

                            Console.WriteLine("|AB| = " + Math.Round(AB, 4));
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Bai 6: Viết chương trình nhập vào ba số nguyên. Hãy in ba số này ra màn hình theo thứ tự tăng dần và chỉ dùng tối đa một biến phụ.");
                            int a, b, c, temp;
                            Console.WriteLine("Nhap a, b, c: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            b = Convert.ToInt32(Console.ReadLine());
                            c = Convert.ToInt32(Console.ReadLine());

                            if (a > b)
                            {
                                temp = b;
                                b = a;
                                a = temp;
                            }
                            if (a > c)
                            {
                                temp = a;
                                a = c;
                                c = temp;
                            }
                            if (b > c)
                            {
                                temp = c;
                                c = b;
                                b = temp;
                            }


                            Console.WriteLine("tang dan {0}{1}{2}", a, b, c);
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Bai 7: Viết chương trình giải phương trình bậc 1: ax + b = 0 (a, b nhập từ bàn phím) Xét tất cả các trường hợp có thể.");
                            double a, b;

                            Console.WriteLine("Nhap a, b: ");

                            a = Convert.ToDouble(Console.ReadLine());
                            b = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Phuong trinh cua ban: {0}x + {1} = 0", a, b);

                            if (a == 0)
                            {
                                Console.WriteLine("Phuong trinh vo nghiem");
                            }
                            else
                            {
                                if (b == 0)
                                {
                                    Console.WriteLine("X = 0");
                                }
                                else
                                {
                                    Console.WriteLine("X = " + (-b / a));
                                }
                            }
                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("Bai 11: Viết trò chơi bao - đá - kéo");
                            char n, m = 'b';
                            int mRD, a = 0, b = 0;

                            while (true)
                            {
                                Console.WriteLine("Nhap ky tu (b-d-k) nhap ky tu khac de thoat: ");
                                n = Convert.ToChar(Console.ReadLine());
                                Random rd = new Random();
                                mRD = rd.Next(1, 3);
                                switch (mRD)
                                {
                                    case 1:
                                        {
                                            m = 'b';
                                        }
                                        break;
                                    case 2:
                                        {
                                            m = 'd';
                                        }
                                        break;
                                    case 3:
                                        {
                                            m = 'k';
                                        }
                                        break;
                                }
                                switch (n)
                                {
                                    case 'b':
                                        {
                                            if (m == 'd')
                                            {
                                                a++;
                                            }

                                            else
                                            {
                                                if (m == 'k')
                                                    b++;
                                            }

                                        }
                                        break;
                                    case 'd':
                                        {
                                            if (m == 'k')
                                            {
                                                a++;
                                            }

                                            else
                                            {
                                                if (m == 'b')
                                                    b++;
                                            }
                                        }
                                        break;
                                    case 'k':
                                        {
                                            if (m == 'b')
                                            {
                                                a++;
                                            }

                                            else
                                            {
                                                if (m == 'd')
                                                    b++;
                                            }
                                        }
                                        break;
                                    default:
                                        return;
                                }
                                Console.WriteLine("Nguoi: " + n);
                                Console.WriteLine("May: " + m);

                                Console.WriteLine("Ty so nguoi - may :{0} - {1} ", a, b);
                            };
                        }
                        break;
                    case 13:
                        {
                            Console.WriteLine("Bai 13: Viết chương trình nhập vào ngày, tháng, năm. Kiểm tra ngày và tháng nhập có hợp lệ hay không. Tính thứ trong tuần của ngày đó");
                            int d, m, y, top, dayofweek;

                            Console.WriteLine("Nhap vao ngay thang nam: ");
                            d = Convert.ToInt32(Console.ReadLine());
                            m = Convert.ToInt32(Console.ReadLine());
                            y = Convert.ToInt32(Console.ReadLine());

                            if (y < 1582)
                            {
                                Console.WriteLine("Nam khong hop le!\n Lich Gregorian bat dau tu nam 1582");
                            }
                            else
                            {
                                if (m < 1 || m > 12)
                                {
                                    Console.WriteLine("Thang khong hop le");
                                }
                                else
                                {
                                    if (((y % 4 == 0 && y % 100 != 0) || y % 400 == 0) && m == 2)
                                    {
                                        top = 29;
                                    }
                                    else
                                    {
                                        if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                                        {
                                            top = 31;
                                        }
                                        else
                                        {
                                            top = 30;
                                        }
                                    }
                                    if (d < 1 && d > top)
                                    {
                                        Console.WriteLine("Ngay khong hop le");
                                    }
                                    else
                                    {
                                        Console.WriteLine("hop le");
                                        y -= (14 - m) / 12;
                                        m += 12 * ((14 - m) / 12) - 2;
                                        dayofweek = (d + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;
                                        if (dayofweek == 0)
                                            Console.WriteLine("Chu Nhat\n");
                                        else
                                            Console.WriteLine("Thu {0}", dayofweek + 1);

                                    }
                                }
                            }
                        }
                        break;
                    case 20:
                        {
                            Console.WriteLine("Bai 20: Viết chương trình nhập số kW điện đã tiêu thụ");
                            double sokW, tongTien;
                            Console.WriteLine("Nhap sp kW dien: ");
                            sokW = Convert.ToDouble(Console.ReadLine());

                            if (sokW < 100)
                            {
                                tongTien = sokW * 500;
                            }
                            else
                            {
                                if (sokW < 250)
                                {
                                    tongTien = 100 * 500 + (sokW - 100) * 800;
                                }
                                else
                                {
                                    if (sokW < 350)
                                    {
                                        tongTien = 100 * 500 + 150 * 800 + (sokW - 250) * 1000;
                                    }
                                    else
                                    {
                                        tongTien = 100 * 500 + 150 * 800 + 100 * 1000 + (sokW - 350) * 1500;
                                    }
                                }
                            }
                            Console.WriteLine("Chi phi: " + tongTien);
                        }
                        break;
                    case 22:
                        {
                            Console.WriteLine("Bai 22: Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n ");
                            int a, sum = 0, k = 0;

                            Console.WriteLine("Nhap vao so nguyen duong: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            while (a < 0)
                            {
                                Console.WriteLine("Nhap vap so nguyen duong!!");
                                a = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.Write("Cac uoc so: ");
                            for (int i = 1; i <= a; i++)
                            {
                                if (a % i == 0)
                                {
                                    Console.Write(" " + i);
                                    k++;
                                    sum += i;
                                }
                            }

                            Console.WriteLine("\nCo {0} uoc so, tong la : {1} ", k, sum);
                        }
                        break;
                    case 23:
                        {
                            Console.WriteLine("Bai 23: Viết chương trình tìm các số hoàn hảo (perfect number) nhỏ hơn một số nguyên dương n cho trước");
                            int n, i, j, sum;

                            Console.WriteLine("Nhap vao so n: ");
                            n = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Cac so hoan hao: ");
                            for (i = 1; i < n; i++)
                            {
                                sum = 0;
                                for (j = 1; sum <= i && j < i; ++j)
                                {
                                    if (i % j == 0)
                                    {
                                        sum += j;
                                    }
                                }
                                if (sum == i)
                                {
                                    Console.Write(" " + i);
                                }
                            }
                        }
                        break;
                    case 31:
                        {
                            Console.WriteLine("Bai 31: Viết chương trình in bảng cửu chương từ 2 đến 9 ra màn hình");
                            Console.WriteLine("Chuong trinh in ra bang cuu chuong");

                            for (int i = 1; i <= 10; i++)
                            {
                                for (int j = 2; j <= 9; j++)
                                {
                                    Console.Write("| {0} x{1} = {2}\t", j, i, i * j);
                                }
                                Console.WriteLine("");
                            }
                        }
                        break;
                    case 36:
                        {
                            Console.WriteLine("Bai 36: Viết chương trình in ra n số nguyên tố đầu tiên (n nhập từ bàn phím)");
                            int n, k = 2, count;

                            Console.WriteLine("Nhap n: ");
                            n = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Cac so nguyen to:");
                            for (int i = 1; i <= n;)
                            {
                                count = 0;
                                for (int j = 2; j <= Math.Sqrt(k); j++)
                                {
                                    if (k % j == 0)
                                    {
                                        count++;

                                    }
                                }

                                if (count == 0)
                                {
                                    Console.Write(" " + k);
                                    i++;
                                }
                                k++;
                            }
                        }
                        break;
                    default:
                        if (chonBT == 0)
                        {
                            Console.WriteLine("Thoat!!!");
                        }
                        else
                        {
                            Console.WriteLine("Khong co bai tap nay!");
                        }
                        break;
                }
            } while (chonBT != 0);

            Console.ReadKey();

        }
    }
}
