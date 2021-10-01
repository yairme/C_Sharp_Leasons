using System;
using System.Collections.Generic;
using System.Text;

namespace Enemy_Scrip
{
    class Basic_AI : BP
    {
        public void Give_and_Take()
        {
            for (int i = 0; i < 10; i++)
            {
                HP += 10;
            }
        }
    }

    class TakingDamage : Basic_AI
    {
        public void DamageTaken()
        {
            if (DM)
            {
                if (DM == true)
                    HP -= 10;
            }
        }
    }

    class TickDamage : TakingDamage
    {
        public void DamageOverTime()
        {
            for (int j = 0; j < 3; j++)
            {
                DamageTaken();
            }
            DM = false;
        }
    }
}
