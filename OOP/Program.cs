//  How to create new class
//  Class defines the attribute and behaviour of an object, 
//  Object is an instance of a class,

//  creating a class
//  Access modifier = public

//  Read Propertiews, Write Properties, Read&Write Properties 


Car toyota = new Car();
Car kia = new Car();
Car audi = new Car();

toyota.model = "Camry";
toyota.yearOfManufacture = 2020;
toyota.color = "Black";
toyota.carType = "Sedan";

kia.model = "Allroader";
kia.yearOfManufacture = 2019;
kia.color = "Purple";
kia.carType = "SUV";


Console.WriteLine(toyota.model);
toyota.Start();

Account gtb = new Account();
gtb.name = "Fadlullah";
gtb.accountNum = 1234567890;
gtb.SetPin(1234);
int pin = gtb.GetPin();

Console.WriteLine(pin);

Animal goat = new Animal();

// goat.Name = "Bele";
// goat.NumOfLegs = 4;
// goat.Color = "white";
// Console.WriteLine(goat.NumOfLegs);

// Creating an object of a class
// ClassName objectName = new ClassName()


//  Abstraction is the hiding of implementation with the use of abstract method
//  Methods without implemetation 
//  base class are always abstract class

// House myHouse = new House();


