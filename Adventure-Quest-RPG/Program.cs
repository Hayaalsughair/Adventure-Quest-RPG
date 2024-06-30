namespace Adventure_Quest_RPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Player player1= new Player("Haya");
            //player1.DisplayPlayerInfo();
            //Console.WriteLine("");
            try
            {
                Player newPLayer = new Player("Rex");
                SullivanMonster shalabi = new SullivanMonster();
                BattleSystem.StartStartBattle(newPLayer, shalabi);

            }
            catch (Exception ex) {
                Console.WriteLine(" Error occurred:", ex.Message);
            }

            Console.WriteLine("\nFinsh Game!");

        }
    }
}
