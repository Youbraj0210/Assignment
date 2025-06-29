namespace TreasureHunt
{
    internal class Program
    {
        static void Startgame()
        {
            bool win = false;
            int iter = 0;

            Console.WriteLine("Welcome to Treasure Island.\r\nYour mission is to find the treasure.");


            while (win != true)
            {

                switch (iter)
                {
                    case 0:
                        Console.Write("Left or Right: ");
                        break;
                    case 1:
                        Console.Write("Swim or Wait: ");
                        break;
                    case 2:
                        Console.Write("Which door (Red, Yellow or Blue): ");
                        break;
                }


                string movement = Console.ReadLine();

                if (movement == "Left" && iter == 0 || movement == "Wait" && iter == 1 || movement == "Yellow" && iter == 2)
                {
                    iter++;
                }
                else if (iter == 0)
                {
                    Console.WriteLine("Fall into a hole.\r\nGame Over.");
                    return;
                }
                else if (iter == 1)
                {
                    Console.WriteLine("Attacked by trout.\r\nGame Over..");
                    return;
                }
                else if (iter == 2 && movement == "Red")
                {
                    Console.WriteLine("Burned by fire.\r\nGame Over.");
                    return;
                }
                else if (iter == 2 && movement == "Blue")
                {
                    Console.WriteLine("Drowned in Water.\r\nGame Over.");
                    return;
                }


                if (iter == 3)
                {
                    Console.WriteLine("You Win");
                    win = true;
                }
            }
        }
        static void Main(string[] args)
        {
            Startgame();
        }
    }
}
