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

    public virtual string TakeDamage(double damage, bool crit, out string attackMessage) // Tar emot printDamage från Players Attack(), kallas här för damage
    {
        Random rndDodge = new Random();           // DODGE
        int dodgeChance = Convert.ToInt32(BaseAgility);
        int dodge = rndDodge.Next(0, 101);
        
        if (dodge <= dodgeChance)
        {
            attackMessage = "DODGED";
            damage = 0;
            CurrentHp -= damage;
            return "";          
        }
        else if (crit)
        {
            attackMessage = "CRITICAL";
        }
        else // VANLIG ATTACK
        {
            attackMessage = "";
        }
        CurrentHp -= damage;
        return $"DMG {damage:F0} -->";
    }

    public virtual string Attack(Player player, out string attackMessage)
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
        double damageNegation = player.TotalResistance * 0.2;
        if (dodge <= dodgeChange)
        {
            attackMessage = "";
            return $"{player.Name} DODGED";
        }
        else if (attackCrit)
        {
            attackMessage = "attackMessage";
            damageDone = damage + rndDamage.Next(0, 10) - damageNegation;
            player.CurrentHp -= damageDone;
            return $"<-- {damageDone:F0} DMG";
        }
        else
        {
            attackMessage = "";
            damageDone = damage + rndDamage.Next(0, 10) - damageNegation;
            player.CurrentHp -= damageDone;
            return $"<-- {damageDone:F0} DMG";
        }
    }


    public void ShowHp()
    {
        Console.SetCursorPosition(40, 2);
        healthBar.PrintHealthBar(PercentHp, isPlayer);
        Console.SetCursorPosition(40, 3);
        PrintColor.Red($"{CurrentHp:F0}/{TotalHp:F0}({PercentHp:F0}%)", "Write");
    }
}