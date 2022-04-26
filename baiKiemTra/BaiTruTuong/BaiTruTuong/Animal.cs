using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTruTuong
{
    public abstract class Animal
    {
        public abstract void Eat();
        public abstract void makeSound();
    }

    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Con meo an ca");
        }

        public override void makeSound()
        {
            Console.WriteLine("Con meo keu meo meo");
        }
        public void Run()
        {
            Console.WriteLine("Con meo chay bang bon chan");
        }
    }
}
