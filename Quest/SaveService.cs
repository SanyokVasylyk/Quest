using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace TextQuest
{
    static class SaveService
    {
        const string SavePath = "save.txt";
        static readonly object fileLock = new();

        public static List<Player> LoadAll()
        {
            lock (fileLock)
            {
                if (!File.Exists(SavePath))
                    return new List<Player>();

                try
                {
                    string json = File.ReadAllText(SavePath);
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var players = JsonSerializer.Deserialize<List<Player>>(json, options);
                    return players ?? new List<Player>();
                }
                catch
                {
                    return new List<Player>();
                }
            }
        }

        public static void SaveAll(List<Player> players)
        {
            lock (fileLock)
            {
                try
                {
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string json = JsonSerializer.Serialize(players, options);
                    File.WriteAllText(SavePath, json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не вдалося зберегти: {ex.Message}");
                }
            }
        }

        public static Player? FindByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            var players = LoadAll();
            return players.FirstOrDefault(p => string.Equals(p.Name, name.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public static void SaveOrUpdate(Player player)
        {
            if (player == null) return;

            var players = LoadAll();
            var existing = players.FirstOrDefault(p => string.Equals(p.Name, player.Name, StringComparison.OrdinalIgnoreCase));
            if (existing != null)
            {
                int idx = players.IndexOf(existing);
                players[idx] = player;
            }
            else
            {
                players.Add(player);
            }

            SaveAll(players);
            Console.WriteLine("Гру збережено.");
        }
    }
}