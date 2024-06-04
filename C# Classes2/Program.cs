class Wizard
{
    public string name;
    public string favoriteSpell;
    private int spellSlots;
    public float experience;

    public static int Count;
    
    public Wizard(string _name, string _favoriteSpell)
    {
        name = _name;
        favoriteSpell = _favoriteSpell;
        experience = 0f;
        spellSlots = 4;
        Count ++;  

              
    }

    public void CastSpell()
    {
        if(spellSlots > 0){

            Console.WriteLine(name + " casts " + favoriteSpell);
            spellSlots--;
            experience += 0.3f;

        }
        else
        {
            Console.WriteLine("You don't have enough Spell Slots.");
        }
        
    }
    public void Meditate()
    {
        Console.WriteLine(name + " meditates to recover slots.");
        spellSlots = 4;
    }

}
internal class Program
{
    private static void Main(string[] args)
    {
        Wizard wizard1 = new Wizard("Lenard", "Explosive Fart");
        Wizard wizard2 = new Wizard("Jesper", "Charmming Butt");
        Console.WriteLine(Wizard.Count);



        wizard1.CastSpell();
        wizard2.CastSpell();
        wizard1.CastSpell();
        wizard2.CastSpell();
        wizard1.CastSpell();

        Console.WriteLine("Experience: " + wizard1.experience);
        Console.WriteLine("Experience: " + wizard2.experience);

        wizard1.Meditate();

        wizard1.CastSpell();
        wizard2.CastSpell();
        wizard1.CastSpell();
        wizard2.CastSpell();
        wizard1.CastSpell(); 
        Console.WriteLine("Experience: " + wizard1.experience);      
        Console.WriteLine("Experience: " + wizard2.experience);      

        Console.ReadKey();  
    }
}