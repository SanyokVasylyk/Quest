namespace TextQuest
{
    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }

        public Enemy(string name, int health, int strength)
        {
            Name = name;
            Health = health;
            Strength = strength;
        }

    }
}