using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesApp
{
    internal class MovingSpace
    {
        public IMovable? Movable { get; set; }

        public MovingSpace(IMovable movable)
        {
            Movable = movable;
        }

        public void Move5()
        {
            Movable!.Move5();
        }
    }
}
