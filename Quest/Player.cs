namespace TextQuest
{
    class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Critical { get; set; }
        public int CriticalChance { get; set; }
        public PlayerClass Class { get; set; }
        public int Armor { get; set; }
        public int Money { get; set; }



        public Player(string name)
        {
            Name = name;
        }
    }
}