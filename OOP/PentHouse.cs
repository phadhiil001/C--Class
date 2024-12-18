public class PentHouse : House
{
    public override int AddNumber(int a, int b)
    {
        return a + b;
    }
}

//  When a parent class has an abstract method the child class must
//  must the implementation 

//  use the override keyword to provide implementation for an abstract
//  method in the child class