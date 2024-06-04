internal class Program
{
    private static void Main(string[] args)
    {
        MeetAlien();

        Console.WriteLine("--------------");

        MeetAlien();

        Console.WriteLine("--------------");


        int result = Multiply(23, 11);
        Console.WriteLine("Your answer is " + result);

        if (result % 2 == 0){

            Console.WriteLine(result + " is a even number.");
        }
        else{
            Console.WriteLine(result + " is an uneven number.");
        }

        Console.ReadKey();
    }

    static void MeetAlien(){

        Random numberGen = new Random();

        string name = "X-" + numberGen.Next(10, 101);
        int age = numberGen.Next(1, 251);

        Console.WriteLine("Hi, I'm " + name);
        Console.WriteLine("I'm " + age + " year old.");
        Console.WriteLine("Oh, and I'm a alien.");

    }

    static int Multiply (int number1, int number2){

        int result = number1*number2;
        return result;
    }
}