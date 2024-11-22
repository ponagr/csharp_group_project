public class Enemy : GameObject
{
    public bool isPlayer = false;   // För att kunna använda HealthBar och veta om den ska skrivas ut i rött eller grönt
    public int XpDrop;
    public HealthBar healthBar;
    //Lägg till en AggroRange senare

    public virtual string TakeDamage(double damage, bool crit, out string attackMessage) // Tar emot printDamage från Players Attack(), kallas här för damage
    {
        Random rndDodge = new Random();           // DODGE
        int dodgeChance = Convert.ToInt32(BaseAgility/2);
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
        return $"{damage:F0}";
    }

    public virtual void PrintCharacter(Enemy enemy){}
    
    public virtual void CharacterAttackAnimation(Enemy enemy){}

    public double CalculateDamage(Player player, out bool attackCrit)       
    {   //För att kunna räkna ut damageNegation osv utan att använda base.Attack()
        Random rndCrit = new Random();
        double damageDone;
        int critChange = Convert.ToInt32(BaseAgility/2);
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
        int dodgeChance = Convert.ToInt32(player.TotalAgility/3);
        int dodge = rndDodge.Next(0, 101);
        if (dodge <= dodgeChance) // Om vi har mer baseAgility än den randomizade dodgen
        {
            attackMessage = $"{player.Name} DODGED";
            return $"0";
        }
        else if (attackCrit)
        {
            attackMessage = "CRITICAL";
            player.CurrentHp -= damageDone;
            return $"{damageDone:F0}";
        }
        else
        {
            attackMessage = "";
            player.CurrentHp -= damageDone;
            return $"{damageDone:F0}";
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