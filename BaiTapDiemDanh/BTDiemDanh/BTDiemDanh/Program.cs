using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDiemDanh
{
    class Program
    {
        public static void input(out int[] arr_217)
        {
            arr_217 = new int[10];
            Console.WriteLine("Nhap gia tri mang: ");
            for (int i = 0; i < 10; i++) { 
                arr_217[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public static void output(int[] arr_217)
        {
            Console.WriteLine("Mang vua nhap: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr_217[i] + " ");
            }
            Console.WriteLine("");
        }

        public static void Max_Min(int[] arr_217)
        {
            int max_217 = arr_217[0];

            for(int i = 0; i < 10; i++)
            {
                if (arr_217[i] > max_217)
                {
                    max_217 = arr_217[i];
                }
            }
            Console.WriteLine("So lon nhat: " + max_217);

            int min_217 = arr_217[0];
            for(int i = 0; i < 10; i++)
            {
                if(arr_217[i] < min_217)
                {
                    min_217 = arr_217[i];
                }
            }
            Console.WriteLine("So nho nhat: " + min_217);

        }

        public static void sortArr(int[] arr_217)
        {
            int tmp_217;
            int[] arr2_217 = arr_217;
            int[] arr3_217 = arr_217;
            //tang dan
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    if (arr2_217[i] > arr2_217[j])
                    {
                        
                        tmp_217 = arr2_217[i];
                        arr2_217[i] = arr2_217[j];
                        arr2_217[j] = tmp_217;
                    }
                }
            }
            Console.WriteLine("Mang sau khi sap xep tang dan:");
            output(arr_217);
            //giam dan

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    if (arr2_217[i] < arr2_217[j])
                    {
                        
                        tmp_217 = arr2_217[i];
                        arr2_217[i] = arr2_217[j];
                        arr2_217[j] = tmp_217;
                    }
                }
            }
            Console.WriteLine("mang sau khi sap xep giam dan:");
            output(arr_217);
        }
        static void Main(string[] args)
        {
            int[] arr_217;

            input(out arr_217);
            output(arr_217);

            Max_Min(arr_217);

            sortArr(arr_217);

            Console.ReadKey();
        }
    }
}
