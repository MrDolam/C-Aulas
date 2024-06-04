// See https://aka.ms/new-console-template for more information
using System.Net.Mail;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Qual agente devo pegar?");
        string[] agents = {
          "Omen",
          "Viper",
          "Gekko",
          "Breach"
        };

        for (int i = 0; i < agents.Length; i++)
        {
            Console.WriteLine(agents[i]);
        }
        Console.ReadKey();

        Random agentPick = new Random();

        int roll = 0;
        roll = agentPick.Next(0, 3);

        Console.WriteLine("Pega esse aqui: " + agents[roll]);

        Console.ReadKey();

      List<string> lisdeCom = new List<string>();

      lisdeCom.Add("Pão");
      lisdeCom.Add("Ovo");
      lisdeCom.Add("Banana");
      lisdeCom.Add("Manteiga");

      for (int  n = 0;  n < lisdeCom.Count;  n++)
      {
        Console.WriteLine(lisdeCom[n]);
      }
      Console.ReadKey();
      
    }
}