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
            Console.WriteLine("Вітаю у грі! ");
            Console.WriteLine("1 - Нова гра");
            Console.WriteLine("2 - Завантажити гру");

           
            string saveName = string.Empty;

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    
                    break;

                case "2":
                    Console.Write("Введіть ім’я вашого героя: ");
                    saveName = Console.ReadLine()?.Trim() ?? string.Empty;

                    if (!string.IsNullOrEmpty(saveName))
                    {
                        var found = SaveService.FindByName(saveName);
                        if (found != null)
                        {
                            Console.Write($"Збереження \"{found.Name}\" знайдено. Завантажити його? (y/n): ");
                            string loadChoice = Console.ReadLine()?.Trim().ToLower() ?? "y";
                            if (loadChoice == "y")
                            {
                                player = found;
                                Console.WriteLine($"\nПривіт, {player.Name}! Клас: {player.Class}, Здоров'я: {player.Health}, Сила: {player.Strength}. Твоя пригода продовжується...\n");
                                FirstChoiceService.FirstChoice(this);
                                return;
                            }
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Невірний вибір! Почнемо спочатку.\n");
                    Start();
                    return;
            }

            
            Console.Write("Введіть ім’я свого героя: ");
            string name = Console.ReadLine();

            var playerClass = PlayerClassSelector.ChooseClass();

            if (playerClass == PlayerClass.Archer)
                player = new Archer(name);
            else if (playerClass == PlayerClass.Swordsman)
                player = new Swordsman(name);

            Console.WriteLine($"\nПривіт, {player.Name} ти {player.Class}, твоє здоров'я {player.Health}, твоя сила {player.Strength}! Твоя пригода починається...\n");

            
            if (!string.IsNullOrEmpty(saveName))
            {
                player.Name = saveName;
                SaveService.SaveOrUpdate(player);
                Console.WriteLine($"Створено збереження \"{saveName}\".");
            }

            FirstChoiceService.FirstChoice(this);
        }

        public void Save() => SaveService.SaveOrUpdate(player);
    }
}
