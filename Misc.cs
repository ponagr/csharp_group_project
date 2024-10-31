public static class Clear   //Använder SetCursorPosition för att "Cleara" specifika ställen i consolen
{
    //Metod för att Cleara bara en rad istället för hela consolen.
    public static void Row(int line)
    {
        int currentLine = Console.CursorTop;         // Spara aktuell radposition
        Console.SetCursorPosition(0, line);          // Flytta till den rad som ska rensas
        Console.Write(new string(' ', Console.WindowWidth)); // Skriv tomma mellanslag över hela raden
        Console.SetCursorPosition(0, currentLine);   // Flytta tillbaka markören till ursprunglig position
    }

    public static void PlayerDamage()   //Rensar raden där playerDamage skrivs ut
    {
        Console.SetCursorPosition(25, 3);   // Flytta till den rad som ska rensas
        Console.Write(new string(' ', 14)); // Skriv tomma mellanslag där damage skrivs ut
        Console.SetCursorPosition(7, 12);   // Flytta tillbaka markören till positionen där "Input: " skrivs ut
    }
    public static void EnemyDamage()    //Rensar raden där enemyDamage skrivs ut
    {
        Console.SetCursorPosition(25, 4);   // Flytta till den rad som ska rensas
        Console.Write(new string(' ', 14)); // Skriv tomma mellanslag där damage skrivs ut
        Console.SetCursorPosition(7, 12);   // Flytta tillbaka markören till positionen där "Input: " skrivs ut
    }

    public static void PlayerHp()   //Rensar raden där playerHp skrivs ut
    {
        Console.SetCursorPosition(0, 0);    // Flytta till den rad som ska rensas
        Console.Write(new string(' ', 14)); // Skriv tomma mellanslag där playerHp skrivs ut
        Console.SetCursorPosition(0, 1);
        Console.Write(new string(' ', 14));
        Console.SetCursorPosition(7, 12);   // Flytta tillbaka markören till positionen där "Input: " skrivs ut
    }

    public static void EnemyHp()    //Rensar raden där enemyHp skrivs ut
    {
        Console.SetCursorPosition(30, 0);   // Flytta till den rad som ska rensas
        Console.Write(new string(' ', 14)); // Skriv tomma mellanslag där enemyHp skrivs ut
        Console.SetCursorPosition(30, 1);
        Console.Write(new string(' ', 14));
        Console.SetCursorPosition(7, 12);   // Flytta tillbaka markören till positionen där "Input: " skrivs ut
    }
}