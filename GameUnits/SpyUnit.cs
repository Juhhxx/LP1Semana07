using System;

namespace GameUnits
{
    public class SpyUnit : XPUnit
    {
        public override float Cost { get; } = 12.5f;
        public SpyUnit(int mov=8,int health=2) : base(mov,health)
        {
        }
        public void GetSecretInfo(Unit unit)
        {
            int increment;

            if (unit is SpyUnit)
            {
                increment = 3;
            }
            else if (unit is MilitaryUnit)
            {
                increment = 2;
            }
            else
            {
                increment = 1;
            }

            XP += increment;
        }
    }
}