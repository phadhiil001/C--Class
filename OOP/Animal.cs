// Difference between fields and properties

//  Fieild name starts with small letter || camelCase
//  Property name starts with capital letter || PascalCase

public class Animal
{
    // Fields
    public string Name { get; } //read
    // public int NumOfLegs { set; } // set

    private string Color { get; set; } //read&write

    // Behaviours || Method
    public void Eat()
    {
        Console.WriteLine("Eating");
    }


}