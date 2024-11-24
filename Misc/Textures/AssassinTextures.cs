public static partial class Textures
{
    #region Assassin
    // ENEMY ANIMATIONS
    public static void PrintAssassin()
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine(" .        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine(" |  0    ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine(" T--||-[E]  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("    /\\  	");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("   |  \\");
        Console.ResetColor();
        Console.WriteLine();

    }
    public static void PrintInvisibleAssassin()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine(" .        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine(" |  0    ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine(" T--||-[E]  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("    /\\  	");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("   |  \\");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void AssassinAttackAnimation()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("         ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("  \\~  0  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("   T--||\\[]  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("      /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("     |  \\ ");
        Console.WriteLine();

        Thread.Sleep(300);

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("         ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("       0  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine(" *--+--||\\    ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("       /\\[]  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("      |  \\ ");
        Console.WriteLine();
        Console.ResetColor();
    }

    #endregion

    #region Bow
    public static void PrintArcher()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("          O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("     <--{-||  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("          /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("         /  | ");
        Console.WriteLine();
        Console.ResetColor();
    }

    public static void ArcherAttackAnimation()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("          O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("   <--  {-||~  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("          /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("         /  | ");
        Console.WriteLine();

        Thread.Sleep(200);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("          O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("  <--   {-||  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("          /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("         /  | ");
        Console.WriteLine();

        Thread.Sleep(200);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("          O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("<--     {-||  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("          /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("         /  | ");
        Console.WriteLine();
        Console.ResetColor();

        Thread.Sleep(300);

        Console.ForegroundColor = ConsoleColor.Red;     //Skjuta iväg pil till andra sidan?
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("          O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("        {-||  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("          /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("         /  | ");
        Console.WriteLine();
        Console.ResetColor();
        Console.SetCursorPosition(9, 7);
        PrintColor.Red("<--", "WriteLine");

        Thread.Sleep(300);
        Console.SetCursorPosition(9, 7);
        Console.WriteLine("    ");
        Thread.Sleep(200);

    }

    public static void ArcherSpecialAttackAnimation()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("   <--    O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("   <--  {-||~  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("   <--    /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("         /  | ");
        Console.WriteLine();

        Thread.Sleep(200);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("  <--     O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("  <--   {-||  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("  <--     /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("         /  | ");
        Console.WriteLine();

        Thread.Sleep(200);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("<--       O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("<--     {-||  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("<--       /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("         /  | ");
        Console.WriteLine();
        Console.ResetColor();

        Thread.Sleep(300);

        Console.ForegroundColor = ConsoleColor.Red;     //Skjuta iväg pil till andra sidan?
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("          O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("        {-||  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("          /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("         /  | ");
        Console.WriteLine();
        Console.ResetColor();
        Console.SetCursorPosition(9, 6);
        PrintColor.Red("<--", "WriteLine");
        Console.SetCursorPosition(9, 7);
        PrintColor.Red("<--", "WriteLine");
        Console.SetCursorPosition(9, 8);
        PrintColor.Red("<--", "WriteLine");

        Thread.Sleep(300);
        Console.SetCursorPosition(9, 6);
        Console.WriteLine("    ");
        Console.SetCursorPosition(9, 7);
        Console.WriteLine("    ");
        Console.SetCursorPosition(9, 8);
        Console.WriteLine("    ");
        Thread.Sleep(200);

    }
    public static void ArcherBossSpecialAttackAnimation()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("   <--     ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("   <--    O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("   <--  {-||~  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("   <--    /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("   <--   /  | ");
        Console.WriteLine();

        Thread.Sleep(200);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("  <--   ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("  <--     O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("  <--   {-||  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("  <--     /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("  <--    /  | ");
        Console.WriteLine();

        Thread.Sleep(200);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("<--      ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("<--       O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("<--     {-||  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("<--       /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("<--      /  | ");
        Console.WriteLine();
        Console.ResetColor();

        Thread.Sleep(300);

        Console.ForegroundColor = ConsoleColor.Red;     //Skjuta iväg pil till andra sidan?
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("          O  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("        {-||  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("          /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("         /  | ");
        Console.WriteLine();
        Console.ResetColor();
        Console.SetCursorPosition(9, 5);
        PrintColor.Red("<--", "WriteLine");
        Console.SetCursorPosition(9, 6);
        PrintColor.Red("<--", "WriteLine");
        Console.SetCursorPosition(9, 7);
        PrintColor.Red("<--", "WriteLine");
        Console.SetCursorPosition(9, 8);
        PrintColor.Red("<--", "WriteLine");
        Console.SetCursorPosition(9, 9);
        PrintColor.Red("<--", "WriteLine");

        Thread.Sleep(300);
        Console.SetCursorPosition(9, 5);
        Console.WriteLine("    ");
        Console.SetCursorPosition(9, 6);
        Console.WriteLine("    ");
        Console.SetCursorPosition(9, 7);
        Console.WriteLine("    ");
        Console.SetCursorPosition(9, 8);
        Console.WriteLine("    ");
        Console.SetCursorPosition(9, 9);
        Console.WriteLine("    ");
        Thread.Sleep(200);

    }
    #endregion

    #region BOSSES
    public static void PrintBossAssassin()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine(".        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("|  0    ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("T--||-[E]  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("   /\\  	");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("  |  \\");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void BossAssassinStealthAnimation()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine(" \\~  0  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("  T--||\\[]  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("     /\\  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("    |  \\ ");
        Console.WriteLine();

        Thread.Sleep(300);

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("         0  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("      +--||\\    ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("         /\\[]  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("        |  \\ ");
        Console.WriteLine();

        Thread.Sleep(300);

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("            ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("         0  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("        -||\\    ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("       / /\\[]  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("        |  \\ ");
        Console.WriteLine();

        Thread.Sleep(300);

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("             ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("            0  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("          *--||\\  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("            LL.   ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("                  ");
        Console.WriteLine();

        Thread.Sleep(300);

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("             ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("            0  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("       *   --||\\  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("            LL.   ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("                  ");
        Console.WriteLine();

        Thread.Sleep(300);

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("             ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("            0  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("   *   *   --||\\  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("            LL.   ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("                  ");
        Console.WriteLine();

        Thread.Sleep(300);

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("             ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("            0  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("*  *       --||\\  ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("            LL.   ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("                  ");
        Console.WriteLine();


        Console.ResetColor();
    }
    #endregion


}