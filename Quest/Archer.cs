namespace TextQuest
{
    class Archer : Player
    {
        public Archer(string name) : base(name)
        {
            Class = PlayerClass.Archer;
            Health = 200;      
            Strength = 50;
            CriticalChance = 20;
            Money = 0;
            Armor = 0;

        }
    }
}