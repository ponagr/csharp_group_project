public static partial class Textures
{
    #region MAGE

    public static void PrintMage()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(35, 5);
        Console.WriteLine("                       ");
        Console.SetCursorPosition(35, 6);
        Console.WriteLine("           ;  00       ");
        Console.SetCursorPosition(35, 7);
        Console.WriteLine("           |=-[]-='    ");
        Console.SetCursorPosition(35, 8);
        Console.WriteLine("              /\\      ");
        Console.SetCursorPosition(35, 9);
        Console.WriteLine("             d  b      ");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void MageAttackAnimation()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(33, 5);
        Console.WriteLine("         ;    00       ");
        Console.SetCursorPosition(33, 6);
        Console.WriteLine("           |=-[]-='    ");
        Console.SetCursorPosition(33, 7);
        Console.WriteLine("              /\\      ");
        Console.SetCursorPosition(33, 8);
        Console.WriteLine("             d  b      ");
        Console.SetCursorPosition(33, 9);
        Console.WriteLine("                       ");
        Console.WriteLine();

        Thread.Sleep(200); ;

        Console.SetCursorPosition(33, 5);
        Console.WriteLine("        ;     00       ");
        Console.SetCursorPosition(33, 6);
        Console.WriteLine("          \\=-[]-='    ");
        Console.SetCursorPosition(33, 7);
        Console.WriteLine("              /\\      ");
        Console.SetCursorPosition(33, 8);
        Console.WriteLine("             d  b      ");
        Console.SetCursorPosition(33, 9);
        Console.WriteLine("                       ");
        Console.WriteLine();

        Thread.Sleep(200); ;

        Console.SetCursorPosition(33, 5);
        Console.WriteLine("     ;  \\    00       ");
        Console.SetCursorPosition(33, 6);
        Console.WriteLine("          \\=-[]-='    ");
        Console.SetCursorPosition(33, 7);
        Console.WriteLine("             /\\      ");
        Console.SetCursorPosition(33, 8);
        Console.WriteLine("            d  b      ");
        Console.SetCursorPosition(33, 9);
        Console.WriteLine("                       ");
        Console.WriteLine();

        Thread.Sleep(200); ;

        Console.SetCursorPosition(33, 5);
        Console.WriteLine("  ;     \\    00       ");
        Console.SetCursorPosition(33, 6);
        Console.WriteLine("          \\=-[]-='    ");
        Console.SetCursorPosition(33, 7);
        Console.WriteLine("             /\\      ");
        Console.SetCursorPosition(33, 8);
        Console.WriteLine("            d  b      ");
        Console.SetCursorPosition(33, 9);
        Console.WriteLine("                       ");
        Console.WriteLine();

        Thread.Sleep(200); ;

        Console.SetCursorPosition(33, 5);
        Console.WriteLine(";       \\    00       ");
        Console.SetCursorPosition(33, 6);
        Console.WriteLine("          \\=-[]-='    ");
        Console.SetCursorPosition(33, 7);
        Console.WriteLine("             /\\      ");
        Console.SetCursorPosition(33, 8);
        Console.WriteLine("            d  b      ");
        Console.SetCursorPosition(33, 9);
        Console.WriteLine("                       ");
        Console.WriteLine();

        Thread.Sleep(200);
        Console.ResetColor();
    }

    public static void MageThunderStrike()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(35, 4);
        Console.WriteLine("<  ");
        Console.SetCursorPosition(35, 5);
        Console.WriteLine(" > ");

        Thread.Sleep(100);

        Console.SetCursorPosition(25, 4);
        Console.WriteLine("<  ");
        Console.SetCursorPosition(25, 5);
        Console.WriteLine(" > ");

        Thread.Sleep(150);

        Console.SetCursorPosition(14, 4);
        Console.WriteLine("<  ");
        Console.SetCursorPosition(14, 5);
        Console.WriteLine(" > ");

        Thread.Sleep(200);

        Console.SetCursorPosition(5, 4);
        Console.WriteLine("<  ");
        Console.SetCursorPosition(5, 5);
        Console.WriteLine(" > ");
        Console.ResetColor();

        Thread.Sleep(400);
    }

    #endregion
}