using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Adventure_Quest_RPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine("This text is white on a red background.");

            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t   ############         ###########          ############# ");
            Console.WriteLine("\t\t   ## ##########        ## #########        ###############     ");
            Console.WriteLine("\t\t   ##          ##       ##         ##      ##   ");
            Console.WriteLine("\t\t   ##           ##      ##          ##     ##     ");
            Console.WriteLine("\t\t   ##           ##      ##           ##    ##  ");
            Console.WriteLine("\t\t   ##          ##       ##          ##     ##     ");
            Console.WriteLine("\t\t   ##         ##        ##         ##      ##   ");
            Console.WriteLine("\t\t   ############         ## #########       ##         ######");
            Console.WriteLine("\t\t   ############         ###########        ##         ######");
            Console.WriteLine("\t\t   ##       ##          ##                 ##          ## ");
            Console.WriteLine("\t\t   ##        ##         ##                 ##          ## ");
            Console.WriteLine("\t\t   ##         ##        ##                 ##          ##");
            Console.WriteLine("\t\t   ##          ##       ##                 ##          ##");
            Console.WriteLine("\t\t   ##           ##      ##                  ############");
            Console.WriteLine("\t\t   ##            ##     ##                   ##########");

            Console.WriteLine("\n\nWelcome to the RPG game!\n");
            

            try
                {
                
                Player newPLayer = new Player("shalaby ",60);
                SullivanMonster shalabi = new SullivanMonster();
                BattleSystem.StartStartBattle(newPLayer, shalabi);
                   

                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Error occurred:", ex.Message);
                }

            
          
            
            Console.WriteLine("\nFinsh Game!");
        }
    }
}
