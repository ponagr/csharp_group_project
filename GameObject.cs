public class GameObject
{
    public string Name { get; set; }
    public string Description { get; set; } //Assassin eller Mage osv
    public double BaseHp { get; set; }
    public double TotalHp 
    {   
        get { return BaseHp; }
    }
    private double currentHp;
    public double CurrentHp //if CurrentHp < 0, CurrentHp = 0;
    { 
        get { return currentHp; }
        set
        {
            if (value < 0)      //Kontrollera så att currentHp inte kan bli mindre än 0 vid attack
            {
                currentHp = 0;
            }  
            else
            {
                currentHp = value;
            }
        } 
    }   
    public double PercentHp
    {
        get { return CurrentHp / TotalHp * 100; }
    }
    public double BaseDamage {get; set;}
    public double TotalDamage  // SENARE: lägg till + damage från items OM player har items
    {
        get { return BaseDamage; }
    } 
    public double BaseResistance {get; set;} // Beroende på armor, fiendeklass osv
    public double TotalResistance 
    {   
        get { return BaseResistance; }
    }
    public double BaseAgility {get; set;} // Smidighet, crit-chance, dodge osv
    public double TotalAgility
    {   
        get { return BaseAgility; }
    }


}