using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesApp
{
    internal class Point : AbstractPoint, IMovable
    {
        public override string ToString() => $"Point: X={X}";

    }
}
