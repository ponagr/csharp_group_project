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
            //Texture.DodgeAnimaton();
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

    public virtual void PrintCharacter(Enemy enemy){}
    
    public virtual void CharacterAttackAnimation(Enemy enemy){}

    public double CalculateDamage(Player player, out bool attackCrit)       //Separat metod för att räkna ut skada?
    {                                                                       //För att kunna räkna ut damageNegation osv utan att använda base.Attack()
        Random rndCrit = new Random();
        double damageDone;
        int critChange = Convert.ToInt32(BaseAgility);
        int crit = rndCrit.Next(0, 101);
        double damage;
        attackCrit = false;
        if (crit <= critChange)
        {
            damage = TotalDamage * 1.8;
            attackCrit = true;
        }
        else
        {
            damage = TotalDamage;
        }
        double damageNegation = player.TotalResistance * 0.2;
        Random rndDamage = new Random();
        damageDone = damage + rndDamage.Next(0, 10) - damageNegation;
        return damageDone;
    }

    public virtual string Attack(Player player, out string attackMessage)
    {
        double damageDone = CalculateDamage(player, out bool attackCrit);

        Random rndDodge = new Random();
        int dodgeChange = Convert.ToInt32(BaseAgility);
        int dodge = rndDodge.Next(0, 101);
        if (dodge <= dodgeChange)
        {
            attackMessage = "";
            return $"{player.Name} DODGED";
        }
        else if (attackCrit)
        {
            //Textures.CriticalHit();
            attackMessage = "CRITICAL";
            player.CurrentHp -= damageDone;
            return $"<-- {damageDone:F0} DMG";
        }
        else
        {
            attackMessage = "";
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