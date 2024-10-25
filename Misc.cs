public static class CursorPosition
{
    //Metod för att Cleara bara en rad istället för hela consolen.
    public static void ClearLine(int line)
    {
        int currentLine = Console.CursorTop;         // Spara aktuell radposition
        Console.SetCursorPosition(0, line);          // Flytta till den rad som ska rensas
        Console.Write(new string(' ', Console.WindowWidth)); // Skriv tomma mellanslag över hela raden
        Console.SetCursorPosition(0, currentLine);   // Flytta tillbaka markören till ursprunglig position
    }

}