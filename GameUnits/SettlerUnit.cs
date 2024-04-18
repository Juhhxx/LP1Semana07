using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Cost { get; } = 5;
        public SettlerUnit(int mov=1, int health=3) : base(mov, health)
        {
            
        }
    }
}