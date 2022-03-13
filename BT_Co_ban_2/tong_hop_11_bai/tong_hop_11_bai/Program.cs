using System;

namespace tong_hop_11_bai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int chonBT_217;
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

            do
            {
                Console.WriteLine("\nChon bai tap so (Nhap 0 de thoat): ");
                chonBT_217 = Convert.ToInt32(Console.ReadLine());
                switch (chonBT_217)
                {
                    case 1:
                        {
                            Console.WriteLine("Bai 1: Nhập vào diện tích S của một mặt cầu. Tính thể tích V của hình cầu này");
                            double S_217, r_217, V_217;
                            const double pi_217 = 3.141593;
                            Console.Write("Nhap vao dien tich S cua mat cau: ");
                            S_217 = Convert.ToDouble(Console.ReadLine());
                            r_217 = Math.Sqrt(S_217 / (4 * pi_217));
                            V_217 = (4 * pi_217 * Math.Pow(r_217, 3)) / 3;
                            Console.Write("The tich V : " + V_217 );
                        }

                        break;
                    case 2:
                        {
                            Console.WriteLine("Bai 2: Nhập vào tọa độ 2 điểm A(xA, yA) và B(xB, yB). Tính khoảng cách AB.");
                            double xA_217, yA_217, xB_217, yB_217, AB_217;
                            Console.Write("A(xA, yA)? ");
                            xA_217 = Convert.ToDouble(Console.ReadLine());
                            yA_217 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("B(xB, yB)? ");
                            xB_217 = Convert.ToDouble(Console.ReadLine());
                            yB_217 = Convert.ToDouble(Console.ReadLine());

                            AB_217 = Math.Abs(Math.Sqrt(Math.Pow(xB_217 - xA_217, 2) + Math.Pow(yB_217 - yA_217, 2)));

                            Console.WriteLine("|AB| = " + Math.Round(AB_217, 4));
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Bai 6: Viết chương trình nhập vào ba số nguyên. Hãy in ba số này ra màn hình theo thứ tự tăng dần và chỉ dùng tối đa một biến phụ.");
                            int a_217, b_217, c_217, temp_217;
                            Console.WriteLine("Nhap a, b, c: ");
                            a_217 = Convert.ToInt32(Console.ReadLine());
                            b_217 = Convert.ToInt32(Console.ReadLine());
                            c_217 = Convert.ToInt32(Console.ReadLine());

                            if (a_217 > b_217)
                            {
                                temp_217 = b_217;
                                b_217 = a_217;
                                a_217 = temp_217;
                            }
                            if (a_217 > c_217)
                            {
                                temp_217 = a_217;
                                a_217 = c_217;
                                c_217 = temp_217;
                            }
                            if (b_217 > c_217)
                            {
                                temp_217 = c_217;
                                c_217 = b_217;
                                b_217 = temp_217;
                            }


                            Console.WriteLine("tang dan {0}{1}{2}", a_217, b_217, c_217);
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Bai 7: Viết chương trình giải phương trình bậc 1: ax + b = 0 (a, b nhập từ bàn phím) Xét tất cả các trường hợp có thể.");
                            double a_217, b_217;

                            Console.WriteLine("Nhap a, b: ");

                            a_217 = Convert.ToDouble(Console.ReadLine());
                            b_217 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Phuong trinh cua ban: {0}x + {1} = 0", a_217, b_217);

                            if (a_217 == 0)
                            {
                                Console.WriteLine("Phuong trinh vo nghiem");
                            }
                            else
                            {
                                if (b_217 == 0)
                                {
                                    Console.WriteLine("X = 0");
                                }
                                else
                                {
                                    Console.WriteLine("X = " + (-b_217 / a_217));
                                }
                            }
                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("Bai 11: Viết trò chơi bao - đá - kéo");
                            char n_217, m_217 = 'b';
                            int mRD_217, a_217 = 0, b_217 = 0;

                            while (true)
                            {
                                Console.WriteLine("Nhap ky tu (b-d-k) nhap ky tu khac de thoat: ");
                                n_217 = Convert.ToChar(Console.ReadLine());
                                Random rd = new Random();
                                mRD_217 = rd.Next(1, 3);
                                switch (mRD_217)
                                {
                                    case 1:
                                        {
                                            m_217 = 'b';
                                        }
                                        break;
                                    case 2:
                                        {
                                            m_217 = 'd';
                                        }
                                        break;
                                    case 3:
                                        {
                                            m_217 = 'k';
                                        }
                                        break;
                                }
                                switch (n_217)
                                {
                                    case 'b':
                                        {
                                            if (m_217 == 'd')
                                            {
                                                a_217++;
                                            }

                                            else
                                            {
                                                if (m_217 == 'k')
                                                    b_217++;
                                            }

                                        }
                                        break;
                                    case 'd':
                                        {
                                            if (m_217 == 'k')
                                            {
                                                a_217++;
                                            }

                                            else
                                            {
                                                if (m_217 == 'b')
                                                    b_217++;
                                            }
                                        }
                                        break;
                                    case 'k':
                                        {
                                            if (m_217 == 'b')
                                            {
                                                a_217++;
                                            }

                                            else
                                            {
                                                if (m_217 == 'd')
                                                    b_217++;
                                            }
                                        }
                                        break;
                                    default:
                                        return;
                                }
                                Console.WriteLine("n_217guoi: " + n_217);
                                Console.WriteLine("May: " + m_217);

                                Console.WriteLine("Ty so nguoi - may :{0} - {1} ", a_217, b_217);
                            };
                        }
                        break;
                    case 13:
                        {
                            Console.WriteLine("Bai 13: Viết chương trình nhập vào ngày, tháng, năm. Kiểm tra ngày và tháng nhập có hợp lệ hay không. Tính thứ trong tuần của ngày đó");
                            int d_217, m_217, y_217, top_217, dayofweek_217;

                            Console.WriteLine("Nhap vao ngay thang nam: ");
                            d_217 = Convert.ToInt32(Console.ReadLine());
                            m_217 = Convert.ToInt32(Console.ReadLine());
                            y_217 = Convert.ToInt32(Console.ReadLine());

                            if (y_217 < 1582)
                            {
                                Console.WriteLine("Nam khong hop le!\n Lich Gregorian bat dau tu nam 1582");
                            }
                            else
                            {
                                if (m_217 < 1 || m_217 > 12)
                                {
                                    Console.WriteLine("Thang khong hop le");
                                }
                                else
                                {
                                    if (((y_217 % 4 == 0 && y_217 % 100 != 0) || y_217 % 400 == 0) && m_217 == 2)
                                    {
                                        top_217 = 29;
                                    }
                                    else
                                    {
                                        if (m_217 == 1 || m_217 == 3 || m_217 == 5 || m_217 == 7 || m_217 == 8 || m_217 == 10 || m_217 == 12)
                                        {
                                            top_217 = 31;
                                        }
                                        else
                                        {
                                            top_217 = 30;
                                        }
                                    }
                                    if (d_217 < 1 && d_217 > top_217)
                                    {
                                        Console.WriteLine("Ngay khong hop le");
                                    }
                                    else
                                    {
                                        Console.WriteLine("hop le");
                                        y_217 -= (14 - m_217) / 12;
                                        m_217 += 12 * ((14 - m_217) / 12) - 2;
                                        dayofweek_217 = (d_217 + y_217 + y_217 / 4 - y_217 / 100 + y_217 / 400 + (31 * m_217) / 12) % 7;
                                        if (dayofweek_217 == 0)
                                            Console.WriteLine("Chu Nhat\n");
                                        else
                                            Console.WriteLine("Thu {0}", dayofweek_217 + 1);

                                    }
                                }
                            }
                        }
                        break;
                    case 20:
                        {
                            Console.WriteLine("Bai 20: Viết chương trình nhập số kW điện đã tiêu thụ");
                            double sokW_217, tongTien_217;
                            Console.WriteLine("Nhap sp kW dien: ");
                            sokW_217 = Convert.ToDouble(Console.ReadLine());

                            if (sokW_217 < 100)
                            {
                                tongTien_217 = sokW_217 * 500;
                            }
                            else
                            {
                                if (sokW_217 < 250)
                                {
                                    tongTien_217 = 100 * 500 + (sokW_217 - 100) * 800;
                                }
                                else
                                {
                                    if (sokW_217 < 350)
                                    {
                                        tongTien_217 = 100 * 500 + 150 * 800 + (sokW_217 - 250) * 1000;
                                    }
                                    else
                                    {
                                        tongTien_217 = 100 * 500 + 150 * 800 + 100 * 1000 + (sokW_217 - 350) * 1500;
                                    }
                                }
                            }
                            Console.WriteLine("Chi phi: " + tongTien_217);
                        }
                        break;
                    case 22:
                        {
                            Console.WriteLine("Bai 22: Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n ");
                            int a_217, sum_217 = 0, k_217 = 0;

                            Console.WriteLine("Nhap vao so nguyen duong: ");
                            a_217 = Convert.ToInt32(Console.ReadLine());
                            while (a_217 < 0)
                            {
                                Console.WriteLine("Nhap vap so nguyen duong!!");
                                a_217 = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.Write("Cac uoc so: ");
                            for (int i = 1; i <= a_217; i++)
                            {
                                if (a_217 % i == 0)
                                {
                                    Console.Write(" " + i);
                                    k_217++;
                                    sum_217 += i;
                                }
                            }

                            Console.WriteLine("\nCo {0} uoc so, tong la : {1} ", k_217, sum_217);
                        }
                        break;
                    case 23:
                        {
                            Console.WriteLine("Bai 23: Viết chương trình tìm các số hoàn hảo (perfect number) nhỏ hơn một số nguyên dương n cho trước");
                            int n_217, i_217, j_217, sum_217;

                            Console.WriteLine("Nhap vao so n: ");
                            n_217 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Cac so hoan hao: ");
                            for (i_217 = 1; i_217 < n_217; i_217++)
                            {
                                sum_217 = 0;
                                for (j_217 = 1; sum_217 <= i_217 && j_217 < i_217; ++j_217)
                                {
                                    if (i_217 % j_217 == 0)
                                    {
                                        sum_217 += j_217;
                                    }
                                }
                                if (sum_217 == i_217)
                                {
                                    Console.Write(" " + i_217);
                                }
                            }
                        }
                        break;
                    case 31:
                        {
                            Console.WriteLine("Bai 31: Viết chương trình in bảng cửu chương từ 2 đến 9 ra màn hình");
                            Console.WriteLine("Chuong trinh in ra bang cuu chuong");

                            for (int i_217 = 1; i_217 <= 10; i_217++)
                            {
                                for (int j_217 = 2; j_217 <= 9; j_217++)
                                {
                                    Console.Write("| {0} x{1} = {2}\t", j_217, i_217, i_217 * j_217);
                                }
                                Console.WriteLine("");
                            }
                        }
                        break;
                    case 36:
                        {
                            Console.WriteLine("Bai 36: Viết chương trình in ra n số nguyên tố đầu tiên (n nhập từ bàn phím)");
                            int n_217, k_217 = 2, count_217;

                            Console.WriteLine("Nhap n: ");
                            n_217 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Cac so nguyen to:");
                            for (int i = 1; i <= n_217;)
                            {
                                count_217 = 0;
                                for (int j = 2; j <= Math.Sqrt(k_217); j++)
                                {
                                    if (k_217 % j == 0)
                                    {
                                        count_217++;

                                    }
                                }

                                if (count_217 == 0)
                                {
                                    Console.Write(" " + k_217);
                                    i++;
                                }
                                k_217++;
                            }
                        }
                        break;
                    default:
                        if (chonBT_217 == 0)
                        {
                            Console.WriteLine("Thoat!!!");
                        }
                        else
                        {
                            Console.WriteLine("Khong co bai tap nay!");
                        }
                        break;
                }
            } while (chonBT_217 != 0);

            Console.ReadKey();

        }
    }
}
