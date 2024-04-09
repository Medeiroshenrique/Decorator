using System;

namespace Decorator
{
    public class Decorator : Item
    {
        //Esta classe eh o decorator abstrato
        protected Item _item;

        public Decorator(Item item) {
            _item = item;
        }
        public override void Mostrar()
        {
            _item.Mostrar();
        }
    }
}
