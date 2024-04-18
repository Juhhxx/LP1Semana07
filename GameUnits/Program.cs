using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit setUn = new SettlerUnit();
            Unit milUn = new MilitaryUnit(2,3,4);
            Unit[] units = new Unit[2] {setUn, milUn};

            foreach (Unit u in units)
            {
                u.Move();
                Console.WriteLine(u.Health);
                Console.WriteLine(u.Cost);
                Console.WriteLine(u.ToString());
            }
            
        }
    }
}
