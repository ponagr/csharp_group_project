
public static class Textures
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
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(40, 5);
            Console.WriteLine("                 ");
            Console.SetCursorPosition(40, 6);
            Console.WriteLine("      0           ");
            Console.SetCursorPosition(40, 7);
            Console.WriteLine("      \\\\        ");
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("       /\\ [B] 	");
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
            Console.WriteLine("       ||       ");
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("       /\\ [B]  ");
            Console.SetCursorPosition(40, 9);
            Console.WriteLine("      |  \\     ");
            Console.ResetColor();
            Console.WriteLine();

            Thread.Sleep(300);

            Console.SetCursorPosition(40, 5);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(40, 6);
            Console.WriteLine("        0         ");
            Console.SetCursorPosition(40, 7);
            Console.WriteLine("       //         ");
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("       /\\ [B] 	 ");
            Console.SetCursorPosition(40, 9);
            Console.WriteLine("      |  \\       ");
            Console.ResetColor();
            Console.WriteLine();

            Thread.Sleep(300);
        }

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