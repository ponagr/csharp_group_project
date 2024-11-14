public static partial class Textures
{
    public static void PrintSavedMerchant() // Vore fett om man hade en funktion som satte en kort sleep mellan varje char så att texten "skrivs ut" när man kommer in i printmetoden
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(15, 4);
        Console.WriteLine("(===================================================)");
        Console.SetCursorPosition(15, 5);
        Console.WriteLine(" \\                                                 \\\\");
        Console.SetCursorPosition(15, 6);
        Console.WriteLine("  )_________________________________________________)) ");
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(18, 7);
        Console.WriteLine("/                                               /)");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(15, 8);
        Console.WriteLine("  (=================================================) |");
        Console.SetCursorPosition(15, 9);
        Console.WriteLine("  |{¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨}| |");
        Console.SetCursorPosition(15, 10);
        Console.WriteLine("  |{                                               }| |");
        Console.SetCursorPosition(15, 11);
        Console.WriteLine("  |{                                               }| |");
        Console.SetCursorPosition(15, 12);
        Console.WriteLine("  |{                                               }| |");
        Console.SetCursorPosition(15, 13);
        Console.WriteLine("  |{                                               }| |");
        Console.SetCursorPosition(15, 14);
        Console.WriteLine("  |{                                               }| |");
        Console.SetCursorPosition(15, 15);
        Console.WriteLine("  |{_______________________________________________}| )");
        Console.SetCursorPosition(15, 16);
        Console.WriteLine("  (_________________________________________________)/ ");

        Console.CursorVisible = false;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(23, 10);
        Write.OneLetterAtATime("Merchant: Thank you for saving me from \n");
        Console.SetCursorPosition(23, 11);
        Write.OneLetterAtATime("          these creaps! Is there anything\n");
        Console.SetCursorPosition(23, 12);
        Write.OneLetterAtATime("          I can do for you?	\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(23, 14);
        Console.WriteLine("Player: Y/N?	");
        Console.ResetColor();
    }
}