public static partial class Textures
{
    public static void PrintSavedMerchant() // Vore fett om man hade en funktion som satte en kort sleep mellan varje char så att texten "skrivs ut" när man kommer in i printmetoden
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(25, 4);
        Console.WriteLine("(===================================================)");
        Console.SetCursorPosition(25, 5);
        Console.WriteLine(" \\                                                 \\\\");
        Console.SetCursorPosition(25, 6);
        Console.WriteLine("  )_________________________________________________)) ");
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(28, 7);
        Console.WriteLine("/                                               /)");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(25, 8);
        Console.WriteLine("  (=================================================) |");
        Console.SetCursorPosition(25, 9);
        Console.WriteLine("  |{¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨}| |");
        Console.SetCursorPosition(25, 10);
        Console.WriteLine("  |{                                               }| |");
        Console.SetCursorPosition(25, 11);
        Console.WriteLine("  |{                                               }| |");
        Console.SetCursorPosition(25, 12);
        Console.WriteLine("  |{                                               }| |");
        Console.SetCursorPosition(25, 13);
        Console.WriteLine("  |{                                               }| |");
        Console.SetCursorPosition(25, 14);
        Console.WriteLine("  |{                                               }| |");
        Console.SetCursorPosition(25, 15);
        Console.WriteLine("  |{_______________________________________________}| )");
        Console.SetCursorPosition(25, 16);
        Console.WriteLine("  (_________________________________________________)/ ");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(33, 10);
        Console.WriteLine("Merchant: Thank you for saving me from ");
        Console.SetCursorPosition(33, 11);
        Console.WriteLine("          these creaps! Is there anything");
        Console.SetCursorPosition(33, 12);
        Console.WriteLine("          I can do for you?	");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(33, 14);
        Console.WriteLine("Player: Y/N?	");
        Console.ResetColor();
    }
}