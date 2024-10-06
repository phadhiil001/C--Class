//LOOP -- iteration
//for loop
//do loop
//do while
//foreach

//DO LOOP

//A BOOLEAN EXPRESSION
bool result = 3 > 2; //true
// true && true // true
// true && false // false
// false && true // false

// true || false // true
// true || true // true
// false || true // true
// false || false // false

int a = 3;
int b = 5;
int c = 8;
bool expr = a > b && c < a;
bool expr2 = a > b || a < c;


//print natural numbers from 1 to 10
int number = 1;
while (number <= 10)
{
    Console.WriteLine(number);
    number++;
}


//post increment

//for loop
//1. initializer
//2. condition
//3. incrementer

//print 1 to 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}



//print the first 10 odd numbers
// 1, 3, 5, 7, 9, 11, 13, 15, 17, 19
int number = 1;
int count = 1;
while (count <= 10)
{
    Console.WriteLine(number);
    number += 2; // number = number + 2;
    count++;
}

//print the first 5 even numbers

int number = 2;
int count = 1;
do
{
    Console.WriteLine(number);
    number += 2;
    count++;
}
while (count <= 5);


int count = 0;
for (int i = 2; count < 10; i += 2)
{
    Console.WriteLine(i);
    count++;
}