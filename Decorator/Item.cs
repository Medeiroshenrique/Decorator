using System;

namespace Decorator
{
    public abstract class Item
    {
        public int QuantasCopias { get; set; }

        public abstract void Mostrar();
    }
}
