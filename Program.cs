// See https://aka.ms/new-console-template for more information

/*

Assignment 1:
Create a program that genrates a random number between 0 - 20, 
if the user does not guess the number correctly, give the user a range to which the number falls, 
keep count of the times the user tries the count and output it after the user has finally gotten the correct answer.

*/

/*
Random rand = new Random();
int guessNumber = rand.Next(0, 21);

int count = 0;
bool correct = true;

while (correct)
{
    Console.Write("Guess the number: ");
    string guess = Console.ReadLine();
    int guessed;
    guessed = Convert.ToInt32(guess);

    count++;
    if (guessNumber > guessed)
    {
        Console.WriteLine("The number is greater than your guess");
    }
    else if (guessNumber < guessed)
    {
        Console.WriteLine("The number is less than guess");
    }
    else
    {
        Console.WriteLine("You guessed right");
        correct = false;
    }
}
*/
/*
    if (guessed != guessNumber)
    {

        if (guessNumber > 15)
        {
            Console.WriteLine("The number is greater than 15");
        }
        else if (guessNumber >= 7 && guessNumber <= 15)
        {
            Console.WriteLine("The number is between 7 and 15");
        }
        else if (guessNumber >= 0 && guessNumber <= 7)
        {
            Console.WriteLine("The number is between 0 and 7");
        }

    }
    else if (guessed == guessNumber)
    {
        Console.WriteLine($"You tried {count} times to guess the right number!");
        correct = false;
    }
    else
    {
        Console.WriteLine("Try again");
    }

}
*/


// First Class
/*

bool a = true;
int count = 0;
while (a)
{
    Console.WriteLine("Enter your Name: ");
    string name = Console.ReadLine();
    count++;

    if (name == "John")
    {
        Console.WriteLine("Correct");
        a = false;
    }
    else
    {
        Console.WriteLine("Wrong!!");
    }
}

Console.WriteLine($"You tried { count } times.");


Console.WriteLine("Enter your Address: ");
Console.ReadLine();


for (int i = 1; i < 13; i++) {
    Console.WriteLine($"2 * {i} = {2 * i}");
    int k = 4;
}

int j = 1;
while (j < 13) {
    Console.WriteLine($"3 * {j} = {3 * j}");
    j++;
    int k = 5;
}

*/


// Second class
/*
int age = 20;
string name = "John";


if(age > 20 && name == "John"){
    Console.WriteLine("");
}

if ((age > 20 || name == "Musa") && (name == "John")) {
    Console.WriteLine("");
}

*/



//---- Question 1: Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.

/*
Console.WriteLine("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());
*/


//Swapping technique

/*
if (firstNumber > secondNumber)
{
    // Collect the value of the first number 
    int temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;    
}

Console.WriteLine($"The first number is {firstNumber}.");
Console.WriteLine($"The second number is {secondNumber}.");

*/


/*

//---- Question 3: Write a program that finds the biggest of three integers, using nested if statements.

Console.WriteLine("Enter the first number: ");
int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNum = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int thirdNum = int.Parse(Console.ReadLine());

int highestNum = firstNum;

if (secondNum > highestNum)
{
    highestNum = secondNum;

    if (thirdNum > secondNum)
    {
        highestNum = thirdNum;
    }
}

Console.WriteLine($"The highest number is {highestNum}");
*/


/*
//---- Question 4: Sort 3 real numbers in descending order. Use nested if statements.

Console.WriteLine("Enter the first number: ");
int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNum = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int thirdNum = int.Parse(Console.ReadLine());

int lowest = firstNum, middle = secondNum, highest = thirdNum;

if ((firstNum < secondNum) && (firstNum < thirdNum))
{
    lowest = firstNum;

    if (secondNum < thirdNum)
    {
        middle = secondNum;
        highest = thirdNum;
    }

    else
    {
        highest = secondNum;
        middle = thirdNum;
    }

}
else if ((firstNum > secondNum) && (firstNum > thirdNum))
{
    highest = firstNum;

    if (secondNum > thirdNum)
    {
        middle = secondNum;
        lowest = thirdNum;
    }

    else
    {
        middle = thirdNum;
        lowest = secondNum;
    }
}
else if ((secondNum > firstNum) && (secondNum > thirdNum))
{
    highest = secondNum;

    if (firstNum > thirdNum)
    {
        middle = firstNum;
        lowest = thirdNum;
    }
    else
    {
        middle = thirdNum;
        lowest = firstNum;
    }
}
else if ((thirdNum > firstNum) && (thirdNum > secondNum))
{
    highest = thirdNum;

    if (firstNum > secondNum)
    {
        middle = firstNum;
        lowest = secondNum;
    }
    else
    {
        middle = secondNum;
        lowest = firstNum;
    }
}

Console.WriteLine($"The lowest number is {lowest}");
Console.WriteLine($"The middle number is {middle}");
Console.WriteLine($"The highest number is {highest}");

*/


