using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDiemDanh
{
    class Program
    {
        public static void input(out int[] arr)
        {
            arr = new int[10];
            Console.WriteLine("Nhap gia tri mang: ");
            for (int i = 0; i < 10; i++) { 
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public static void output(int[] arr)
        {
            Console.WriteLine("Mang vua nhap: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
        }

        public static void Max_Min(int[] arr)
        {
            int max = arr[0];

            for(int i = 0; i < 10; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("So lon nhat: " + max);

            int min = arr[0];
            for(int i = 0; i < 10; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("So nho nhat: " + min);

        }

        public static void sortArr(int[] arr)
        {
            int tmp;
            int[] arr2 = arr;
            int[] arr2 = arr;
            //tang dan
            for(int i = 0; i < 9; i++)
            {
                if(arr[i] > arr[i + 1])
                {
                    tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                }
            }
            Console.WriteLine("Mang sau khi sap xep tang dan:");
            output(arr);
            //giam dan

            for (int i = 0; i < 9; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                }
            }
            Console.WriteLine("Mang sau khi sap xep giam dan:");
            output(arr);
        }
        static void Main(string[] args)
        {
            int[] arr;

            input(out arr);
            output(arr);

            Max_Min(arr);

            sortArr(arr);

            Console.ReadKey();
        }
    }
}
