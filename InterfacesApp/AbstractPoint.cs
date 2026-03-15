using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesApp
{
    internal abstract class AbstractPoint : IMovable
    {
        public int X { get; set; }

        public void Move5()
        {
            X += 5;
        }

        // It is not mandatory to override the default implementation of Move10() method since it has execution in the interface.
        public void Move10()
        {
            X += 10;
        }
    }
}
