namespace TextQuest
{
    class Swordsman : Player
    {
        public Swordsman (string name) : base(name)
        {
            Class = PlayerClass.Swordsman;
            Health = 120;     
            Strength = 10;
            CriticalChance = 20;
            Money = 0;
            Armor = 5;
        }
    }
}