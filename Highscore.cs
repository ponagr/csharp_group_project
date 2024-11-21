public static class Highscore
{
    public static List<Score> Highscores { get; set; }


    public static void AddScore(Player player)
    {
        Highscores.Add(new Score(player));
    }

    public static void ShowHighscore()
    {
        Highscores = Highscores.OrderByDescending(x => x.TotalScore).ToList();
        for (int i = 0; i < 10; i++)
        {
            PrintColor.Yellow($"{i + 1}. {Highscores[i].TotalScore} points", "WriteLine");
        }   
    }
}

public class Score      //Lägga till en Score egenskap i Player?
{
    public int TotalScore { get; set; }
    public string PlayerName { get; set; }

    public Score(Player player)
    {
        PlayerName = player.Name;
        TotalScore = CountScore(player);
    }

    public void PrintScore()
    {
        PrintColor.Yellow($"{TotalScore} points", "WriteLine");
        Console.ReadKey();
    }

    public int CountScore(Player player)
    {
        double score = 0;

        score += player.Level * 100;
        score += player.TotalHp * 5;
        score += player.TotalDamage * 10;
        score += player.TotalAgility * 10;
        score += player.TotalResistance * 10;
        score += player.MapLevel * 100;
        score += player.Gold * 10;
        score += player.HealingPot.Ammount * 5;
        score += player.ChestsLooted * 20;
        score += player.EnemiesKilled * 10;
        score += player.BossesKilled * 100;
        score += player.CurrentXp * 10;
        score += player.CurrentHp * 5;
        score += player.Inventory.inventory.Count * 10;
        score -= player.HeartsPickedUp * 10;
        score -= player.TrapsTriggered * 10;
        foreach (Item item in player.EquippedGear)
        {
            if (item != null)
            {
                score += item.Price;
            }
        }
        
        return (int)score;
    }
}