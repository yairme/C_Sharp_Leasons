using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class PlayerStats
    {
        protected int _health = 100;
        protected int _money = 0;
        protected string _weapon { get; set; }
        protected string _armor { get; set; }
    }
}
