using System;

namespace GameUnits
{
    public class SpyUnit : XPUnit
    {
        public override float Cost { get; } = 12.5f;
        public SpyUnit(int mov=8,int health=2) : base(mov,health)
        {
        }
        
    }
}