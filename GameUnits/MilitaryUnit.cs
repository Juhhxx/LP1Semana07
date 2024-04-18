namespace GameUnits
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }
        public override int Health 
        {
            get => Health;

            set 
            {
                base.Health += XP;
            }
        }
        public override float Cost
        {
            get => AttackPower + XP;
        }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }
        public void Attack(Unit u)
        {
            u.Health -= AttackPower;
            XP++;
        }
    }
}