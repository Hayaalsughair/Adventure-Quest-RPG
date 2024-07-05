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
                Adventure adventure = new Adventure();
                adventure.StartAdventure();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
          
            
            Console.WriteLine("\nFinsh Game!");
        }
    }
}
