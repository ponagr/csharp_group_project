public static class Highscore
{
    public static List<Score> Highscores { get; set; }

    // public Highscore()
    // {
    //     Highscores = new List<Score>();
    // }

    public static void AddScore(Player player)
    {
        Highscores.Add(new Score(player));
    }

    public static void ShowHighscore()
    {
        Highscores = Highscores.OrderByDescending(x => x.TotalScore).ToList();
        int i = 1;
        foreach (Score score in Highscores)
        {
            PrintColor.Yellow($"{i}. {score.TotalScore} points", "WriteLine");
            i++;
        }
    }
}

public class Score
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