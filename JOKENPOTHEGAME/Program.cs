using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOKENPOTHEGAME
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            int escolhae = 0;
            int saida = 0;


            //programa 2
            int pontin = 0;
            string[] rank = { "Thiago", "Eliel", "Roger", "Leo", "AAA" };
            int[] rankN = { 1000, 500, 250, 100, 50 };
            int perdeu = 0, a = 0, b = 0;
            string[] escolha = { "", "pedra", "papel", "tesoura" };
            string[] escolhaJ = { "", "pedra", "papel", "tesoura" };
            int k = 0;

            //menu
            Console.WriteLine("\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                   ,wgg&&&gw,,                                 ");
            Console.WriteLine("                               ,g$lllllllllllll@w                            ");
            Console.WriteLine("                             /$llllll&M***M&llllll%,                         ");
            Console.WriteLine("                           ,$llll$'           `*lllllg                        ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                           $llll'                Y %%%%");
            Console.WriteLine("                          $llllF      g$$,                                     ");
            Console.WriteLine("                          lllll     g$llll$w                                   ");
            Console.WriteLine("                          lllll     `YllllF                                    ");
            Console.WriteLine("                          ]llllk       **                                      ");
            Console.WriteLine("                           %llllg,             ,$llllF                          ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                            1$$$$$@w,       ,g@$$$$@`                           ");
            Console.WriteLine("                              %$$$$$$$$@@$$$$$$$$@'                             ");
            Console.WriteLine("                                *%$$$$$$$$$$$% *");
            Console.WriteLine("                                     `'''''                                     ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                              CHEKPOINT GAME STUDIO");
            Console.WriteLine("                                     presents...");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("       d8,          d8b                                                   ");
            Console.WriteLine("      `8P           ?88                                                   ");
            Console.WriteLine("                     88b                                                  ");
            Console.WriteLine("      d88   d8888b   888  d88' d8888b  88bd88b ?88,.d88b, d8888b          ");
            Console.WriteLine("      ?88  d8P' ?88  888bd8P' d8b_,dP  88P' ?8b`?88'  ?88d8P' ?88         ");
            Console.WriteLine("       88b 88b  d88 d88888b   88b     d88   88P  88b  d8P88b  d88         ");
            Console.WriteLine("       `88b`?8888P'd88' `?88b,`?888P'd88'   88b  888888P'`?8888P'         ");
            Console.WriteLine("        )88                                      88P'                     ");
            Console.WriteLine("       ,88P                                     d88                       ");
            Console.WriteLine("    `?888P                                      ?8P                       ");
            Console.WriteLine("         d8b                                                             ");
            Console.WriteLine("   d8P   ?88                                                             ");
            Console.WriteLine("d888888P  88b                                                            ");
            Console.WriteLine("  ?88'    888888b  d8888b         d888b8b   d888b8b    88bd8b,d88b  d8888b");
            Console.WriteLine("  88P     88P `?8bd8b_,dP        d8P' ?88  d8P' ?88    88P'`?8P'?8bd8b_,dP");
            Console.WriteLine("  88b    d88   88P88b            88b  ,88b 88b  ,88b  d88  d88  88P88b    ");
            Console.WriteLine("  `?8b  d88'   88b`?888P'        `?88P'`88b`?88P'`88bd88' d88'  88b`?888P'");
            Console.WriteLine("                                        )88                               ");
            Console.WriteLine("                                       ,88P                               ");
            Console.WriteLine("                                   `?8888P                                ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nDescrição: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Uma forma divertida de jogar jokenpo!!!\n           Jogue contra seu amigo ou contra a máquina neste ÉPICO DESAFIO MILENAR\n           E SEM PRECISAR ESTENDER SUA MÃO!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nDesenvolvido pela");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Checkpoint Game Studio");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(": Eliel Adrian, Leonardo Trindade, Roger Norio, Thiago Yasue");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nVersão Final 1.0\nData: 22/05/2019");
            Console.ReadKey();
            do
            {


                Console.ForegroundColor = ConsoleColor.Red;


                

                Console.Clear();

                Console.WriteLine("          )      )          )  (        )         ");
                Console.WriteLine("       ( /(   ( /(       ( /(  )| )  ( /(         ");
                Console.WriteLine("   (   )|())  )|()) (    )|())(()/(  )|())        ");
                Console.WriteLine("   )|((_)| |((_)|  )|  ((_)|  /(_))((_)|         ");
                Console.WriteLine("  ((_)  ((_)|_ ((_)((_)  _((_)(_))    ((_)        ");
                Console.WriteLine(" _ | | | _ || |/ / | __|| || || _ |  | _ |       ");
                Console.WriteLine("| || || (_) | ' <  | _| | .` ||  _/ | (_) |       ");
                Console.WriteLine(" |__/  |___| _||_| |___||_||_||_|    |___|        ");
                Console.WriteLine("            )                          *          ");
                Console.WriteLine("  *   )  ( /(        (        (     (  `         ");
                Console.WriteLine("` )  /(  )|()) (     )| )     )|    )|))(   (    ");
                Console.WriteLine(" ( )(_))((_)|  )|   (()/(  ((((_)(  ((_)()|  )|   ");
                Console.WriteLine("(_(_())  _((_)((_)   /(_))_ )| _ )| (_()((_)((_)  ");
                Console.WriteLine("|_   _| | || || __| (_)) __|(_/ _ | |  v   || __| ");
                Console.WriteLine("  | |   | __ || _|    | (_ | / _  | | |v | || _|  ");
                Console.WriteLine("  |_|   |_||_||___|    |___|/_/ |_| |_|  |_||___| ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("(C) Checkpoint 2019");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Digite os números entre 1 e 4 para selecionar os menus");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[Nº1] [JOGADOR VS JOGADOR]");
                Console.WriteLine("[Nº2] [JOGADOR VS MÁQUINA]");
                Console.WriteLine("[Nº3] [RANKING]");
                Console.WriteLine("[Nº4] [TELA DE TÍTULO]");
                Console.WriteLine("[Nº5] [SAIR]");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nSelecione o menu: ");
                s = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (s)
                {

                    case 1:
                        int xE = 0, y = 0, z = 0, v = 0, t = 0;
                        char resp = 'S';

                        while (resp == 'S' || resp == 's')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Clear();
                            Console.WriteLine("                                   ?+=.                      .?==      ...         ");
                            Console.WriteLine("                              7+?. ?=~   ...                ..?==     .?+.         ");
                            Console.WriteLine("                              I=~. 7=~.  7?=.                 7+~..   .?==.        ");
                            Console.WriteLine("                              I==  I~~. .I==                  .+~~   .$+~=         ");
                            Console.WriteLine("                              7+~. ?~~. .?=~.                 .+~~.   I=~..        ");
                            Console.WriteLine("                          I+.. 7=~..?=~. $+~=                 .7==.  .+~~          ");
                            Console.WriteLine("                          I+.. 7=~..?=~. $+~=                 .I=~. .$?~:.         ");
                            Console.WriteLine("                          .+++ Z+==.+~~..?=~.                  ~=~+ .+=:=.         ");
                            Console.WriteLine("                           I=~..?=~.?==.7+~=.               .,I?==+.+?=:           ");
                            Console.WriteLine("                          ..??=.7=??=~=++=~... II+.         .??+?==I+?=~           ");
                            Console.WriteLine("          ..+~~7=:.        .I~~.7+=+~~~===~.  $I=~.         .7?7~=7$$$~~           ");
                            Console.WriteLine("      ...?~~++~,+~~..      ..?+=+~~=~~+==~=..=I=~         .7??Z+=:==+:~=..         ");
                            Console.WriteLine("      ?~~+~~+?I=~:~::        ?+==~~~==~??==?.77=~.       .I??+8++=~~::~=.         ");
                            Console.WriteLine("     7I~:?~~?+?8?+$::       .I=:=+~~~=+I+=++.?=~.        .$I??=:?=:$7=~:~.         ");
                            Console.WriteLine("    .?I=:~=~ZIINOI+~:.      .I+=~~~===??+++=I?=~        .?=8?:,~:Z?I::~.          ");
                            Console.WriteLine("  .?+?7I$7IOZ8I+?~=:.      .$?=~~~~==?=+?+?++~~          7+=?7$ZZI?=~:=..         ");
                            Console.WriteLine("   .?=~=++?7++~:~:~~~.      .?==~===+I??++=~~~.          .,?=~=+77?+=::=.         ");
                            Console.WriteLine("   .7=:::~~==~~~:::=..      .7?===~=++?++=~::.            .7=~~~+$?=~::=..        ");
                            Console.WriteLine("   .I?~~::==:~~~~~= .       .ZI+=~=~====~~~::              $?==~:++=~~~+.         ");
                            Console.WriteLine("    .7=~::~+==++==.           $?=~~:~~~~~~:                 7=~:~,+~::~           ");
                            Console.WriteLine("    .$+==~=+:+==+.            $I=~::~~:::=.                 $I=~:::~~:=           ");
                            Console.WriteLine("    ..?+==~==~~~.             7$?~~::~~~=                   I$+~:::~:~=           ");
                            Console.WriteLine("    ..+=+~~~~~==.             $7?+==::~=.                   7$=~=~:~~~.           ");
                            Console.WriteLine("     .=++~~~~=~=.             Z7===~~~~=.                   $$~~=~::=~            ");
                            Console.WriteLine("      ===~:~~~==.             ZI+==~::=+                    Z7~~~~~:=.            ");
                            Console.WriteLine("      +=~~~::~~=.             $I+=~~::=?                    $I=~~~::=.            ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("      (1)Pedra                  (2)Papel               (3)Tesoura\nJOGADOR 1, Digite sua escolha: ", k);
                            xE = int.Parse(Console.ReadLine());
                            Console.ResetColor();
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("                                   ?+=.                      .?==      ...         ");
                            Console.WriteLine("                              7+?. ?=~   ...                ..?==     .?+.         ");
                            Console.WriteLine("                              I=~. 7=~.  7?=.                 7+~..   .?==.        ");
                            Console.WriteLine("                              I==  I~~. .I==                  .+~~   .$+~=         ");
                            Console.WriteLine("                              7+~. ?~~. .?=~.                 .+~~.   I=~..        ");
                            Console.WriteLine("                          I+.. 7=~..?=~. $+~=                 .7==.  .+~~          ");
                            Console.WriteLine("                          I+.. 7=~..?=~. $+~=                 .I=~. .$?~:.         ");
                            Console.WriteLine("                          .+++ Z+==.+~~..?=~.                  ~=~+ .+=:=.         ");
                            Console.WriteLine("                           I=~..?=~.?==.7+~=.               .,I?==+.+?=:           ");
                            Console.WriteLine("                          ..??=.7=??=~=++=~... II+.         .??+?==I+?=~           ");
                            Console.WriteLine("          ..+~~7=:.        .I~~.7+=+~~~===~.  $I=~.         .7?7~=7$$$~~           ");
                            Console.WriteLine("      ...?~~++~,+~~..      ..?+=+~~=~~+==~=..=I=~         .7??Z+=:==+:~=..         ");
                            Console.WriteLine("      ?~~+~~+?I=~:~::        ?+==~~~==~??==?.77=~.       .I??+8++=~~::~=.         ");
                            Console.WriteLine("     7I~:?~~?+?8?+$::       .I=:=+~~~=+I+=++.?=~.        .$I??=:?=:$7=~:~.         ");
                            Console.WriteLine("    .?I=:~=~ZIINOI+~:.      .I+=~~~===??+++=I?=~        .?=8?:,~:Z?I::~.          ");
                            Console.WriteLine("  .?+?7I$7IOZ8I+?~=:.      .$?=~~~~==?=+?+?++~~          7+=?7$ZZI?=~:=..         ");
                            Console.WriteLine("   .?=~=++?7++~:~:~~~.      .?==~===+I??++=~~~.          .,?=~=+77?+=::=.         ");
                            Console.WriteLine("   .7=:::~~==~~~:::=..      .7?===~=++?++=~::.            .7=~~~+$?=~::=..        ");
                            Console.WriteLine("   .I?~~::==:~~~~~= .       .ZI+=~=~====~~~::              $?==~:++=~~~+.         ");
                            Console.WriteLine("    .7=~::~+==++==.           $?=~~:~~~~~~:                 7=~:~,+~::~           ");
                            Console.WriteLine("    .$+==~=+:+==+.            $I=~::~~:::=.                 $I=~:::~~:=           ");
                            Console.WriteLine("    ..?+==~==~~~.             7$?~~::~~~=                   I$+~:::~:~=           ");
                            Console.WriteLine("    ..+=+~~~~~==.             $7?+==::~=.                   7$=~=~:~~~.           ");
                            Console.WriteLine("     .=++~~~~=~=.             Z7===~~~~=.                   $$~~=~::=~            ");
                            Console.WriteLine("      ===~:~~~==.             ZI+==~::=+                    Z7~~~~~:=.            ");
                            Console.WriteLine("      +=~~~::~~=.             $I+=~~::=?                    $I=~~~::=.            ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("      (1)Pedra                  (2)Papel               (3)Tesoura\nJOGADOR 2, Digite sua escolha: ", k);
                            y = int.Parse(Console.ReadLine());
                            Console.ResetColor();
                            Console.Clear();

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            if (xE == 1)
                            {
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("          ..+~~7=:.           ");
                                Console.WriteLine("      ...?~~++~,+~~..         ");
                                Console.WriteLine("      ?~~+~~+?I=~:~::         ");
                                Console.WriteLine("     7I~:?~~?+?8?+$::         ");
                                Console.WriteLine("    .?I=:~=~ZIINOI+~:.        ");
                                Console.WriteLine("  .?+?7I$7IOZ8I+?~=:.         ");
                                Console.WriteLine("   .?=~=++?7++~:~:~~~.        ");
                                Console.WriteLine("   .7=:::~~==~~~:::=..        ");
                                Console.WriteLine("   .I?~~::==:~~~~~= .         ");
                                Console.WriteLine("    .7=~::~+==++==.           ");
                                Console.WriteLine("    .$+==~=+:+==+.            ");
                                Console.WriteLine("    ..?+==~==~~~.             ");
                                Console.WriteLine("    ..+=+~~~~~==.             ");
                                Console.WriteLine("     .=++~~~~=~=.             ");
                                Console.WriteLine("      ===~:~~~==.             ");
                                Console.WriteLine("      +=~~~::~~=.             ");
                                Console.WriteLine("Jogador 1 jogou Pedra");
                            }
                            else if (xE == 2)
                            {
                                Console.WriteLine("            ?+=.            ");
                                Console.WriteLine("       7+?. ?=~   ...         ");
                                Console.WriteLine("       I=~. 7=~.  7?=.        ");
                                Console.WriteLine("       I==  I~~. .I==         ");
                                Console.WriteLine("       7+~. ?~~. .?=~.         ");
                                Console.WriteLine("  I+.. 7=~..?=~. $+~=          ");
                                Console.WriteLine("  7+=. $==..?=~. 7?~.          ");
                                Console.WriteLine("  .+++ Z+==.+~~..?=~.         ");
                                Console.WriteLine("   I=~..?=~.?==.7+~=.         ");
                                Console.WriteLine("  ..??=.7=??=~=++=~... II+.   ");
                                Console.WriteLine("   .I~~.7+=+~~~===~.  $I=~.    ");
                                Console.WriteLine("   ..?+=+~~=~~+==~=..=I=~      ");
                                Console.WriteLine("     ?+==~~~==~??==?.77=~.    ");
                                Console.WriteLine("    .I=:=+~~~=+I+=++.?=~.    ");
                                Console.WriteLine("    .I+=~~~===??+++=I?=~      ");
                                Console.WriteLine("   .$?=~~~~==?=+?+?++~~       ");
                                Console.WriteLine("    .?==~===+I??++=~~~.      ");
                                Console.WriteLine("    .7?===~=++?++=~::.       ");
                                Console.WriteLine("    .ZI+=~=~====~~~::        ");
                                Console.WriteLine("      $?=~~:~~~~~~:,         ");
                                Console.WriteLine("      $I=~::~~:::=.          ");
                                Console.WriteLine("      7$?~~::~~~=             ");
                                Console.WriteLine("      $7?+==::~=.             ");
                                Console.WriteLine("      Z7===~~~~=.             ");
                                Console.WriteLine("      ZI+==~::=+              ");
                                Console.WriteLine("      $I+=~~::=?              ");
                                Console.WriteLine("Jogador 1 jogou Papel");
                            }
                            else if (xE == 3)
                            {
                                Console.WriteLine("     .?==      ...      ");
                                Console.WriteLine("    ..?==     .?+.      ");
                                Console.WriteLine("      7+~..   .?==.     ");
                                Console.WriteLine("      .+~~   .$+~=      ");
                                Console.WriteLine("      .+~~.   I=~..     ");
                                Console.WriteLine("      .7==.  .+~~       ");
                                Console.WriteLine("      .I=~. .$?~:.      ");
                                Console.WriteLine("       ~=~+ .+=:=.      ");
                                Console.WriteLine("    .,I?==+.+?=:         ");
                                Console.WriteLine("    .??+?==I+?=~        ");
                                Console.WriteLine("    .7?7~=7$$$~~         ");
                                Console.WriteLine("   .7??Z+=:==+:~=..       ");
                                Console.WriteLine("   .I??+8++=~~::~=.       ");
                                Console.WriteLine("  .$I??=:?=:$7=~:~.        ");
                                Console.WriteLine("   .?=8?:,~:Z?I::~.        ");
                                Console.WriteLine("   7+=?7$ZZI?=~:=..       ");
                                Console.WriteLine("   .,?=~=+77?+=::=.         ");
                                Console.WriteLine("    .7=~~~+$?=~::=..        ");
                                Console.WriteLine("     $?==~:++=~~~+.         ");
                                Console.WriteLine("      7=~:~,+~::~           ");
                                Console.WriteLine("      $I=~:::~~:=           ");
                                Console.WriteLine("      I$+~:::~:~=           ");
                                Console.WriteLine("      7$=~=~:~~~.           ");
                                Console.WriteLine("      $$~~=~::=~            ");
                                Console.WriteLine("      Z7~~~~~:=.            ");
                                Console.WriteLine("      $I=~~~::=.            ");
                                Console.WriteLine("Jogador 1 jogou Tesoura");
                            }

                            
                            Console.ReadKey();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;

                            if (y == 1)
                            {
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("                              ");
                                Console.WriteLine("          ..+~~7=:.           ");
                                Console.WriteLine("      ...?~~++~,+~~..         ");
                                Console.WriteLine("      ?~~+~~+?I=~:~::         ");
                                Console.WriteLine("     7I~:?~~?+?8?+$::         ");
                                Console.WriteLine("    .?I=:~=~ZIINOI+~:.        ");
                                Console.WriteLine("  .?+?7I$7IOZ8I+?~=:.         ");
                                Console.WriteLine("   .?=~=++?7++~:~:~~~.        ");
                                Console.WriteLine("   .7=:::~~==~~~:::=..        ");
                                Console.WriteLine("   .I?~~::==:~~~~~= .         ");
                                Console.WriteLine("    .7=~::~+==++==.           ");
                                Console.WriteLine("    .$+==~=+:+==+.            ");
                                Console.WriteLine("    ..?+==~==~~~.             ");
                                Console.WriteLine("    ..+=+~~~~~==.             ");
                                Console.WriteLine("     .=++~~~~=~=.             ");
                                Console.WriteLine("      ===~:~~~==.             ");
                                Console.WriteLine("      +=~~~::~~=.             ");
                                Console.WriteLine("Jogador 2 jogou Pedra");
                            }
                            else if (y == 2)
                            {
                                Console.WriteLine("            ?+=.            ");
                                Console.WriteLine("       7+?. ?=~   ...         ");
                                Console.WriteLine("       I=~. 7=~.  7?=.        ");
                                Console.WriteLine("       I==  I~~. .I==         ");
                                Console.WriteLine("       7+~. ?~~. .?=~.         ");
                                Console.WriteLine("  I+.. 7=~..?=~. $+~=          ");
                                Console.WriteLine("  7+=. $==..?=~. 7?~.          ");
                                Console.WriteLine("  .+++ Z+==.+~~..?=~.         ");
                                Console.WriteLine("   I=~..?=~.?==.7+~=.         ");
                                Console.WriteLine("  ..??=.7=??=~=++=~... II+.   ");
                                Console.WriteLine("   .I~~.7+=+~~~===~.  $I=~.    ");
                                Console.WriteLine("   ..?+=+~~=~~+==~=..=I=~      ");
                                Console.WriteLine("     ?+==~~~==~??==?.77=~.    ");
                                Console.WriteLine("    .I=:=+~~~=+I+=++.?=~.    ");
                                Console.WriteLine("    .I+=~~~===??+++=I?=~      ");
                                Console.WriteLine("   .$?=~~~~==?=+?+?++~~       ");
                                Console.WriteLine("    .?==~===+I??++=~~~.      ");
                                Console.WriteLine("    .7?===~=++?++=~::.       ");
                                Console.WriteLine("    .ZI+=~=~====~~~::        ");
                                Console.WriteLine("      $?=~~:~~~~~~:,         ");
                                Console.WriteLine("      $I=~::~~:::=.          ");
                                Console.WriteLine("      7$?~~::~~~=             ");
                                Console.WriteLine("      $7?+==::~=.             ");
                                Console.WriteLine("      Z7===~~~~=.             ");
                                Console.WriteLine("      ZI+==~::=+              ");
                                Console.WriteLine("      $I+=~~::=?              ");
                                Console.WriteLine("Jogador 2 jogou Papel");
                            }
                            else if (y == 3)
                            {
                                Console.WriteLine("     .?==      ...      ");
                                Console.WriteLine("    ..?==     .?+.      ");
                                Console.WriteLine("      7+~..   .?==.     ");
                                Console.WriteLine("      .+~~   .$+~=      ");
                                Console.WriteLine("      .+~~.   I=~..     ");
                                Console.WriteLine("      .7==.  .+~~       ");
                                Console.WriteLine("      .I=~. .$?~:.      ");
                                Console.WriteLine("       ~=~+ .+=:=.      ");
                                Console.WriteLine("    .,I?==+.+?=:         ");
                                Console.WriteLine("    .??+?==I+?=~        ");
                                Console.WriteLine("    .7?7~=7$$$~~         ");
                                Console.WriteLine("   .7??Z+=:==+:~=..       ");
                                Console.WriteLine("   .I??+8++=~~::~=.       ");
                                Console.WriteLine("  .$I??=:?=:$7=~:~.        ");
                                Console.WriteLine("   .?=8?:,~:Z?I::~.        ");
                                Console.WriteLine("   7+=?7$ZZI?=~:=..       ");
                                Console.WriteLine("   .,?=~=+77?+=::=.         ");
                                Console.WriteLine("    .7=~~~+$?=~::=..        ");
                                Console.WriteLine("     $?==~:++=~~~+.         ");
                                Console.WriteLine("      7=~:~,+~::~           ");
                                Console.WriteLine("      $I=~:::~~:=           ");
                                Console.WriteLine("      I$+~:::~:~=           ");
                                Console.WriteLine("      7$=~=~:~~~.           ");
                                Console.WriteLine("      $$~~=~::=~            ");
                                Console.WriteLine("      Z7~~~~~:=.            ");
                                Console.WriteLine("      $I=~~~::=.            ");
                                Console.WriteLine("Jogador 2 jogou Tesoura");
                            }


                            if (xE == y)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nEMPATE");
                                Console.ResetColor();
                                z++;
                            }
                            else if (xE == 1 && y == 2 || xE == 2 && y == 3 || xE == 3 && y == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nJOGADOR 2 VENCEU");
                                Console.ResetColor();
                                t++;
                            }
                            else if (xE == 1 && y == 3 || xE == 2 && y == 1 || xE == 3 && y == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("\nJOGADOR 1 VENCEU");
                                Console.ResetColor();
                                v++;
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("DESEJAM JOGAR NOVAMENTE? S/N\n");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            resp = char.Parse(Console.ReadLine());
                            Console.ResetColor();
                            Console.Clear();
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("GAME OVER!");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("O JOGADOR 1 VENCEU {0} VEZES", v);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O JOGADOR 2 VENCEU {0} VEZES", t);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("OCORRERAM {0} EMPATES", z);
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                    case 2:
                        do
                        {
                            k = 0;
                            perdeu = 0;
                            pontin = 0;
                            do
                            {
                                Random x = new Random();
                                a = x.Next(1, 4);

                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    Console.WriteLine("                                   ?+=.                      .?==      ...         ");
                                    Console.WriteLine("                              7+?. ?=~   ...                ..?==     .?+.         ");
                                    Console.WriteLine("                              I=~. 7=~.  7?=.                 7+~..   .?==.        ");
                                    Console.WriteLine("                              I==  I~~. .I==                  .+~~   .$+~=         ");
                                    Console.WriteLine("                              7+~. ?~~. .?=~.                 .+~~.   I=~..        ");
                                    Console.WriteLine("                          I+.. 7=~..?=~. $+~=                 .7==.  .+~~          ");
                                    Console.WriteLine("                          I+.. 7=~..?=~. $+~=                 .I=~. .$?~:.         ");
                                    Console.WriteLine("                          .+++ Z+==.+~~..?=~.                  ~=~+ .+=:=.         ");
                                    Console.WriteLine("                           I=~..?=~.?==.7+~=.               .,I?==+.+?=:           ");
                                    Console.WriteLine("                          ..??=.7=??=~=++=~... II+.         .??+?==I+?=~           ");
                                    Console.WriteLine("          ..+~~7=:.        .I~~.7+=+~~~===~.  $I=~.         .7?7~=7$$$~~           ");
                                    Console.WriteLine("      ...?~~++~,+~~..      ..?+=+~~=~~+==~=..=I=~         .7??Z+=:==+:~=..         ");
                                    Console.WriteLine("      ?~~+~~+?I=~:~::        ?+==~~~==~??==?.77=~.       .I??+8++=~~::~=.         ");
                                    Console.WriteLine("     7I~:?~~?+?8?+$::       .I=:=+~~~=+I+=++.?=~.        .$I??=:?=:$7=~:~.         ");
                                    Console.WriteLine("    .?I=:~=~ZIINOI+~:.      .I+=~~~===??+++=I?=~        .?=8?:,~:Z?I::~.          ");
                                    Console.WriteLine("  .?+?7I$7IOZ8I+?~=:.      .$?=~~~~==?=+?+?++~~          7+=?7$ZZI?=~:=..         ");
                                    Console.WriteLine("   .?=~=++?7++~:~:~~~.      .?==~===+I??++=~~~.          .,?=~=+77?+=::=.         ");
                                    Console.WriteLine("   .7=:::~~==~~~:::=..      .7?===~=++?++=~::.            .7=~~~+$?=~::=..        ");
                                    Console.WriteLine("   .I?~~::==:~~~~~= .       .ZI+=~=~====~~~::              $?==~:++=~~~+.         ");
                                    Console.WriteLine("    .7=~::~+==++==.           $?=~~:~~~~~~:                 7=~:~,+~::~           ");
                                    Console.WriteLine("    .$+==~=+:+==+.            $I=~::~~:::=.                 $I=~:::~~:=           ");
                                    Console.WriteLine("    ..?+==~==~~~.             7$?~~::~~~=                   I$+~:::~:~=           ");
                                    Console.WriteLine("    ..+=+~~~~~==.             $7?+==::~=.                   7$=~=~:~~~.           ");
                                    Console.WriteLine("     .=++~~~~=~=.             Z7===~~~~=.                   $$~~=~::=~            ");
                                    Console.WriteLine("      ===~:~~~==.             ZI+==~::=+                    Z7~~~~~:=.            ");
                                    Console.WriteLine("      +=~~~::~~=.             $I+=~~::=?                    $I=~~~::=.            ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("      (1)Pedra                  (2)Papel               (3)Tesoura\nPartidas vencidas: {0}         Score: {1}\nDigite sua escolha: ",k,pontin);
                                    b = int.Parse(Console.ReadLine());
                                }
                                while (b != 1 && b != 2 && b != 3);
                                Console.Clear();

                                if (b == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("          ..+~~7=:.           ");
                                    Console.WriteLine("      ...?~~++~,+~~..         ");
                                    Console.WriteLine("      ?~~+~~+?I=~:~::         ");
                                    Console.WriteLine("     7I~:?~~?+?8?+$::         ");
                                    Console.WriteLine("    .?I=:~=~ZIINOI+~:.        ");
                                    Console.WriteLine("  .?+?7I$7IOZ8I+?~=:.         ");
                                    Console.WriteLine("   .?=~=++?7++~:~:~~~.        ");
                                    Console.WriteLine("   .7=:::~~==~~~:::=..        ");
                                    Console.WriteLine("   .I?~~::==:~~~~~= .         ");
                                    Console.WriteLine("    .7=~::~+==++==.           ");
                                    Console.WriteLine("    .$+==~=+:+==+.            ");
                                    Console.WriteLine("    ..?+==~==~~~.             ");
                                    Console.WriteLine("    ..+=+~~~~~==.             ");
                                    Console.WriteLine("     .=++~~~~=~=.             ");
                                    Console.WriteLine("      ===~:~~~==.             ");
                                    Console.WriteLine("      +=~~~::~~=.             ");
                                }
                                else if (b == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("            ?+=.            ");
                                    Console.WriteLine("       7+?. ?=~   ...         ");
                                    Console.WriteLine("       I=~. 7=~.  7?=.        ");
                                    Console.WriteLine("       I==  I~~. .I==         ");
                                    Console.WriteLine("       7+~. ?~~. .?=~.         ");
                                    Console.WriteLine("  I+.. 7=~..?=~. $+~=          ");
                                    Console.WriteLine("  7+=. $==..?=~. 7?~.          ");
                                    Console.WriteLine("  .+++ Z+==.+~~..?=~.         ");
                                    Console.WriteLine("   I=~..?=~.?==.7+~=.         ");
                                    Console.WriteLine("  ..??=.7=??=~=++=~... II+.   ");
                                    Console.WriteLine("   .I~~.7+=+~~~===~.  $I=~.    ");
                                    Console.WriteLine("   ..?+=+~~=~~+==~=..=I=~      ");
                                    Console.WriteLine("     ?+==~~~==~??==?.77=~.    ");
                                    Console.WriteLine("    .I=:=+~~~=+I+=++.?=~.    ");
                                    Console.WriteLine("    .I+=~~~===??+++=I?=~      ");
                                    Console.WriteLine("   .$?=~~~~==?=+?+?++~~       ");
                                    Console.WriteLine("    .?==~===+I??++=~~~.      ");
                                    Console.WriteLine("    .7?===~=++?++=~::.       ");
                                    Console.WriteLine("    .ZI+=~=~====~~~::        ");
                                    Console.WriteLine("      $?=~~:~~~~~~:,         ");
                                    Console.WriteLine("      $I=~::~~:::=.          ");
                                    Console.WriteLine("      7$?~~::~~~=             ");
                                    Console.WriteLine("      $7?+==::~=.             ");
                                    Console.WriteLine("      Z7===~~~~=.             ");
                                    Console.WriteLine("      ZI+==~::=+              ");
                                    Console.WriteLine("      $I+=~~::=?              ");
                                }
                                else if (b == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("     .?==      ...      ");
                                    Console.WriteLine("    ..?==     .?+.      ");
                                    Console.WriteLine("      7+~..   .?==.     ");
                                    Console.WriteLine("      .+~~   .$+~=      ");
                                    Console.WriteLine("      .+~~.   I=~..     ");
                                    Console.WriteLine("      .7==.  .+~~       ");
                                    Console.WriteLine("      .I=~. .$?~:.      ");
                                    Console.WriteLine("       ~=~+ .+=:=.      ");
                                    Console.WriteLine("    .,I?==+.+?=:         ");
                                    Console.WriteLine("    .??+?==I+?=~        ");
                                    Console.WriteLine("    .7?7~=7$$$~~         ");
                                    Console.WriteLine("   .7??Z+=:==+:~=..       ");
                                    Console.WriteLine("   .I??+8++=~~::~=.       ");
                                    Console.WriteLine("  .$I??=:?=:$7=~:~.        ");
                                    Console.WriteLine("   .?=8?:,~:Z?I::~.        ");
                                    Console.WriteLine("   7+=?7$ZZI?=~:=..       ");
                                    Console.WriteLine("   .,?=~=+77?+=::=.         ");
                                    Console.WriteLine("    .7=~~~+$?=~::=..        ");
                                    Console.WriteLine("     $?==~:++=~~~+.         ");
                                    Console.WriteLine("      7=~:~,+~::~           ");
                                    Console.WriteLine("      $I=~:::~~:=           ");
                                    Console.WriteLine("      I$+~:::~:~=           ");
                                    Console.WriteLine("      7$=~=~:~~~.           ");
                                    Console.WriteLine("      $$~~=~::=~            ");
                                    Console.WriteLine("      Z7~~~~~:=.            ");
                                    Console.WriteLine("      $I=~~~::=.            ");
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Você jogou {0}", escolhaJ[b]);
                                Console.ReadKey();
                                Console.Clear();

                                if (a==1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("                              ");
                                    Console.WriteLine("          ..+~~7=:.           ");
                                    Console.WriteLine("      ...?~~++~,+~~..         ");
                                    Console.WriteLine("      ?~~+~~+?I=~:~::         ");
                                    Console.WriteLine("     7I~:?~~?+?8?+$::         ");
                                    Console.WriteLine("    .?I=:~=~ZIINOI+~:.        ");
                                    Console.WriteLine("  .?+?7I$7IOZ8I+?~=:.         ");
                                    Console.WriteLine("   .?=~=++?7++~:~:~~~.        ");
                                    Console.WriteLine("   .7=:::~~==~~~:::=..        ");
                                    Console.WriteLine("   .I?~~::==:~~~~~= .         ");
                                    Console.WriteLine("    .7=~::~+==++==.           ");
                                    Console.WriteLine("    .$+==~=+:+==+.            ");
                                    Console.WriteLine("    ..?+==~==~~~.             ");
                                    Console.WriteLine("    ..+=+~~~~~==.             ");
                                    Console.WriteLine("     .=++~~~~=~=.             ");
                                    Console.WriteLine("      ===~:~~~==.             ");
                                    Console.WriteLine("      +=~~~::~~=.             ");
                                }
                                else if(a==2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("            ?+=.            ");
                                    Console.WriteLine("       7+?. ?=~   ...         ");
                                    Console.WriteLine("       I=~. 7=~.  7?=.        ");
                                    Console.WriteLine("       I==  I~~. .I==         ");
                                    Console.WriteLine("       7+~. ?~~. .?=~.         ");
                                    Console.WriteLine("  I+.. 7=~..?=~. $+~=          ");
                                    Console.WriteLine("  7+=. $==..?=~. 7?~.          ");
                                    Console.WriteLine("  .+++ Z+==.+~~..?=~.         ");
                                    Console.WriteLine("   I=~..?=~.?==.7+~=.         ");
                                    Console.WriteLine("  ..??=.7=??=~=++=~... II+.   ");
                                    Console.WriteLine("   .I~~.7+=+~~~===~.  $I=~.    ");
                                    Console.WriteLine("   ..?+=+~~=~~+==~=..=I=~      ");
                                    Console.WriteLine("     ?+==~~~==~??==?.77=~.    ");
                                    Console.WriteLine("    .I=:=+~~~=+I+=++.?=~.    ");
                                    Console.WriteLine("    .I+=~~~===??+++=I?=~      ");
                                    Console.WriteLine("   .$?=~~~~==?=+?+?++~~       ");
                                    Console.WriteLine("    .?==~===+I??++=~~~.      ");
                                    Console.WriteLine("    .7?===~=++?++=~::.       ");
                                    Console.WriteLine("    .ZI+=~=~====~~~::        ");
                                    Console.WriteLine("      $?=~~:~~~~~~:,         ");
                                    Console.WriteLine("      $I=~::~~:::=.          ");
                                    Console.WriteLine("      7$?~~::~~~=             ");
                                    Console.WriteLine("      $7?+==::~=.             ");
                                    Console.WriteLine("      Z7===~~~~=.             ");
                                    Console.WriteLine("      ZI+==~::=+              ");
                                    Console.WriteLine("      $I+=~~::=?              ");
                                }
                                else if (a == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("     .?==      ...      ");
                                    Console.WriteLine("    ..?==     .?+.      ");
                                    Console.WriteLine("      7+~..   .?==.     ");
                                    Console.WriteLine("      .+~~   .$+~=      ");
                                    Console.WriteLine("      .+~~.   I=~..     ");
                                    Console.WriteLine("      .7==.  .+~~       ");
                                    Console.WriteLine("      .I=~. .$?~:.      ");
                                    Console.WriteLine("       ~=~+ .+=:=.      ");
                                    Console.WriteLine("    .,I?==+.+?=:         ");
                                    Console.WriteLine("    .??+?==I+?=~        ");
                                    Console.WriteLine("    .7?7~=7$$$~~         ");
                                    Console.WriteLine("   .7??Z+=:==+:~=..       ");
                                    Console.WriteLine("   .I??+8++=~~::~=.       ");
                                    Console.WriteLine("  .$I??=:?=:$7=~:~.        ");
                                    Console.WriteLine("   .?=8?:,~:Z?I::~.        ");
                                    Console.WriteLine("   7+=?7$ZZI?=~:=..       ");
                                    Console.WriteLine("   .,?=~=+77?+=::=.         ");
                                    Console.WriteLine("    .7=~~~+$?=~::=..        ");
                                    Console.WriteLine("     $?==~:++=~~~+.         ");
                                    Console.WriteLine("      7=~:~,+~::~           ");
                                    Console.WriteLine("      $I=~:::~~:=           ");
                                    Console.WriteLine("      I$+~:::~:~=           ");
                                    Console.WriteLine("      7$=~=~:~~~.           ");
                                    Console.WriteLine("      $$~~=~::=~            ");
                                    Console.WriteLine("      Z7~~~~~:=.            ");
                                    Console.WriteLine("      $I=~~~::=.            ");
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Oponente jogou {0}", escolha[a]);

                                if (a == b)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Empate");
                                    pontin += 50;
                                }
                                else if (a == 1 && b == 2 || a == 2 && b == 3 || a == 3 && b == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Você ganhou!");
                                    k++;
                                    pontin += 100;
                                }
                                else if (a == 1 && b == 3 || a == 3 && b == 2 || a == 2 && b == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Você perdeu!");
                                    perdeu = 1;
                                }

                                Console.ReadKey();

                            }
                            while (perdeu == 0);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Pontuação final: {0}", pontin);
                            Console.ReadLine();

                            int aux = 0;
                            string auxn = "";
                            int pos = -1, au = 0;
                            if (pontin >= rankN[4])
                            {
                                rankN[4] = pontin;

                                Console.WriteLine("Parabéns! Você entrou no ranking TOP 5 do Jokenpo!\nDigite seu nome abaixo: \n", pos);
                                rank[4] = Console.ReadLine();

                                for (int ii = 0; ii < rankN.Length; ii++)
                                {
                                    for (int j = 0; j < rankN.Length; j++)
                                    {
                                        if (rankN[ii] > rankN[j])
                                        {
                                            aux = rankN[ii];
                                            auxn = rank[ii];
                                            rankN[ii] = rankN[j];
                                            rankN[j] = aux;
                                            rank[ii] = rank[j];
                                            rank[j] = auxn;
                                            au = ii;
                                            Console.WriteLine();
                                        }
                                    }
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("Ranking:");
                            Console.SetCursorPosition(1, 1);
                            Console.Write("#");
                            Console.SetCursorPosition(5, 1);
                            Console.Write("Nome");
                            Console.SetCursorPosition(20, 1);
                            Console.Write("Score");
                            for (int i = 0; i < 5; i++)
                            {
                                Console.SetCursorPosition(1, i + 2);
                                Console.Write("{0}º", i + 1);
                                Console.SetCursorPosition(5, i + 2);
                                Console.WriteLine("{0}", rank[i], rankN[i]);
                                Console.SetCursorPosition(20, i + 2);
                                Console.WriteLine("{0}", rankN[i]);
                            }
                            Console.WriteLine("\nVitória: 100pts\nEmpate: 50pts\n");
                            Console.WriteLine("\nContinuar jogando?\n(1)Sim  (2)Não");
                            escolhae = int.Parse(Console.ReadLine());
                        }
                        while (escolhae == 1);
                        break;
                    case 3:
                        Console.WriteLine("Ranking:");
                        Console.SetCursorPosition(1, 1);
                        Console.Write("#");
                        Console.SetCursorPosition(5, 1);
                        Console.Write("Nome");
                        Console.SetCursorPosition(20, 1);
                        Console.Write("Score");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.SetCursorPosition(1, i + 2);
                            Console.Write("{0}º", i+1);
                            Console.SetCursorPosition(5, i + 2);
                            Console.WriteLine("{0}", rank[i], rankN[i]);
                            Console.SetCursorPosition(20, i + 2);
                            Console.WriteLine("{0}", rankN[i]);
                        }
                        Console.WriteLine("\nVitória: 100pts\nEmpate: 50pts");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("\n\n\n\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("                                   ,wgg&&&gw,,                                 ");
                        Console.WriteLine("                               ,g$lllllllllllll@w                            ");
                        Console.WriteLine("                             /$llllll&M***M&llllll%,                         ");
                        Console.WriteLine("                           ,$llll$'           `*lllllg                        ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("                           $llll'                Y %%%%");
                        Console.WriteLine("                          $llllF      g$$,                                     ");
                        Console.WriteLine("                          lllll     g$llll$w                                   ");
                        Console.WriteLine("                          lllll     `YllllF                                    ");
                        Console.WriteLine("                          ]llllk       **                                      ");
                        Console.WriteLine("                           %llllg,             ,$llllF                          ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("                            1$$$$$@w,       ,g@$$$$@`                           ");
                        Console.WriteLine("                              %$$$$$$$$@@$$$$$$$$@'                             ");
                        Console.WriteLine("                                *%$$$$$$$$$$$% *");
                        Console.WriteLine("                                     `'''''                                     ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                              CHEKPOINT GAME STUDIO");
                        Console.WriteLine("                                     presents...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("       d8,          d8b                                                   ");
                        Console.WriteLine("      `8P           ?88                                                   ");
                        Console.WriteLine("                     88b                                                  ");
                        Console.WriteLine("      d88   d8888b   888  d88' d8888b  88bd88b ?88,.d88b, d8888b          ");
                        Console.WriteLine("      ?88  d8P' ?88  888bd8P' d8b_,dP  88P' ?8b`?88'  ?88d8P' ?88         ");
                        Console.WriteLine("       88b 88b  d88 d88888b   88b     d88   88P  88b  d8P88b  d88         ");
                        Console.WriteLine("       `88b`?8888P'd88' `?88b,`?888P'd88'   88b  888888P'`?8888P'         ");
                        Console.WriteLine("        )88                                      88P'                     ");
                        Console.WriteLine("       ,88P                                     d88                       ");
                        Console.WriteLine("    `?888P                                      ?8P                       ");
                        Console.WriteLine("         d8b                                                             ");
                        Console.WriteLine("   d8P   ?88                                                             ");
                        Console.WriteLine("d888888P  88b                                                            ");
                        Console.WriteLine("  ?88'    888888b  d8888b         d888b8b   d888b8b    88bd8b,d88b  d8888b");
                        Console.WriteLine("  88P     88P `?8bd8b_,dP        d8P' ?88  d8P' ?88    88P'`?8P'?8bd8b_,dP");
                        Console.WriteLine("  88b    d88   88P88b            88b  ,88b 88b  ,88b  d88  d88  88P88b    ");
                        Console.WriteLine("  `?8b  d88'   88b`?888P'        `?88P'`88b`?88P'`88bd88' d88'  88b`?888P'");
                        Console.WriteLine("                                        )88                               ");
                        Console.WriteLine("                                       ,88P                               ");
                        Console.WriteLine("                                   `?8888P                                ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nDescrição: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Uma forma divertida de jogar jokenpo!!!\n           Jogue contra seu amigo ou contra a máquina neste ÉPICO DESAFIO MILENAR\n           E SEM PRECISAR ESTENDER SUA MÃO!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nDesenvolvido pela");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" Checkpoint Game Studios");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(": Eliel Adrian, Leonardo Trindade, Roger Norio, Thiago Yasue");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nVersão Final 1.0\nData: 22/05/2019");
                        Console.ReadKey();
                        break;
                    default:
                        saida++;
                        break;
                }
            }
            while (saida == 0);
            Console.ReadLine();
        }
            }
}


