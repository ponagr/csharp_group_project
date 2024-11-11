#region Player
public static partial class Textures
{
    public static void AttackPlayerAnimation()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(0, 5);
        Console.WriteLine("           .     ");
        Console.SetCursorPosition(0, 6);
        Console.WriteLine("     0  ~ /       ");
        Console.SetCursorPosition(0, 7);
        Console.WriteLine(" []/||--T         ");
        Console.SetCursorPosition(0, 8);
        Console.WriteLine("    /\\  	     ");
        Console.SetCursorPosition(0, 9);
        Console.WriteLine("   /  \\          ");
        Console.WriteLine();

        Thread.Sleep(300);

        Console.SetCursorPosition(0, 5);
        Console.WriteLine("                   ");
        Console.SetCursorPosition(0, 6);
        Console.WriteLine("      0            ");
        Console.SetCursorPosition(0, 7);
        Console.WriteLine("    /||--+--*      ");
        Console.SetCursorPosition(0, 8);
        Console.WriteLine("   []/\\  	     ");
        Console.SetCursorPosition(0, 9);
        Console.WriteLine("    /  \\          ");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void PrintPlayerCharacter(int startLine, int linePosition)
    {
        List<string> textForRow = new List<string>();
        textForRow.Add("       .");
        textForRow.Add("    0  | ");
        textForRow.Add("[]-||--T");
        textForRow.Add("   /\\  	");
        textForRow.Add("  /  \\");
        Console.ForegroundColor = ConsoleColor.Green;
        Write.MultipleLines(textForRow, startLine, linePosition);
        Console.ResetColor();
        Console.WriteLine();
    }
    #endregion
}