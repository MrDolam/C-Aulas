internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Tickets are 5$. Please insert cash.");

        int cash = Convert.ToInt32(Console.ReadLine());

        if(cash < 5){
            Console.WriteLine("That's not enough money.");
        }
        else if(cash == 5){
            Console.WriteLine("here is your ticket.");
        }
        else {
            int change = cash - 5;
            Console.WriteLine("here is your ticket and " + change + " dolllar in change.");
        }

        Console.ReadLine();

    }
}