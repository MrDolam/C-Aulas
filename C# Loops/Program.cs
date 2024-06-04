internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.Write("How many cool numbers do you want: ");
        int count = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <= count; i++){
            double result = Math.Pow(2, i);
            Console.WriteLine(result);    
        }

        Console.WriteLine("Now roll a dice");

        Random numberGen = new Random();

        int roll = 0;
        int attempts = 0;

        while(roll != 6)
        {
            Console.ReadKey();
            roll = numberGen.Next(1, 7);

            Console.WriteLine("You rolled: " + roll);
            attempts++;

        }
        
        Console.ReadKey();
        
    }
}