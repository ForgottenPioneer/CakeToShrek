using System;
using System.Text;
using System.Threading;

class ClearConsole
{
    static void Main(string[] args)
    {
        DrawInitialCake();
        while (true)
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);
            Console.Clear();
            DrawCake();
        }
    }

    static void DrawInitialCake()
    {
        Console.Clear();
        string initialCake = "";
        for (int i = 0; i < 13; i++)
        {
            initialCake += GetInitialCakeLine(i);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(initialCake);
            Thread.Sleep(50); 
        }
    }

    static void DrawCake()
    {
        string unicodeString = "";
        for (int i = 0; i < 27; i++)
        {
            unicodeString += GetCakeLine(i);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(unicodeString);
            Thread.Sleep(50);
        }

        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine(unicodeString);
    }

    static string GetInitialCakeLine(int lineNumber)
    {
        switch (lineNumber)
        {
            case 0: return "                0   0\r\n";
            case 1: return "                |   |\r\n";
            case 2: return "            ____|___|____\r\n";
            case 3: return "            ____|___|____\r\n";
            case 4: return "         |  |           |   |\r\n";
            case 5: return "      ___|__|___________|___|__\r\n";
            case 6: return "      |/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/|\r\n";
            case 7: return "  0   |       H a p p y       |   0\r\n";
            case 8: return "  |   |/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/|   |\r\n";
            case 9: return " _|___|_______________________|___|__\r\n";
            case 10: return "|/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/\\/|\r\n";
            case 11: return "|         B i r t h d a y! ! !      |\r\n";
            case 12: return "|___________________________________|\r\n";
            default: return "";
        }
    }

    static string GetCakeLine(int lineNumber)
    {
        switch (lineNumber)
        {
            case 0: return "#                            ,.--------._                                            #\r\n";
            case 1: return "#                           /            ''.                                         #\r\n";
            case 2: return "#                         ,'                \\     |\"\\                /\\          /\\  #\r\n";
            case 3: return "#                /\"|     /                   \\    |__\"              ( \\\\        // ) #\r\n";
            case 4: return "#               \"_\"|    /           z#####z   \\  //                  \\ \\\\      // /  #\r\n";
            case 5: return "#                 \\\\  #####        ##------\".  \\//                    \\_\\\\||||//_/   #\r\n";
            case 6: return "#                  \\\\/-----\\     /          \".  \\                      \\/ _  _ \\     #\r\n";
            case 7: return "#                   \\|      \\   |   ,,--..       \\                    \\/|(O)(O)|     #\r\n";
            case 8: return "#                   | ,.--._ \\  (  | ##   \\)      \\                  \\/ |      |     #\r\n";
            case 9: return "#                   |(  ##  )/   \\ `-....-//       |///////////////_\\/  \\      /     #\r\n";
            case 10: return "#                     '--'.\"      \\                \\              //     |____|      #\r\n";
            case 11: return "#                  /'    /         ) --.            \\            ||     /      \\     #\r\n";
            case 12: return "#               ,..|     \\.________/    `-..         \\   \\       \\|     \\ 0  0 /     #\r\n";
            case 13: return "#            _,##/ |   ,/   /   \\           \\         \\   \\       U    / \\_//_/      #\r\n";
            case 14: return "#          :###.-  |  ,/   /     \\        /' \"\"\\      .\\        (     /              #\r\n";
            case 15: return "#         /####|   |   (.___________,---',/    |       |\\=._____|  |_/               #\r\n";
            case 16: return "#        /#####|   |     \\__|__|__|__|_,/             |####\\    |  ||                #\r\n";
            case 17: return "#       /######\\   \\      \\__________/                /#####|   \\  ||                #\r\n";
            case 18: return "#      /|#######`. `\\                                /#######\\   | ||                #\r\n";
            case 19: return "#     /++\\#########\\  \\                      _,'    _/#########\\ | ||                #\r\n";
            case 20: return "#    /++++|#########|  \\      .---..       ,/      ,'##########.\\|_||                #\r\n";
            case 21: return "#   //++++|#########\\.  \\.              ,-/      ,'########,+++++\\\\_\\\\               #\r\n";
            case 22: return "#  /++++++|##########\\.   '._        _,/       ,'######,''++++++++\\                  #\r\n";
            case 23: return "# |+++++++|###########|       -----.\"        _'#######' +++++++++++\\                 #\r\n";
            case 24: return "# |+++++++|############\\.     \\\\     //      /#######/               \\                #\r\n";
            case 25: return "#      ________________________\\\\___//______________________________________         #\r\n";
            case 26: return "\r\n";
            default: return "";
        }
    }
}