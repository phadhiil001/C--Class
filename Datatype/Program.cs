// // command to create new dotnet project
// // dotnet new console -o DATATYPE

// //Variables are values that can change at run time
// //variable is container to store value or data

// //Variable declaration
// //1. specify the data type
// // 2. a name must be given to the variable
// //3. a variable can not be declared more than once
// // an assignment operator (=) is used to assign value to a variable

// string myName; // declaration
// myName = "john"; // assigning a value to the variable
// myName = "Paul";
// string mySchool = "something"; // declaration and assignment
// Console.WriteLine(myName);

// int myAge = 5;
// char letter = 'A';
// // float width = 9.5f;
// // double height = 78.6;
// // decimal length = 67.5m;

// bool isMale = true;



// //DATA ARE VALUES
// //string
// //int, long, short, uint
// //floating type -- float, double, decimal
// //char
// //boolean

// //Literals are hard coded values
// Console.WriteLine(" I am a boy");
// Console.WriteLine(1);
// Console.WriteLine(-20);
// Console.WriteLine("3");
// Console.WriteLine(3.1f); //float literals
// Console.WriteLine(6.5F);
// Console.WriteLine(6F);
// Console.WriteLine(3.4d); //double literal
// Console.WriteLine(5.6D);
// Console.WriteLine(4.6);
// Console.WriteLine(3.6m);
// Console.WriteLine(6.4M);

// //"School"
// Console.WriteLine('S');
// Console.WriteLine("S");

// //boolean literals
// Console.WriteLine(true);
// Console.WriteLine(false);
// Console.WriteLine("true");

// Console.WriteLine("Enter your age");

// //explicit casting or conversion
// int age = int.Parse(Console.ReadLine());
// int age2 = Convert.ToInt32(Console.ReadLine());
// double width = double.Parse(Console.ReadLine());
// double width2 = Convert.ToDouble(Console.ReadKey());
// float height = float.Parse(Console.ReadLine());
// decimal length = decimal.Parse(Console.ReadLine());
// char l = char.Parse(Console.ReadLine());
// bool answer = bool.Parse(Console.ReadLine());



// Activities

// 1. Write a C# program that declares and initializes variables of different data types.
int me = 20;

// 2. Write a C# program that prints "Hello, World!" to the console.
Console.WriteLine("Hello, World!");

// 3. Modify the "Hello, World!" program to print "Hello, [Your Name]!" instead.
string name2 = "Fadlullah";
Console.WriteLine("Hello, " + name2 + "!");

// 4. Write a C# program that declares an integer variable, assigns it a value, and prints the value to the console.
int age;
age = 20;
Console.WriteLine(age);

// 5. Write a program that declares a string variable, assigns your full name to it, and prints it.
string fullName;
fullName = "Fadlullah Jamiu-Imam";
Console.WriteLine(fullName);

// 6. Create a program that declares a double variable for the price of an item, assigns it a value, and prints the price.
double price;
price = 10.99;
Console.WriteLine(price);

// 7. Write a C# program that prints "Good Morning!" to the console.
Console.WriteLine("Good Morning!");

// 8. Modify the program to print "Good Evening!" instead.
Console.WriteLine("Good Evening!");

// 9. Write a C# program that declares a char variable, assigns it a value, and prints the value to the console.
char letter;
letter = 'A';
Console.WriteLine(letter);

// 10. Create a program that declares a bool variable, assigns it a value, and prints the value.
bool isTrue;
isTrue = true;
Console.WriteLine(isTrue);

// 11. Write a program that declares a float variable for a temperature in Celsius, assigns it a value, and prints the temperature.
float temperature;
temperature = 25.0f;
Console.WriteLine(temperature);

// 12. Create a program that declares a decimal variable for a bank balance, assigns it a value, and prints the balance.
decimal balance;
balance = 23500.2345m;
Console.WriteLine(balance);

// 13. Write a program that declares a constant integer for the number of days in a week, assigns it the value 7, and prints it.
const int daysInWeek = 7;
Console.WriteLine(daysInWeek);

// 14. Create a program that declares a constant string for your favorite quote and prints it.
const string favoriteQuote = "Believe you can and you're halfway there.";
Console.WriteLine(favoriteQuote);

// 15. Write a C# program that prints a message containing a newline character.
Console.WriteLine("Hello,\nWorld!");

// 16. Create a program that prints a message containing a tab character.
Console.WriteLine("Hello,\tWorld!");

// 17. Write a C# program that prints a floating-point number with two decimal places.
Console.WriteLine("The answer is 3.14");

// 18. Write a program that declares a variable for the current day of the week and prints a message including the day.
string currentDay = "Monday";
Console.WriteLine($"Today is {currentDay}.");

// 19. Create a program that declares a variable for your favorite color and prints a message including the color.
string favoriteColor = "Blue";
Console.WriteLine($"My favorite color is {favoriteColor}.");

// 20. Write a C# program that declares an integer variable for the number of items you have and prints "You have [number] items.".
int items = 5;
Console.WriteLine($"You have {items} items.");

// 21. Create a program that declares a string variable for your hometown and prints "I am from [hometown].".
string hometown = "Iyamoye";
Console.WriteLine($"I am from {hometown}");

// 22. Write a program that declares a variable of each basic data type (int, string, char, bool, double, float, decimal) and prints each one.
int myInt = 10;
string food = "Jollof rice";
bool isHuman = true;
char first = 'A';
double myDouble = 10.5;
float myFloat = 10.5f;
decimal myDecimal = 10.5m;
Console.WriteLine($"Int: {myInt}, String: {food}, Char: {first}, Bool: {isHuman}, Float: {myFloat}, Decimal: {myDecimal}, Double: {myDouble} ");

// 23. Create a program that declares variables for your first name, last name, age, and height, and prints a formatted string introducing yourself.
string firstName = "Abdulrahman";
string lastName = "Yusuf";
int age2 = 20;
decimal height = 1.75m;
Console.WriteLine($"Hello, my name is {firstName} {lastName}, I am {age2} years old and {height} tall");

// 24. Write a C# program that declares an integer variable for your age and prints "I am [age] years old."
int age3 = 20;
Console.WriteLine($"I am {age3} years old");

// 25. Create a program that declares a double variable for your height in meters and prints "My height is [height] meters.".
double height2 = 1.75;
Console.WriteLine($"My height is {height2} meters");

// 26. Write a program that declares a string variable with your favorite hobby and prints "My favorite hobby is [hobby].".
string hobby = "Playing football";
Console.WriteLine($"My favorite hobby is {hobby}");

// 27. Create a program that declares two string variables, one for your first name and one for your last name, and prints "Your full name is [first name] [last name].".
string firstName2 = "Abdulrahman";
string lastName2 = "Yusuf";
Console.WriteLine($"Your full name is {firstName2} {lastName2}");

// 28. Write a C# program that declares an integer variable for the current year, assigns it the current year, and prints "The current year is [year].".
int currentYear = DateTime.Now.Year;
Console.WriteLine($"The current year is {currentYear}");

// 29. Write a program that declares a string variable for a product name, an integer variable for the quantity, and a double variable for the price. Print "You have [quantity] units of [product name] priced at $[price] each.".
string productName = "Apple";
int quantity = 5;
double price2 = 10.5;
Console.WriteLine($"You have {quantity} units of {productName} priced at ${price2} each");

// 30. Write a C# program that declares a boolean variable indicating whether you have completed a task. Print "Task completed: [true/false]." based on the value of the boolean variable
bool taskCompleted = true;
Console.WriteLine($"Task completed: {taskCompleted}");
