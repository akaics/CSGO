namespace CSGO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player(1, "Nuriye", 42, 9, "T");
            Player player2 = new Player(2, "Gülsüm", 18, 9, "CT");


            Console.WriteLine(player1);
            Console.WriteLine(player2);

           

            Weapon weapon1 = new Weapon(1,"AK-47", 90, 25, 2, 1200, "T");
            Weapon weapon2 = new Weapon(2,"M4A1-S", 80, 30, 1, 1100, "CT");

            Console.WriteLine(weapon1);
            Console.WriteLine(weapon2);
        }
    }
}