using System;

namespace TextQuest
{
    static class BossFightService
    {
        public static FightResult StartFight(Player player, Enemy enemy)
        {

            Random random = new Random();

            Console.WriteLine($"\nБій розпочато! Твій ворог: {enemy.Name}");

            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine($"\n{player.Name} (Здоров'я: {player.Health}) vs {enemy.Name} (Здоров'я: {enemy.Health})");
                Console.WriteLine("1 - Атакувати");
                Console.WriteLine("2 - спробувати втекти");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Random attack = new Random();
                    if (attack.Next(0, 101) < player.CriticalChance)
                    {
                        enemy.Health -= player.Strength + 5;
                        Console.WriteLine($"{player.Name} завдає {player.Strength + 5} критичної шкоди ворогу!");
                    }
                    else
                    {
                        enemy.Health -= player.Strength;
                        Console.WriteLine($"{player.Name} завдає {player.Strength} шкоди ворогу!");
                    }


                    if (enemy.Health <= 0)
                    {
                        Console.WriteLine($"Ти переміг боса {enemy.Name}!");
                        Console.WriteLine("За це ти отримав 400 монет, та можеш покращити свої навички");
                        player.Money += 400;
                        Console.WriteLine("1 - Покращити здоров'я на 50");
                        Console.WriteLine("2 - Покращити силу на 25");
                        Console.WriteLine("3 - Покращити шанс на критичний удар на 5");
                        string fightchoice = Console.ReadLine();
                        switch (fightchoice)
                        {
                            case "1":
                                player.Health += 50;
                                Console.WriteLine("Ти покращив здоров'я на 50 одиниць");
                                return FightResult.Win;
                            case "2":
                                player.Strength += 25;
                                Console.WriteLine("Ти покращив силу на 25 одиниць");
                                return FightResult.Win;
                            case "3":
                                player.CriticalChance += 5;
                                Console.WriteLine("Ти покращив шанс на критичний удар на 5 одиницю");
                                return FightResult.Win;
                        }

                    }
                    int strength1 = random.Next(1, enemy.Strength);
                    int strength = strength1 - player.Armor;
                    player.Health -= strength;
                    Console.WriteLine($"{enemy.Name} завдає {strength} шкоди тобі!");

                    if (player.Health <= 0)
                    {
                        Console.WriteLine("Ти програв бій...");
                        return FightResult.Lose;
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Ти пробуєш втекти.");
                    Random rand = new Random();
                    if (rand.Next(0, 101) < 20)
                    {
                        Console.WriteLine("Тобі вдалося втекти!");
                        return FightResult.Escape;
                    }
                    else
                    {
                        int strength1 = random.Next(1, enemy.Strength);
                        int strength = strength1 - player.Armor;
                        Console.WriteLine("Втеча не вдалася! Ворог атакує тебе.");
                        player.Health -= strength;
                        Console.WriteLine($"{enemy.Name} завдає {strength} шкоди тобі!");
                        if (player.Health <= 0)
                        {
                            Console.WriteLine("Ти програв бій...");
                            return FightResult.Lose;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Невірний вибір! Спробуй ще раз.");
                }
            }
            if (player.Health <= 0)
            {
                return FightResult.Lose;
            }
            else if (enemy.Health <= 0)
            {
                return FightResult.Win;
            }
            else
            {
                return FightResult.Escape;
            }
        }
    }
}