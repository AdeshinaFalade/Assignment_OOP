namespace Assignment_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Points Calculator. Select an option");
            Console.WriteLine("(1) Football     (2) Basketball");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {

                Console.WriteLine("Input number of wins:");
                int w = int.Parse(Console.ReadLine());
                Console.WriteLine("Input number of draws:");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("Input number of losses:");
                int l = int.Parse(Console.ReadLine());
                var pro = new League();

                int total = pro.TeamPoint(w, d, l);
                Console.WriteLine("Total points = " + total);
            }
            else if (option == 2)
            {
                Console.WriteLine("Input number of wins:");
                int w = int.Parse(Console.ReadLine());
                Console.WriteLine("Input number of losses:");
                int l = int.Parse(Console.ReadLine());
                var pro = new League();
                float tot = pro.TeamPoint(w, l);
                Console.WriteLine("PCT = " + Math.Round(tot,3));
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
        }



    }
}