//--- Question 2: Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators. 
/*
int count = 0;

Console.WriteLine("Enter the first number: ");
int number1 = int.Parse(Console.ReadLine());
if (number1 < 0)
{
    count++;
}
Console.WriteLine("Enter the second number: ");
int number2 = int.Parse(Console.ReadLine());
if (number2 < 0)
{
    count++;
}
Console.WriteLine("Enter the third number: ");
int number3 = int.Parse(Console.ReadLine());
if (number3 < 0)
{
    count++;
}

if (count % 2 != 0)
{
    Console.WriteLine("-");
}
else
{
    Console.WriteLine("+");
}
*/

//--- Question 5: Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.

/*
Console.Write("Enter a digit (0 - 9): ");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case 0:
        Console.WriteLine("ZERO");
        break;
    case 1:
        Console.WriteLine("ONE");
        break;
    case 2:
        Console.WriteLine("TWO");
        break;
    case 3:
        Console.WriteLine("THREE");
        break;
    case 4:
        Console.WriteLine("FOUR");
        break;
    case 5:
        Console.WriteLine("FIVE");
        break;
    case 6:
        Console.WriteLine("SIX");
        break;
    case 7:
        Console.WriteLine("SEVEN");
        break;
    case 8:
        Console.WriteLine("EIGHT");
        break;
    case 9:
        Console.WriteLine("NINE");
        break;
    default:
        Console.WriteLine("Sorry does not fall within range!");
        break;
}
*/


//--- Question 6:  Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.


//--- Question 7:  Write a program that finds the greatest of given 5 numbers.

/*
Console.WriteLine("Enter the first number: ");
int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNum = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int thirdNum = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the fourth number: ");
int fourthNum = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the fifth number: ");
int fifthNum = int.Parse(Console.ReadLine());

int highest = firstNum;

if (secondNum > highest)
{
    highest = secondNum;
}
if (thirdNum > highest)
{
    highest = thirdNum;
}
if (fourthNum > highest)
{
    highest = fourthNum;
}
if (fifthNum > highest)
{
    highest = fifthNum;
}

Console.WriteLine("The greatest number is {0}", highest);
*/


//--- Question 8: Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement.
/*
Console.Write("Please enter your name: ");

string user = Console.ReadLine() + "*";
int num = Console.ReadLine();
double deci;

switch (Console.ReadLine())
{
    case user:
    Console.WriteLine(user);
    break;
}

*/
//--- Question 9: 
/*  
We are given 5 integer numbers. Write a program that finds those 
subsets whose sum is 0. Examples:
    - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 
    is 0.
    - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets 
    with sum 0.
*/


//--- Question 10: 
/*
Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
- If the score is between 1 and 3, the program multiplies it by 10.
- If the score is between 4 and 6, the program multiplies it by 100.
- If the score is between 7 and 9, the program multiplies it by 1000.
- If the score is 0 or more than 9, the program prints an error 
message.
*/


//--- Question 11:
/*
Write a program that converts a number in the range [0…999] to 
words, corresponding to the English pronunciation. Examples:
- 0 --> "Zero"
- 12 --> "Twelve"
- 98 --> "Ninety eight"
- 273 --> "Two hundred seventy three"
- 400 --> "Four hundred"
- 501 --> "Five hundred and one"
- 711 --> "Seven hundred and eleven"
*/



// Class three

// Question 1--- 
/*
 Write a program that prints on the console the numbers from 1 to N. 
The number N should be read from the standard input. */
/*
Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write($"{i} ");
}
*/

// Question 2 --- 
/*
 Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.
*/

/*
Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i < num; i++)
{
    if (i % 3 != 0 || i % 7 != 0)
    {
        Console.WriteLine(i);
    }
}
*/

//  Question 3 --- 
/*
Write a program that reads from the console a series of integers and prints the smallest and largest of them.
*/
/*
Console.WriteLine("How many numbers do you want to input");
int numbers = int.Parse(Console.ReadLine());
int smallest = int.MaxValue;
int highest = int.MinValue;
string small = "";
string high = "";

for (int i = 1; i <= numbers; i++)
{
    Console.WriteLine($"Enter student {i}");
    string name = Console.ReadLine();

    Console.WriteLine($"Enter {name}'s score: ");
    int num = int.Parse(Console.ReadLine());

    if (num < smallest)
    {
        smallest = num;
        small = name;
    }
    if (num > highest)
    {
        highest = num;
        high = name;
    }
}

Console.WriteLine($"{small} has the least score with  {smallest}");
Console.WriteLine($"{high} has the highest score with {highest}");

*/


// Question 5 -- 
/*
 Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377,
*/
/*
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
int first = 0, second = 1, next = first + second;
int sum = first + second + next;

for (int i = 3; i <= number; i++)
{
    first = second;
    second = next;
    next = first + second;
    Console.Write($"{next}, ");

    sum += next;
}
Console.WriteLine();
Console.WriteLine(sum);

*/

//  Question 6 -- 
/* Write a program that calculates N!/K! for given N and K (1<K<N).
*/

/*
Console.WriteLine("Enter N:");
int n = int.Parse(Console.ReadLine());


Console.WriteLine("Enter K:");
int k = int.Parse(Console.ReadLine());

int nfact = 1, kfact = 1;

for (int i = 1; i <= n; i++)
{
    nfact *= i;
}
for (int i = 1; i <= k; i++)
{
    kfact *= i;
}

Console.WriteLine($"{nfact / kfact} is the factorial");
*/