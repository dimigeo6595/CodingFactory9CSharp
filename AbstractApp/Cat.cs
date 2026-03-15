using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractApp
{
    internal class Cat : AbstractAnimal
    {
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine($"{Name} is finally eating.");
        }

        public override string ToString() => $"Cat: Id={Id}, Name={Name}, Age={Age}";

    }
}
