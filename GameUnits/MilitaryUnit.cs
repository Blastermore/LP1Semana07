namespace GameUnits
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int mov,int health,int attackPower):base(mov,health)
        {                                                      // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }
        public override int Health
        {
            GameUnits => base.Health + XP;

            set
            {
                base.Health = value;
            }
        }
        public override float Cost
        {
            get => AttackPower + XP;
        }
        public void Attack(uint u)
        {
            XP++;
            u.Health = u.Health - AttackPower; 
        }

    }
}
