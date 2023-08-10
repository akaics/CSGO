namespace CSGO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player(001, "Nuriye", 42, 9);
            Player player2 = new Player(002, "Gülsüm", 18, 9);


            Console.WriteLine(player1);
            Console.WriteLine(player2);
        }
    }
}