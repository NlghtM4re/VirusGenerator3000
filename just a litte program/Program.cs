using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

Console.SetWindowSize(160, 35);

Console.Title = "v";
Thread.Sleep(20);
Console.Title = "vi";
Thread.Sleep(20);
Console.Title = "vir";
Thread.Sleep(20);
Console.Title = "viru";
Thread.Sleep(20);
Console.Title = "virus";
Thread.Sleep(20);
Console.Title = "virus g";
Thread.Sleep(20);
Console.Title = "virus ge";
Thread.Sleep(20);
Console.Title = "virus gen";
Thread.Sleep(20);
Console.Title = "virus gene";
Thread.Sleep(20);
Console.Title = "virus gener";
Thread.Sleep(20);
Console.Title = "virus genera";
Thread.Sleep(20);
Console.Title = "virus generat";
Thread.Sleep(20);
Console.Title = "virus generato";
Thread.Sleep(20);
Console.Title = "virus generator";
Thread.Sleep(20);
Console.Title = "virus generator 3";
Thread.Sleep(20);
Console.Title = "virus generator 30";
Thread.Sleep(20);
Console.Title = "virus generator 300";
Thread.Sleep(20);
Console.Title = "virus generator 3000";
Thread.Sleep(20);

DateTime dat = DateTime.Now;
      Console.WriteLine("The time: {0:d} at {0:t}", dat);
      TimeZoneInfo tz = TimeZoneInfo.Local;
      Console.WriteLine("The time zone: {0}\n",
                        tz.IsDaylightSavingTime(dat) ?
                           tz.DaylightName : tz.StandardName);

Console.WriteLine("Width :" + Console.WindowWidth);
Console.WriteLine("Height :" + Console.WindowHeight);
Thread.Sleep(50);

for (int i = 0; i <= 100; i++)
{
    Console.Write($"\rIntsalling data... Progress: {i}%   ");
    Thread.Sleep(35);
}

Console.Clear();

Console.ForegroundColor = ConsoleColor.Red;

