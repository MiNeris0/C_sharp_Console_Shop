namespace Practice_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good day, friend! Would you like to visit my book shop? (Y / N)");
            string answer = Console.ReadLine();

            if (answer == "Y" || answer == "y" || answer == "Yes" || answer == "yes")
            {
                Starter.Run();
            }
            else
            {
                Console.WriteLine("Good bye and watch your back!");
            }
        }
    }
}