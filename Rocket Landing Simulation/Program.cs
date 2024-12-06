namespace Rocket_Landing_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rocket = "       /^\\\r\n      |   |\r\n      |   |\r\n     /|:|:|\\\r\n    /||::||\\\r\n   /::|::|::\\\r\n  /:::|::|:::\\  \r\n /::::|::|::::\\  \r\n/::::/   \\:::::\\\r\n|____|     |____|\r\n";
            
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                rocket = "\r\n" + rocket;
                Console.WriteLine(rocket);
                Thread.Sleep(1000);
            }
            Console.WriteLine("The rocket Landed");

            /* Not the most effective way to do the task
            for (int i = 0; i < 10; i++) { 
                Console.Clear();
                for (int j = 0; j < i; j++) {
                    Console.WriteLine("\r\n");
                }
                Console.WriteLine(rocket);
                Thread.Sleep(1000);
            }
            Console.WriteLine("The rocket Landed");
            */

        }
    }
}
