public class GameObject
{
    public string Name { get; set; }
    public string Description { get; set; } //Assassin eller Mage osv
    public double BaseHp { get; set; }
    public double TotalHp { get; set; }
    public double CurrentHp { get; set; }
    public double PercentHp
    {
        get { return CurrentHp / TotalHp * 100; }
    }
    public double BaseDamage {get; set;}
    public double TotalDamage {get; set;} // base + items + levels
    public double BaseResistance {get; set;} // Beroende på armor, fiendeklass osv
    public double TotalResistance {get; set;} // Base + t.ex. rustning/hjälm
    public double BaseAgility {get; set;} // Smidighet, crit-chance, dodge osv
    public double TotalAgility {get; set;}  

    public void ShowHp()
    {
        Console.WriteLine($"HP: {CurrentHp}/{TotalHp}({PercentHp}%)");
    }

}