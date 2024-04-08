using System;
using System.Collections.Generic;
using System.Linq;

public class TennisPlayer
{
    public string Name { get; set; }
    public int Game1 { get; set; }
    public int Game2 { get; set; }
    public int Game3 { get; set; }

    public int TotalScore
    {
        get
        {
            return Game1 + Game2 + Game3;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<TennisPlayer> players = new List<TennisPlayer>
        {
            new TennisPlayer { Name = "Гравець1", Game1 = 10, Game2 = 20, Game3 = 30 },
            new TennisPlayer { Name = "Гравець2", Game1 = 15, Game2 = 25, Game3 = 35 },
            new TennisPlayer { Name = "Гравець3", Game1 = 20, Game2 = 30, Game3 = 40 },
            new TennisPlayer { Name = "Гравець4", Game1 = 25, Game2 = 35, Game3 = 45 },
            new TennisPlayer { Name = "Гравець5", Game1 = 30, Game2 = 40, Game3 = 50 }
        };

        var topPlayers = players.OrderByDescending(p => p.TotalScore).Take(3);

        Console.WriteLine("Топ 3 гравця:");
        foreach (var player in topPlayers)
        {
            Console.WriteLine($"Name: {player.Name}, Загальний бал: {player.TotalScore}");
        }
    }
}