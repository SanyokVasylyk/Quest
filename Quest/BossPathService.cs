using System;

namespace TextQuest
{
    static class BossPathService
    {
        public static void BossPath(Game game)
        {
            Enemy boss1 = new Enemy("Бос 1 рівня", 200, 40, 15);
            Console.WriteLine($"\nОсь перший бос {boss1.Name} Здоров'я {boss1.Health} Сила {boss1.MaxStrength}");
            Console.WriteLine("1 - Розпочати бій");
            Console.WriteLine("2 - Відступити");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nБій розпочато");
                var result = BossFightService.StartFight(game.player, boss1);

                switch (result)
                {
                    case FightResult.Win:
                        Console.WriteLine("\nТи переміг боса! Селяни допомогли тобі і ти продовжуєш свою пригоду!");
                        // return to main choice/menu
                        FirstChoiceService.FirstChoice(game);
                        return;
                    case FightResult.Escape:
                        Console.WriteLine("\nТобі вдалося втекти від бою. Ти повертаєшся назад.");
                        FirstChoiceService.FirstChoice(game);
                        return;
                    case FightResult.Lose:
                        Console.WriteLine("\nТи програв бій... Гра закінчена.");
                        return;
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nТи вирішив не битися і відходиш від боса.");
                FirstChoiceService.FirstChoice(game);
            }
            else
            {
                Console.WriteLine("Невірний вибір!");
                BossPath(game);
            }
        }
    }
}