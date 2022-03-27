using System;

namespace MyTestOfRandoms
{
    class Program
    {
        private Random random;

        private Program()
        {
            random = new Random();
        }
        
        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            program.Run();
        }

        private void Run()
        {
            int n = 0;
            int sum = 0;
            int dice = 0;
            Console.WriteLine("Insert the numbers of dices");
            int dices = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < dices; i++)
            {
                n++;
                Console.WriteLine( $"dice nº{n} = { dice = random.Next(1,7)}");
                
                Console.WriteLine($"sum = {sum = sum + dice }");
            }
        }
    }
}
