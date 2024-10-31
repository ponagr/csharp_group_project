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

public static class PrintColor
{
    public static void Red(string stringToPrint, string Write)
    {
        if (Write == "WriteLine")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(stringToPrint);
            Console.ResetColor();
        }

        else if (Write == "Write")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(stringToPrint);
            Console.ResetColor();
        }
    }
    public static void Green(string stringToPrint, string Write)
    {
        if (Write == "WriteLine")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(stringToPrint);
            Console.ResetColor();
        }

        else if (Write == "Write")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(stringToPrint);
            Console.ResetColor();
        }
    }
    public static void Yellow(string stringToPrint, string Write)
    {
             if (Write == "WriteLine")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(stringToPrint);
            Console.ResetColor();
        }

        else if (Write == "Write")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(stringToPrint);
            Console.ResetColor();
        }
    }
    public static void Blue(string stringToPrint, string Write)
    {
             if (Write == "WriteLine")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(stringToPrint);
            Console.ResetColor();
        }

        else if (Write == "Write")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(stringToPrint);
            Console.ResetColor();
        }
    }
    public static void Gray(string stringToPrint, string Write)
    {
             if (Write == "WriteLine")
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(stringToPrint);
            Console.ResetColor();
        }

        else if (Write == "Write")
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(stringToPrint);
            Console.ResetColor();
        }
    }
    public static void DarkYellow(string stringToPrint, string Write)
    {
             if (Write == "WriteLine")
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(stringToPrint);
            Console.ResetColor();
        }

        else if (Write == "Write")
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(stringToPrint);
            Console.ResetColor();
        }
    }
    public static void BackgroundRed(string stringToPrint)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(stringToPrint);
        Console.ResetColor();
    }
    public static void BackgroundGreen(string stringToPrint)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine(stringToPrint);
        Console.ResetColor();
    }

}

public static class Misc
{
    public static string FirstToUpper(string input)
    {
        input = char.ToUpper(input[0]) + input.Substring(1).ToLower();
        return input;
    }
}