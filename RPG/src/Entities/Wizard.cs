namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
        }
        public override string Attack()
        {
            return Name + " Lançou Magia";
        }
        
        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return Name + " Lançou Magia super efetiva com bonus de " + bonus;
            }
            else
            {
                return Name + " Lançou Magia com força fraca com bonus de " + bonus;
            }
        }
    }
}