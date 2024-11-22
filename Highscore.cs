using System.Text.Json;
public static class Highscore
{
    public static List<Score> Highscores { get; set; } // Innehåller bara en lista av scores (namn och score)

    public static void SaveHighscore()
    {
        string json = JsonSerializer.Serialize(Highscores);
        File.WriteAllText("highscore.json", json);
    }
    public static void LoadHighScore()
    {
        if (File.Exists("highscore.json"))
        {
            string json = File.ReadAllText("highscore.json");
            List<Score> loadedHighscores = new List<Score>();
            loadedHighscores = JsonSerializer.Deserialize<List<Score>>(json);
            if (loadedHighscores != null)
            {
                Highscores = loadedHighscores;
            }
            else // Skapar om filen är tom
            {
                Highscores = new List<Score>();
            }
        }
        else // Skapar om ingen fil finns
        {
            Highscores = new List<Score>();
        }
    }
    public static void AddScore(Player player)
    {
        Score score = new Score(player);
        Highscores = Highscores.OrderByDescending(x => x.TotalScore).ToList();
        
        if (score.TotalScore > Highscores[0].TotalScore) 
        {   
            Console.SetCursorPosition(49, 16);
            PrintColor.Green("NEW HIGHSCORE: ", "Write");
            score.PrintScore();
        }
        else
        {
            Console.SetCursorPosition(49, 16);
            PrintColor.Green("SCORE: ", "Write");
            score.PrintScore();
        }
        Highscores.Add(score);
        SaveHighscore();
    }

    public static void ShowHighscore()
    {
        Highscores = Highscores.OrderByDescending(x => x.TotalScore).ToList();
        int linePosition = 46;
        int startLine = 20;
        int nrOfScores = 0;
        Console.SetCursorPosition(48, 18);
        Console.WriteLine("******HIGHSCORES******");
        Console.SetCursorPosition(48, 19);
        Console.WriteLine("======================");
        for (int i = 0; i < Highscores.Count; i++)
        {
            if (nrOfScores < 5)
            {
                Console.SetCursorPosition(linePosition, startLine);
                Console.WriteLine($"{i + 1}. {Highscores[i].PlayerName} - {Highscores[i].TotalScore} points");
                startLine++;
            }  
            else    
            {
                break;
            }
            nrOfScores++;
        }
    }
}

public class Score 
{
    public int TotalScore { get; set; }
    public string PlayerName { get; set; }

    public Score() { }
    public Score(Player player)
    {
        PlayerName = player.Name;
        TotalScore = CountScore(player);
    }

    public void PrintScore()
    {
        PrintColor.Yellow($"{TotalScore} points", "WriteLine");
    }

    public int CountScore(Player player)
    {
        double score = 0;

        score += player.Level * 100;
        score += player.TotalHp * 10;
        score += player.TotalDamage * 20;
        score += player.TotalAgility * 20;
        score += player.TotalResistance * 50;
        score += player.MapLevel * 100;
        score += player.Gold * 100;
        score += player.HealingPot.Ammount * 10;
        score += player.ChestsLooted * 20;
        score += player.EnemiesKilled * 10;
        score += player.BossesKilled * 100;
        score += player.CurrentXp * 10;
        score += player.CurrentHp * 10;
        score += player.Inventory.inventory.Count * 50;
        score -= player.HeartsPickedUp * 50;
        score -= player.TrapsTriggered * 100;
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