
public static partial class Textures
{
    #region Player
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
    #region Assassin
    // ENEMY ANIMATIONS
    public static void PrintAssassin()
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
    public static void PrintInvisibleAssassin()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
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

    public static void AssassinAttackAnimation()
    {
        Console.ForegroundColor = ConsoleColor.Red;
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
        Console.WriteLine("      0  ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("*--+--||\\    ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("      /\\[]  ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("     |  \\ ");
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
    #endregion
    #region DEAD

    public static void PrintGrave()
    {

        for (int i = 0; i < 5; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(40, 4);
            Console.WriteLine("  _____                        ");
            Console.SetCursorPosition(40, 5);
            Console.WriteLine(" /  .  \\                      ");
            Console.SetCursorPosition(40, 6);
            Console.WriteLine("(  =|=  )                      ");
            Console.SetCursorPosition(40, 7);
            Console.WriteLine(" |  |  |                       ");
            Console.SetCursorPosition(40, 8);
            Console.WriteLine(" |_____|                       ");
            Console.SetCursorPosition(40, 9);
            Console.WriteLine("/_______\\                     ");

            Thread.Sleep(300);

            Console.SetCursorPosition(40, 9);
            Console.WriteLine("/__RIP__\\                     ");

            Thread.Sleep(300);
        }
        Thread.Sleep(1000);
    }


    public static void PrintDeadText() // Likadan fast grön eller liknande till vår gubbe?
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("____  ____   _   ____  ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("|| \\\\ ||    /\\\\  || \\\\ ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("||  ||||-- //_\\\\ ||  ||");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("||_// ||__//   \\\\||_// ");

        Console.SetCursorPosition(40, 9);
        Console.WriteLine("                         "); // För att ta bort gammal text
        Console.SetCursorPosition(40, 10);
        Console.WriteLine("                         "); // --"--

        Thread.Sleep(100);
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("        |          | ");

        Thread.Sleep(200);
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("  |     |          | ");

        Thread.Sleep(250);
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("  | |   | |        | ");

        Thread.Sleep(200);
        Console.SetCursorPosition(40, 10);
        Console.WriteLine("        |            ");

        Thread.Sleep(250);
        Console.SetCursorPosition(40, 10);
        Console.WriteLine("  |     |            ");

        Thread.Sleep(300);
        Console.SetCursorPosition(40, 10);
        Console.WriteLine("  |     |      |     ");

        Thread.Sleep(300);
        Console.SetCursorPosition(40, 11);
        Console.WriteLine("        |            ");
        Console.ResetColor();
    }
    #endregion
    #region BUTCHER

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


    #region MAGE

    public static void PrintMage()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("                       ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("           ;  00       ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("           |=-[]-='    ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("              /\\      ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("             d  b      ");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void MageAttackAnimation()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("         ;    00       ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("           |=-[]-='    ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("              /\\      ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("             d  b      ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("                       ");
        Console.WriteLine();

        Thread.Sleep(200); ;

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("        ;     00       ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("          \\=-[]-='    ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("              /\\      ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("             d  b      ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("                       ");
        Console.WriteLine();

        Thread.Sleep(200); ;

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("     ;  \\    00       ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("          \\=-[]-='    ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("             /\\      ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("            d  b      ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("                       ");
        Console.WriteLine();

        Thread.Sleep(200); ;

        Console.SetCursorPosition(40, 5);
        Console.WriteLine("  ;     \\    00       ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("          \\=-[]-='    ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("             /\\      ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("            d  b      ");
        Console.SetCursorPosition(40, 9);
        Console.WriteLine("                       ");
        Console.WriteLine();

        Thread.Sleep(200); ;

        Console.SetCursorPosition(40, 5);
        Console.WriteLine(";       \\    00       ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("          \\=-[]-='    ");
        Console.SetCursorPosition(40, 7);
        Console.WriteLine("             /\\      ");
        Console.SetCursorPosition(40, 8);
        Console.WriteLine("            d  b      ");
        Console.SetCursorPosition(40, 9);
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

    #region LOADING
    public static void PrintLoading()
    {
        string[] loadingBar = new string[10] { "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  " };

        int percentLoaded = 0;


        for (int i = 0; i < loadingBar.Length; i++) // Loopa 10 gånger
        {
            loadingBar[i] = " |";
            percentLoaded += 10;
            Console.SetCursorPosition(18, 3);
            Console.Write($"Loading...  {percentLoaded}/100%");

            Console.SetCursorPosition(17, 4);
            Console.Write("[");

            for (int j = 0; j < loadingBar.Length; j++)
            {
                if (loadingBar[j] == " |")
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Write(loadingBar[j]);      //Om det är en player, skriv ut i grönt
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(loadingBar[j]); // Skrivs ut tomma för samma längd
                }

            }

            Console.Write("]");

            Thread.Sleep(500);
        }

        Console.WriteLine();
    }
    #endregion
}





























/*

POTION, HJÄLM, RUSTNING, VAPEN, XP

      _____
     /=====\
    ||     ||
    ||     ||  HJÄLM
     \\_ _// 
      /   \


       ____    POTION
       |  |		
       |  |		
      /----\
     / . ,  \
    (________)	


              ___  ____
             /   \/    \  DRESS
            /_/\     /\_\
               /_____\
              /_______\
             /_________\
            /___________\


        /\  10 RADER
       /  \
       |  |
       |  |
       |  |
       |  |
       <  >
   {}==|  |=={}
        []
        []
        ==


    /\
   {  } 
    ||
    ||  
    ||    Magestaff?
    ||
    ||
    || 
   {  }
    \/ 
     


    _       _
   / \     / \
  /   \___/   \
 (     ___     )  AXE
  \   /| |\   /
   \_/ | | \_/
       | |  
       | |
       |_|
       (_)
       (_)
       (_)

          _       _
   / \     / \
  /   \___/   \
 (     ___     )  AXE
  \   /| |\   /
   \_/ | | \_/
       | |  
       | |
       |_|
       (_)
       (_)
       (_)



   2222     22222222
 22    22   22
22     22   22         2   2  2222
     22     22222222    2 2   2   2
   22              22    2    2222
22          22     22   2 2   2  
222222222    222222    2   2  2

()  ____  ()
 \\/    \//
  | >  < |
 (  xxxx  )
  \______/
   //  \\
  ()    ()
   
    xxxx
 xxxxxxxxxx
xx xxxxxx xx RUSTNING ::S:S:S
xx xxxxxx xx
   xxxxxx
   xxxxxx
   ------

        /\
       / /
      / /
     / / 
    / /
  ~/ /~
  /_/


        /\
       / /
      / /
     / / 
  _ / /_
 (_/ /_)
  /_/
  o
  
  _____       _____
 [xxxxx]     /=====\
[xxOxOxx]   ||     ||
[xxxxxxx]   ||     ||  HJÄLM
 \xxxxx/     \\_ _// 
              /   \

//        
 //       O 		    O 		  O	
 //      ||{}->        ||{}--> 	 ||{} --> 
 //      /\	           /\	     /\		ASSASSIN
 //     /  \	      /  \		/  \
 //
       O  | 		 O   /		O   /*_
      ||--T 		||--/	   ||--/	
      /\		    /\	       /\
     /  \	       /  |	      /  |


	  .		      
       0  | 		 
  [.]-||--T 		
      /\  		
     /  \	       

  \ o	
   ||\
   /\  
  | /

    	
  _ o
   ||_
  | \
  '  '

   \o/
   //
  | \
  '  '
 ____  ____   _   ____
 || \\ ||    /\\  || \\
 ||  ||||-- //_\\ ||  ||
 ||_// ||__//   \\||_//

 ____  ____   _   ____
 || \\ ||    /\\  || \\
 ||  ||||-- //_\\ ||  ||
 ||_// ||__// | \\||_//
   | |   | |      | | 
   |       |      |   
           |

    \  /
     \/
   DE/\D		
    /  \	

       .
      / \	 
      | |
      | |
      [ ]
       I
       o	
  
         
       . 
      / \  	 
      | | 
      | |
      [ ]
       o
       I
		

 //	          ,			
 //       0  |     \   Ö  
 //      ||--T      \--|| MAGE
 //      /\            /\
 //     L  \          /  \
 //
//    |   O   
 //   |--||-0 WARRIOR
 //      /\
 //     /  \
 //
 //   ;  00   
 //   |=-[]-=' ROBOT
 //      /\
 //     d  b


 //       O   
 //      ||-}-->
 //      /\
 //     |  \

  //      O   
 //      ||-}  -->
 //      /\
 //     |  \

   //     O   
 //      ||-}   -->
 //      /\
 //     /  \

 
   //     O   
 //      ||-}     -->
 //      /\
 //     /  \


    ____
    |  |		
    |  |		
   /----\
  / . ,  \
 (________)		
  

   _--~_
  (_____)
  |  $  |
   \___/
    

*/
// TOM MAP-ARRAY
// public static Map Level3(Player player)
// {
//     char[,] gameLevel = new char[,]
//     {  //  1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23      // DISARMA MINOR?!
//         { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' },
//         { '=', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|' },
//         { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '@', '|' },
//         { '|', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '|' },//23
//     };