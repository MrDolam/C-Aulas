Console.Title = "Skynet";
Console.ForegroundColor = ConsoleColor.Blue;
Console.WindowHeight = 20;


Console.WriteLine("Hello, waht's your name?");
string userName = Console.ReadLine();

Console.WriteLine("Hello " + userName + " nice to meet you.");
Console.WriteLine("My name is T-2000! \nYour personal Code helper.");
Console.WriteLine("What's your favorite color?");

string color;
color = Convert.ToString(Console.ReadLine());
if(color == "Blue"){
    Console.WriteLine("As i thought.");
}
else{
Console.WriteLine("Cool! But i think blue fits you better.");
}


Console.ReadKey();
