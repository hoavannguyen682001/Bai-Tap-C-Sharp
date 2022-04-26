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
        public Cat()
        {

        }
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

    public class Bird : Animal
    {
        public Bird()
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Con chim an qua");
        }

        public override void makeSound()
        {
            Console.WriteLine("Con chim hot");
        }
        public void Fly()
        {
            Console.WriteLine("Con chim bay");
        }
    }
}
