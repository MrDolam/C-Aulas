internal class Program
{
    private static void Main(string[] args)
    {
        double num01;
        double num02;
        double num03;

        Console.Write("Input a number: ");
        num01 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input a second number: ");
        num02 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input a thurd number: ");
        num03 = Convert.ToDouble(Console.ReadLine());

        double mult = num01 + num02 + num03;
        double result = mult / 3;

        Console.WriteLine("The result is: " + result);

        Console.ReadLine();

    }
}