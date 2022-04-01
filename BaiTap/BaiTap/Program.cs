using System;

namespace BaiTap
{
    class Program
    {

        static void output(int[] age, string[] name)
        {
            for (int i = 0; i < 3; i++)
            {
                if (18 <= age[i] && age[i] < 60)
                {
                    Console.WriteLine("Ten: " + name[i]);
                    Console.WriteLine("Nguoi Lon");

                }
                else
                {
                    if (age[i] >= 60)
                    {
                        Console.WriteLine("Ten: " + name[i]);
                        Console.WriteLine("Nguoi Gia");
                    }
                    else
                    {
                        Console.WriteLine("Ten: " + name[i]);
                        Console.WriteLine("Em Be");
                    }
                }
            }

            
        }

        static void Main(string[] args)
        {
            person p = new person();

            for(int i = 0; i < 3; i++)
            {
                
            }
            output(p.age, p.name);
        }

            
    }
}
