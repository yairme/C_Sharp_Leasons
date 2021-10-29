using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    abstract class Pickups : PlayerStats
    {
        public abstract void OnPickup();
    }
}
