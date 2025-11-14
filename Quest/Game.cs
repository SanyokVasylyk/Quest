using System;

namespace TextQuest
{
    public enum PlayerClass
    {
        Archer,
        Swordsman
    }

    class Game
    {
        public Player player;

        public void Start()
        {
            Console.WriteLine("Вітаю у квесті! ");
            Console.Write("Введіть ім’я свого героя: ");
            string name = Console.ReadLine();

            var playerClass = PlayerClassSelector.ChooseClass();

            if (playerClass == PlayerClass.Archer)
                player = new Archer(name);
            else if (playerClass == PlayerClass.Swordsman)
                player = new Swordsman(name);

            Console.WriteLine($"\nПривіт, {player.Name} ти {player.Class}, твоє здоров'я {player.Health}, твоя сила {player.Strength}! Твоя пригода починається...\n");

            FirstChoiceService.FirstChoice(this);

        }
    }
}