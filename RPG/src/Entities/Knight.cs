namespace RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
        }

        public override string Attack()
        {
            return Name + " Atacou com a sua espada";
        }
        
        public string Attack(int bonus)
        {
            return Name + " Atacou com bonus de ataque de " + bonus;
        }
    }
}