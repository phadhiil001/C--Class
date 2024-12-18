using System.Dynamic;

public abstract class House
{
    public string Name { get; set; } 
    public void Rent()
    {
        Console.WriteLine("Renting a house!");
    }

    public abstract int AddNumber(int a, int b);
}

//  Concrete method has both the signature of a method
//  and implememntation

// Abstract class is a method without implementation (only signature)
//  You can only have an abstract method in an abstract class
//  Abstract class can have both concrete method and and abstract
//  method As shown above

//  A child inherits every behaviour of the parent class, but 