string logo19 = @"  _   _   _           _       _     __  __   _  _                      _  _       __    _  _     __    ___  
 | \ | | (_)         | |     | |   |  \/  | | || |                   _| || |_    / /   | || |   /_ |  / _ \ 
 |  \| |  _    __ _  | |__   | |_  | \  / | | || |_   _ __    ___   |_  __  _|  / /_   | || |_   | | | | | |
 | . ` | | |  / _` | | '_ \  | __| | |\/| | |__   _| | '__|  / _ \   _| || |_  | '_ \  |__   _|  | | | | | |
 | |\  | | | | (_| | | | | | | |_  | |  | |    | |   | |    |  __/  |_  __  _| | (_) |    | |    | | | |_| |
 |_| \_| |_|  \__, | |_| |_|  \__| |_|  |_|    |_|   |_|     \___|    |_||_|    \___/     |_|    |_|  \___/ 
               __/ |                                                                                        
              |___/                                                                                                    ";
string logo22 = @"        _                                                  _               ____   ___   ___   ___  
       (_)                                                | |             |___ \ / _ \ / _ \ / _ \ 
 __   ___ _ __ _   _ ___    __ _  ___ _ __   ___ _ __ __ _| |_ ___  _ __    __) | | | | | | | | | |
 \ \ / / | '__| | | / __|  / _` |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \| '__|  |__ <| | | | | | | | | |
  \ V /| | |  | |_| \__ \ | (_| |  __/ | | |  __/ | | (_| | || (_) | |     ___) | |_| | |_| | |_| |
   \_/ |_|_|   \__,_|___/  \__, |\___|_| |_|\___|_|  \__,_|\__\___/|_|    |____/ \___/ \___/ \___/ 
                            __/ |                                                                  
                           |___/        v 1.4.0.0                  Duplessis.emile18@gmail.com    ";Console.WriteLine(logo22);

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("E");
Thread.Sleep(50);
Console.Write("n");
Thread.Sleep(50);
Console.Write("t");
Thread.Sleep(50);
Console.Write("e");
Thread.Sleep(50);
Console.Write("r");
Thread.Sleep(50);
Console.Write(" ");
Thread.Sleep(50);
Console.Write("y");
Thread.Sleep(50);
Console.Write("o");
Thread.Sleep(50);
Console.Write("u");
Thread.Sleep(50);
Console.Write("r");
Thread.Sleep(50);
Console.Write(" ");
Thread.Sleep(50);
Console.Write("n");
Thread.Sleep(50);
Console.Write("a");
Thread.Sleep(50);
Console.Write("m");
Thread.Sleep(50);
Console.Write("e");
Thread.Sleep(50);
Console.Write(":");

string name = Console.ReadLine();

Console.Write("I");
Thread.Sleep(50);
Console.Write(" ");
Thread.Sleep(50);
Console.Write("h");
Thread.Sleep(50);
Console.Write("a");
Thread.Sleep(50);
Console.Write("t");
Thread.Sleep(50);
Console.Write("e");
Thread.Sleep(50);
Console.Write(" ");
Thread.Sleep(50);
Console.Write("y");
Thread.Sleep(50);
Console.Write("o");
Thread.Sleep(50);
Console.Write("u");
Thread.Sleep(50);
Console.Write("r");
Thread.Sleep(50);
Console.Write(" ");
Thread.Sleep(50);
Console.Write("n");
Thread.Sleep(50);
Console.Write("a");
Thread.Sleep(50);
Console.Write("m");
Thread.Sleep(50);
Console.Write("e");
Thread.Sleep(50);
Console.Write(" ");
Thread.Sleep(50);
Console.Write(name);

Thread.Sleep(500);

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("                    .       .");
Thread.Sleep(50);
Console.WriteLine("                             / `.   .'  ");
Thread.Sleep(50);
Console.WriteLine("                     .---.  <    > <    >  .---.");
Thread.Sleep(50);
Console.WriteLine("                     |    ?  ? - ~ ~ - /  /    |");
Thread.Sleep(50);
Console.WriteLine("         _____          ..-~             ~-..-~");
Thread.Sleep(50);
Console.WriteLine("        |     |   ?~~~?.'                    `./~~~/");
Thread.Sleep(50);
Console.WriteLine("       ---------   ?__/                        ?__/");
Thread.Sleep(50);
Console.WriteLine("      .'  O    ?     /               /       ?  ");
Thread.Sleep(50);
Console.WriteLine("     (_____,    `._.'               |         }  ?/~~~/");
Thread.Sleep(50);
Console.WriteLine("      `----.          /       }     |        /    ?__/");
Thread.Sleep(50);
Console.WriteLine("            `-.      |       /      |       /      `. ,~~|");
Thread.Sleep(50);
Console.WriteLine("               ~-.__|      /_ - ~ ^|      /- _      `..-'   ");
Thread.Sleep(50);
Console.WriteLine("                     |     /        |     /     ~-.     `-. _  _  _");
Thread.Sleep(50);
Console.WriteLine("                     |_____|        |_____|         ~ - . _ _ _ _ _>");
Thread.Sleep(500);

Console.WriteLine();

Console.WriteLine("..._...|..__________________ __, ,");
Thread.Sleep(50);
Console.WriteLine("....../ `–-___________–– ;_____|] = = = = POW");
Thread.Sleep(50);
Console.WriteLine("...../_==o;;;;;;;;_______.:/");
Thread.Sleep(50);
Console.WriteLine(".....), –-.(_(__) /");
Thread.Sleep(50);
Console.WriteLine("....// (..) ), ––");
Thread.Sleep(50);
Console.WriteLine("...//___//");
Thread.Sleep(50);
Console.WriteLine("..//___//");
Thread.Sleep(50);
Console.WriteLine(".//___//");
Thread.Sleep(1000);

Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkRed;

Console.WriteLine(logo19);

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine();
Console.Write("i");
Thread.Sleep(50);
Console.Write("n");
Thread.Sleep(50);
Console.Write("j");
Thread.Sleep(50);
Console.Write("e");
Thread.Sleep(50);
Console.Write("c");
Thread.Sleep(50);
Console.Write("t");
Thread.Sleep(50);
Console.Write("i");
Thread.Sleep(50);
Console.Write("n");
Thread.Sleep(50);
Console.Write("g");
Thread.Sleep(50);
Console.Write(".");
Thread.Sleep(50);
Console.Write(".");
Thread.Sleep(50);
Console.Write(".");
Thread.Sleep(50);
Console.WriteLine();
Console.Write("i");
Thread.Sleep(50);
Console.Write("n");
Thread.Sleep(50);
Console.Write("j");
Thread.Sleep(50);
Console.Write("e");
Thread.Sleep(50);
Console.Write("c");
Thread.Sleep(50);
Console.Write("t");
Thread.Sleep(50);
Console.Write("i");
Thread.Sleep(50);
Console.Write("n");
Thread.Sleep(50);
Console.Write("g");
Thread.Sleep(50);
Console.Write(".");
Thread.Sleep(50);
Console.Write(".");
Thread.Sleep(50);
Console.Write(".");
Thread.Sleep(50);
Console.WriteLine();
Console.Write("i");
Thread.Sleep(50);
Console.Write("n");
Thread.Sleep(50);
Console.Write("j");
Thread.Sleep(50);
Console.Write("e");
Thread.Sleep(50);
Console.Write("c");
Thread.Sleep(50);
Console.Write("t");
Thread.Sleep(50);
Console.Write("i");
Thread.Sleep(50);
Console.Write("n");
Thread.Sleep(50);
Console.Write("g");
Thread.Sleep(50);
Console.Write(".");
Thread.Sleep(50);
Console.Write(".");
Thread.Sleep(50);
Console.Write(".");
Console.WriteLine();

for (int i = 0; i <= 100; i++)
{
    Console.Write($"\rStarting {i}%   ");
    Thread.Sleep(25);
}
Console.WriteLine();

int n;
Console.Write("Write how many virus you want :");

n = System.Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    {
        Console.WriteLine("Number of virus:" + i);
        i++;
    }
Console.WriteLine();

Console.Write("s");
Thread.Sleep(50);
Console.Write("u");
Thread.Sleep(50);
Console.Write("c");
Thread.Sleep(50);
Console.Write("c");
Thread.Sleep(50);
Console.Write("e");
Thread.Sleep(50);
Console.Write("s");
Thread.Sleep(50);
Console.Write("s");
Thread.Sleep(50);
Console.Write("!");
Thread.Sleep(700);
Console.WriteLine();

Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
string logo1 = @"        
        
 __   __
 \ \ / /
  \ V / 
   \_/  
        
        ";
Console.WriteLine(logo1);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkGreen;
string logo2 = @"        _ 
       (_)
 __   ___ 
 \ \ / / |
  \ V /| |
   \_/ |_|
          
          ";
          Console.WriteLine(logo2);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkYellow;
string logo3 = @"        _      
       (_)     
 __   ___ _ __ 
 \ \ / / | '__|
  \ V /| | |   
   \_/ |_|_|   
               
               ";
               Console.WriteLine(logo3);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
string logo4 = @"        _            
       (_)           
 __   ___ _ __ _   _ 
 \ \ / / | '__| | | |
  \ V /| | |  | |_| |
   \_/ |_|_|   \__,_|
                     
                     ";
                     Console.WriteLine(logo4);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
string logo5 = @"        _                
       (_)               
 __   ___ _ __ _   _ ___ 
 \ \ / / | '__| | | / __|
  \ V /| | |  | |_| \__ \
   \_/ |_|_|   \__,_|___/
                         
                         ";Console.WriteLine(logo5);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkRed;
string logo6 = @"        _                        
       (_)                       
 __   ___ _ __ _   _ ___    __ _ 
 \ \ / / | '__| | | / __|  / _` |
  \ V /| | |  | |_| \__ \ | (_| |
   \_/ |_|_|   \__,_|___/  \__, |
                            __/ |
                           |___/ ";Console.WriteLine(logo6);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
string logo7 = @"        _                             
       (_)                            
 __   ___ _ __ _   _ ___    __ _  ___ 
 \ \ / / | '__| | | / __|  / _` |/ _ \
  \ V /| | |  | |_| \__ \ | (_| |  __/
   \_/ |_|_|   \__,_|___/  \__, |\___|
                            __/ |     
                           |___/      ";Console.WriteLine(logo7);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Magenta;
string logo8 = @"        _                                   
       (_)                                  
 __   ___ _ __ _   _ ___    __ _  ___ _ __  
 \ \ / / | '__| | | / __|  / _` |/ _ \ '_ \ 
  \ V /| | |  | |_| \__ \ | (_| |  __/ | | |
   \_/ |_|_|   \__,_|___/  \__, |\___|_| |_|
                            __/ |           
                           |___/            ";Console.WriteLine(logo8);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
string logo9 = @"        _                                        
       (_)                                       
 __   ___ _ __ _   _ ___    __ _  ___ _ __   ___ 
 \ \ / / | '__| | | / __|  / _` |/ _ \ '_ \ / _ \
  \ V /| | |  | |_| \__ \ | (_| |  __/ | | |  __/
   \_/ |_|_|   \__,_|___/  \__, |\___|_| |_|\___|
                            __/ |                
                           |___/                 ";Console.WriteLine(logo9);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Blue;
string logo10 = @"        _                                             
       (_)                                            
 __   ___ _ __ _   _ ___    __ _  ___ _ __   ___ _ __ 
 \ \ / / | '__| | | / __|  / _` |/ _ \ '_ \ / _ \ '__|
  \ V /| | |  | |_| \__ \ | (_| |  __/ | | |  __/ |   
   \_/ |_|_|   \__,_|___/  \__, |\___|_| |_|\___|_|   
                            __/ |                     
                           |___/                      ";Console.WriteLine(logo10);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
string logo11 = @"        _                                                  
       (_)                                                 
 __   ___ _ __ _   _ ___    __ _  ___ _ __   ___ _ __ __ _ 
 \ \ / / | '__| | | / __|  / _` |/ _ \ '_ \ / _ \ '__/ _` |
  \ V /| | |  | |_| \__ \ | (_| |  __/ | | |  __/ | | (_| |
   \_/ |_|_|   \__,_|___/  \__, |\___|_| |_|\___|_|  \__,_|
                            __/ |                          
                           |___/                           ";Console.WriteLine(logo11);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkGreen;
string logo12 = @"        _                                                  _   
       (_)                                                | |  
 __   ___ _ __ _   _ ___    __ _  ___ _ __   ___ _ __ __ _| |_ 
 \ \ / / | '__| | | / __|  / _` |/ _ \ '_ \ / _ \ '__/ _` | __|
  \ V /| | |  | |_| \__ \ | (_| |  __/ | | |  __/ | | (_| | |_ 
   \_/ |_|_|   \__,_|___/  \__, |\___|_| |_|\___|_|  \__,_|\__|
                            __/ |                              
                           |___/                               ";Console.WriteLine(logo12);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
string logo13 = @"        _                                                  _        
       (_)                                                | |       
 __   ___ _ __ _   _ ___    __ _  ___ _ __   ___ _ __ __ _| |_ ___  
 \ \ / / | '__| | | / __|  / _` |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \ 
  \ V /| | |  | |_| \__ \ | (_| |  __/ | | |  __/ | | (_| | || (_) |
   \_/ |_|_|   \__,_|___/  \__, |\___|_| |_|\___|_|  \__,_|\__\___/ 
                            __/ |                                   
                           |___/                                    ";Console.WriteLine(logo13);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
string logo14 = @"        _                                                  _             
       (_)                                                | |            
 __   ___ _ __ _   _ ___    __ _  ___ _ __   ___ _ __ __ _| |_ ___  _ __ 
 \ \ / / | '__| | | / __|  / _` |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \| '__|
  \ V /| | |  | |_| \__ \ | (_| |  __/ | | |  __/ | | (_| | || (_) | |   
   \_/ |_|_|   \__,_|___/  \__, |\___|_| |_|\___|_|  \__,_|\__\___/|_|   
                            __/ |                                        
                           |___/                                         ";Console.WriteLine(logo14);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkYellow;
string logo15 = @"        _                                                  _               ____  
       (_)                                                | |             |___ \ 
 __   ___ _ __ _   _ ___    __ _  ___ _ __   ___ _ __ __ _| |_ ___  _ __    __) |
 \ \ / / | '__| | | / __|  / _` |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \| '__|  |__ < 
  \ V /| | |  | |_| \__ \ | (_| |  __/ | | |  __/ | | (_| | || (_) | |     ___) |
   \_/ |_|_|   \__,_|___/  \__, |\___|_| |_|\___|_|  \__,_|\__\___/|_|    |____/ 
                            __/ |                                                
                           |___/                                                 ";Console.WriteLine(logo15);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
string logo16 = @"        _                                                  _               ____   ___  
       (_)                                                | |             |___ \ / _ \ 
 __   ___ _ __ _   _ ___    __ _  ___ _ __   ___ _ __ __ _| |_ ___  _ __    __) | | | |
 \ \ / / | '__| | | / __|  / _` |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \| '__|  |__ <| | | |
  \ V /| | |  | |_| \__ \ | (_| |  __/ | | |  __/ | | (_| | || (_) | |     ___) | |_| |
   \_/ |_|_|   \__,_|___/  \__, |\___|_| |_|\___|_|  \__,_|\__\___/|_|    |____/ \___/ 
                            __/ |                                                      
                           |___/                                                       ";Console.WriteLine(logo16);
Thread.Sleep(100);
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkRed;
string logo17 = @"        _                                                  _               ____   ___   ___  
       (_)                                                | |             |___ \ / _ \ / _ \ 
 __   ___ _ __ _   _ ___    __ _  ___ _ __   ___ _ __ __ _| |_ ___  _ __    __) | | | | | | |
 \ \ / / | '__| | | / __|  / _` |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \| '__|  |__ <| | | | | | |
  \ V /| | |  | |_| \__ \ | (_| |  __/ | | |  __/ | | (_| | || (_) | |     ___) | |_| | |_| |
   \_/ |_|_|   \__,_|___/  \__, |\___|_| |_|\___|_|  \__,_|\__\___/|_|    |____/ \___/ \___/ 
                            __/ |                                                            
                           |___/                                                             ";Console.WriteLine(logo17);
Thread.Sleep(100);
Console.Clear();
string logo18 = @"        _                                                  _               ____   ___   ___   ___  
       (_)                                                | |             |___ \ / _ \ / _ \ / _ \ 
 __   ___ _ __ _   _ ___    __ _  ___ _ __   ___ _ __ __ _| |_ ___  _ __    __) | | | | | | | | | |
 \ \ / / | '__| | | / __|  / _` |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \| '__|  |__ <| | | | | | | | | |
  \ V /| | |  | |_| \__ \ | (_| |  __/ | | |  __/ | | (_| | || (_) | |     ___) | |_| | |_| | |_| |
   \_/ |_|_|   \__,_|___/  \__, |\___|_| |_|\___|_|  \__,_|\__\___/|_|    |____/ \___/ \___/ \___/ 
                            __/ |                                                                  
                           |___/                                                                   ";Console.WriteLine(logo18);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine();
Console.WriteLine("Discord :");
Console.WriteLine();
string logo21 = @"  _     _   _                   ____ _ _                       _                  ____   ________ _____ _____  _    _ _    _  ____            
 | |   | | | |            _    / / /| (_)                     | |                / /\ \ / /  ____/ ____|  __ \| |  | | |  | |/ __ \           
 | |__ | |_| |_ _ __  ___(_)  / / /_| |_ ___  ___ ___  _ __ __| |  __ _  __ _   / /  \ V /| |__ | |  __| |__) | |  | | |  | | |  | |_ __ ___  
 | '_ \| __| __| '_ \/ __|   / / / _` | / __|/ __/ _ \| '__/ _` | / _` |/ _` | / /    > < |  __|| | |_ |  ___/| |  | | |  | | |  | | '_ ` _ \ 
 | | | | |_| |_| |_) \__ \_ / / / (_| | \__ \ (_| (_) | | | (_| || (_| | (_| |/ /    / . \| |   | |__| | |    | |__| | |__| | |__| | | | | | |
 |_| |_|\__|\__| .__/|___(_)_/_/ \__,_|_|___/\___\___/|_|  \__,_(_)__, |\__, /_/    /_/ \_\_|    \_____|_|     \____/ \____/ \___\_\_| |_| |_|
               | |                                                 __/ | __/ |                                                                
               |_|                                               |___/ |___/                                                                 ";
Console.WriteLine(logo21);
Thread.Sleep(200);

string logo23 = @"       __
  _   / /
 (_) | | 
     | | 
  _  | | 
 (_) | | 
      \_\
         ";

Console.WriteLine("press (Enter) to exit!");
while (Console.ReadKey().Key != ConsoleKey.Enter) 
{
       Console.Write(logo23);
}

