using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTruTuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Cat: ");
            Cat cat_217 = new Cat();
            cat_217.Eat();
            cat_217.makeSound();
            cat_217.Run();
            Console.WriteLine("\n");
            Console.WriteLine("Class Bird: ");
            
            Bird bird_217 = new Bird();
            bird_217.Eat();
            bird_217.makeSound();
            bird_217.Fly();

            Console.ReadKey();
        }
    }
}
