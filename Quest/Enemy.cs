namespace TextQuest
{
    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxStrength { get; set; }
        public int MinStrength { get; set; }

        public Enemy(string name, int health, int maxstrength, int minstrength)
        {
            Name = name;
            Health = health;
            MaxStrength = maxstrength;
            MinStrength = minstrength;
        }

    }
}