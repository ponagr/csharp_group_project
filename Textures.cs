
public static class Textures
{
// PLAYER ANIMATIONS
public static void AttackPlayerAnimation()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(0, 2);
        Console.WriteLine("            .     ");
        Console.SetCursorPosition(0, 3);
        Console.WriteLine("     0  ~ /       ");
        Console.SetCursorPosition(0, 4);
        Console.WriteLine(" []/||--T         ");
        Console.SetCursorPosition(0, 5);
        Console.WriteLine("    /\\  	     ");
        Console.SetCursorPosition(0, 6);
        Console.WriteLine("   /  \\          ");
        Console.WriteLine();

        Thread.Sleep(300);

        Console.SetCursorPosition(0, 2);
        Console.WriteLine("                   ");
        Console.SetCursorPosition(0, 3);
        Console.WriteLine("      0            ");
        Console.SetCursorPosition(0, 4);
        Console.WriteLine("    /||--+--*      ");
        Console.SetCursorPosition(0, 5);
        Console.WriteLine("   []/\\  	     ");
        Console.SetCursorPosition(0, 6);
        Console.WriteLine("    /  \\          ");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void PrintPlayerCharacter()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("       .");
        Console.WriteLine("    0  | ");
        Console.WriteLine("[]-||--T");
        Console.WriteLine("   /\\  	");
        Console.WriteLine("  /  \\");
        Console.ResetColor();
        Console.WriteLine();
    }


// ENEMY ANIMATIONS
public static void PrintEnemyCharacter()
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 2);
        Console.WriteLine(".        ");
        Console.SetCursorPosition(40, 3);
        Console.WriteLine("|  0    ");
        Console.SetCursorPosition(40, 4);
        Console.WriteLine("T--||-[E]  ");
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("   /\\  	");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("  |  \\");
        Console.ResetColor();
        Console.WriteLine();
    }

    public static void AttackEnemyAnimation()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(40, 2);
        Console.WriteLine("        ");
        Console.SetCursorPosition(40, 3);
        Console.WriteLine(" \\~  0  ");
        Console.SetCursorPosition(40, 4);
        Console.WriteLine("  T--||\\[]  ");
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("     /\\  ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("    |  \\ ");
        Console.WriteLine();

        Thread.Sleep(300);

        Console.SetCursorPosition(40, 3);
        Console.WriteLine("      0  ");
        Console.SetCursorPosition(40, 4);
        Console.WriteLine("*--+--||\\    ");
        Console.SetCursorPosition(40, 5);
        Console.WriteLine("      /\\[]  ");
        Console.SetCursorPosition(40, 6);
        Console.WriteLine("     |  \\ ");
        Console.WriteLine();
        Console.ResetColor();
    }

    public static void PrintDeadText() // Likadan fast grön eller liknande till vår gubbe?
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(35, 2);
        Console.WriteLine("____  ____   _   ____  ");
        Console.SetCursorPosition(35, 3);
        Console.WriteLine("|| \\\\ ||    /\\\\  || \\\\ ");
        Console.SetCursorPosition(35, 4);
        Console.WriteLine("||  ||||-- //_\\\\ ||  ||");
        Console.SetCursorPosition(35, 5);
        Console.WriteLine("||_// ||__//   \\\\||_// ");

        Console.SetCursorPosition(35, 6);
        Console.WriteLine("                         "); // För att ta bort gammal text
        Console.SetCursorPosition(35, 7);
        Console.WriteLine("                         "); // --"--

        Thread.Sleep(300);
        Console.SetCursorPosition(35, 6);
        Console.WriteLine("        |          | ");

        Thread.Sleep(400);
        Console.SetCursorPosition(35, 6);
        Console.WriteLine("  |     |          | ");

        Thread.Sleep(500);
        Console.SetCursorPosition(35, 6);
        Console.WriteLine("  | |   | |        | ");

        Thread.Sleep(400);
        Console.SetCursorPosition(35, 7);
        Console.WriteLine("        |            ");

        Thread.Sleep(450);
        Console.SetCursorPosition(35, 7);
        Console.WriteLine("  |     |            ");

        Thread.Sleep(550);
        Console.SetCursorPosition(35, 7);
        Console.WriteLine("  |     |      |     ");

        Thread.Sleep(700);
        Console.SetCursorPosition(35, 8);
        Console.WriteLine("        |            ");
        Console.ResetColor();
    }

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
       O  | 		   O   /		O   /*_
      ||--T 		  ||--/	   ||--/	
      /\		        /\	       /\
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