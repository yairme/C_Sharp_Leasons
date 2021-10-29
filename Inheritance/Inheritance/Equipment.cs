using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    abstract class Equipment : Pickups
    {
        public override void OnPickup()
        {

        }
        public abstract void OnEquip();
        public abstract void UnEquip();
    }

}
