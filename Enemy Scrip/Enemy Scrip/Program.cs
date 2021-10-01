using System;

namespace Enemy_Scrip
{
    class BP
    {
        public int HP;
        protected bool DM = true;

        public static void Main(string[] arg)
        {
            TickDamage TD = new TickDamage();
            TD.Give_and_Take();
            TD.DamageOverTime();

            Console.WriteLine(TD.HP);
        }
    }
}
