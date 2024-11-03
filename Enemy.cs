public class Enemy : GameObject
{
    public bool isPlayer = false;
    public int XpDrop = 33;
    public HealthBar healthBar;
    //Lägg till en AggroRange senare

    public Enemy(Player player)
    {
        double multiplier = player.Level * 0.5;
        Random random = new Random();
        Name = "Enemy";
        Description = "Enemy";
        BaseHp = 75 + random.Next(0, 25) * multiplier;
        CurrentHp = TotalHp;
        BaseDamage = 10 + random.Next(0, 10) * multiplier;
        BaseResistance = 0 + random.Next(0, 5) * multiplier;
        BaseAgility = 5 * multiplier;

        healthBar = new HealthBar();
    }

    public string Attack(Player player, out string critical)
    {
        Random rndCrit = new Random();
        double damageDone;
        int critChange = Convert.ToInt32(BaseAgility);
        int crit = rndCrit.Next(0, 101);
        double damage;
        bool attackCrit = false;
        if (crit <= critChange)
        {
            damage = TotalDamage * 1.8;
            attackCrit = true;
        }
        else
        {
            damage = TotalDamage;
        }

        Random rndDamage = new Random();
        Random rndDodge = new Random();
        int dodgeChange = Convert.ToInt32(BaseAgility);
        int dodge = rndDodge.Next(0, 101);
        if (dodge <= dodgeChange)
        {
            critical = "";
            return $"{player.Name} DODGED";
        }
        else if (attackCrit)
        {
            critical = "CRITICAL";
            damageDone = damage + rndDamage.Next(0, 10) - player.TotalResistance;
            player.CurrentHp -= damageDone;
            return $"<-- {damageDone:F0} DMG";
        }
        else
        {
            critical = "";
            damageDone = damage + rndDamage.Next(0, 10) - player.TotalResistance;
            player.CurrentHp -= damageDone;
            return $"<-- {damageDone:F0} DMG";
        }
    }


    public void ShowHp()
    {
        Console.SetCursorPosition(40, 0);
        healthBar.PrintHealthBar(PercentHp, isPlayer);
        Console.SetCursorPosition(40, 1);
        PrintColor.Red($"{CurrentHp:F0}/{TotalHp:F0}({PercentHp:F0}%)", "Write");
    }
}