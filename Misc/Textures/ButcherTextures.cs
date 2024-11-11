public static partial class Textures
{
    public static void PrintButcher()
    {
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("   / \\        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("   | |  0  _   ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("    T--||-[B]  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("       /\\    	");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("      |  \\     ");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void ButcherBigHitAnimation()
    {
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("   / \\    / \\     ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("   | |  0 | |     ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("    T--||--T     ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("       /\\    	");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("      |  \\     ");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void ButcherAttackAnimation()
    {
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("    .           ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("   / \\  0  _   ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("   | |--||-[B]  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("    T   /\\    	");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("       |  \\    ");
        Console.ResetColor();
        Console.WriteLine();
    }
#region SHIELD
    public static void PrintButcherShield()
    {
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("               ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("   /x\\   0     ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("  |xxx|--||      ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("   \\x/  /\\    	");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("        | \\     ");
        Console.ResetColor();
        Console.WriteLine();
    }
    #endregion
    #region NEEDS REST
    public static void PrintButcherNeedsRest()
    {
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("               ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("        0  _   ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("<:::+--||-[B]  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("       /\\    	");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("      |  \\     ");
        Console.ResetColor();
        Console.WriteLine();

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("                 ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("      0           ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("      \\\\        ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("<:::+- /\\ [B] 	");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("      /  \\      ");
        Console.ResetColor();
        Console.WriteLine();

        Thread.Sleep(300);

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("                ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("       0        ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("      /||\\       ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("       /\\ [B]  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("<:::+-|  \\     ");
        Console.ResetColor();
        Console.WriteLine();

        Thread.Sleep(300);

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("                  ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("        0         ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("      ///\\         ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("       /\\    	 ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("<:::+-|  \\[B]    ");
        Console.ResetColor();
        Console.WriteLine();

        Thread.Sleep(500);

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("                 ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("      0           ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("      \\\\        ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("       /\\  	     ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("<:::+-|  \\[B]      ");
        Console.ResetColor();
        Console.WriteLine();

        Thread.Sleep(500);

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("                ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("       0        ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("      /||\\       ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("       /\\     ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("<:::+-|  \\[B]   ");
        Console.ResetColor();
        Console.WriteLine();

        Thread.Sleep(500);

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("                  ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("        0         ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("      ///\\         ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("       /\\    	 ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("<:::+-|  \\[B]    ");
        Console.ResetColor();
        Console.WriteLine();

        Thread.Sleep(500);
    }
    #endregion
    #region MEAT CLEAVER

    public static void ButcherBossAttackAnimation()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.SetCursorPosition(38, 4);
        Console.WriteLine(" ______        ");
        Console.SetCursorPosition(38, 5);
        Console.WriteLine("||   o|        ");
        Console.SetCursorPosition(38, 6);
        Console.WriteLine("||    |        ");
        Console.SetCursorPosition(38, 7);
        Console.WriteLine("|     |        ");
        Console.SetCursorPosition(38, 8);
        Console.WriteLine("|___| |        ");
        Console.SetCursorPosition(38, 9);
        Console.WriteLine("    | |        ");
        Console.SetCursorPosition(38, 10);
        Console.WriteLine("    (_)        ");
        Console.ResetColor();
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(38, 4);
        Console.WriteLine(" _");
        Console.SetCursorPosition(38, 5);
        Console.WriteLine("||");
        Console.SetCursorPosition(38, 6);
        Console.WriteLine("||");
        Console.SetCursorPosition(38, 7);
        Console.WriteLine("|");
        Console.SetCursorPosition(38, 8);
        Console.WriteLine("|__");
        Console.ResetColor();

        Thread.Sleep(150);

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.SetCursorPosition(25, 4);
        Console.WriteLine(" ______        ");
        Console.SetCursorPosition(25, 5);
        Console.WriteLine("||   o|  - -      ");
        Console.SetCursorPosition(25, 6);
        Console.WriteLine("||    |      -  ");
        Console.SetCursorPosition(25, 7);
        Console.WriteLine("|     |   -     ");
        Console.SetCursorPosition(25, 8);
        Console.WriteLine("|___| |        ");
        Console.SetCursorPosition(25, 9);
        Console.WriteLine("    | |  -      ");
        Console.SetCursorPosition(25, 10);
        Console.WriteLine("    (_)        ");
        Console.ResetColor();
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(25, 4);
        Console.WriteLine(" _");
        Console.SetCursorPosition(25, 5);
        Console.WriteLine("||");
        Console.SetCursorPosition(25, 6);
        Console.WriteLine("||");
        Console.SetCursorPosition(25, 7);
        Console.WriteLine("|");
        Console.SetCursorPosition(25, 8);
        Console.WriteLine("|__");
        Console.ResetColor();

        Thread.Sleep(150);

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.SetCursorPosition(11, 4);
        Console.WriteLine(" ______        ");
        Console.SetCursorPosition(11, 5);
        Console.WriteLine("||   o|    --    ");
        Console.SetCursorPosition(11, 6);
        Console.WriteLine("||    |      -  ");
        Console.SetCursorPosition(11, 7);
        Console.WriteLine("|     |   --   -  ");
        Console.SetCursorPosition(11, 8);
        Console.WriteLine("|___| |        ");
        Console.SetCursorPosition(11, 9);
        Console.WriteLine("    | |        ");
        Console.SetCursorPosition(11, 10);
        Console.WriteLine("    (_)        ");
        Console.ResetColor();
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(11, 4);
        Console.WriteLine(" _");
        Console.SetCursorPosition(11, 5);
        Console.WriteLine("||");
        Console.SetCursorPosition(11, 6);
        Console.WriteLine("||");
        Console.SetCursorPosition(11, 7);
        Console.WriteLine("|");
        Console.SetCursorPosition(11, 8);
        Console.WriteLine("|__");
        Console.ResetColor();

        Thread.Sleep(500);
    }
    #endregion
}