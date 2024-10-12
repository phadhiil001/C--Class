//  A variable can only save and store one value
//  Array allows you to store values of the same datatype
//  It is a collectoin of item to store the same dataytype

//  Array declaration
//  Int [] container = {}; for int
//  Each value has it's own index as position


//  Basics of Array
//  Array is a collection of items to store the same datatype
//  Array is declared with square brackets [] after the datatype
//  Array is declared with the size of the array in the square brackets [] after the datatype
//  Array has a fixed size or length
//  Persist value of the same data type

// How declare array
// int [] numbers = new int[5]; // declare array with size 5
//  [0,0,0,0,0]
//  Indexing in Array: It is the position of each item in the collection and it starts from 0
//  Item in array is accessed through the index




//  

//  Another way of declaring and assigning array
//  int [] numbers2 = new int [] {1,2,3,4,5}; OLD METHOD
// int [] numbers = {1,2,3,4,5};


// int [] number3 = [1,2,3,4,5]; This is the main way of decalring array

//  string [] = ["Ade", "Tolu"];

int[] food = [1, 2, 3, 4, 5];

// Calculate the sum of all items in the array
int sum = 0;

for (int i = 0; i < food.Length; i++)
{
    sum += food[i];
}

// Console.WriteLine(sum);
int sum2 = food.Sum();
// Console.WriteLine(sum2);

//  Find the largest element in the Array using loop
int largest = food[0];
for (int i = 0; i < food.Length; i++)
{
    if (food[i] > largest)
    {
        largest = food[i];
    }
}

int maxNum = food.Max();
int mixNum = food.Min();
double avgNum = food.Average();
// Console.WriteLine(largest);
// Console.WriteLine(maxNum);
// Console.WriteLine(mixNum);
// Console.WriteLine(avgNum);



// Print in reverse order
// for (int i = food.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(food[i]);
// }

// Array.Reverse(food);
// // This handles to change the order of the array
// for (int i = 0; i < food.Length; i++)
// {
//     Console.WriteLine(food[i]);
// }

// Print in order
// int[] goodies = [1, 10, 7, 4, 6];

// Array.Sort(goodies);
// for (int i = 0; i < goodies.Length; i++)
// {

//     Console.WriteLine(goodies[i]);
// }



// Exercises ---
// Counting Even and Odd Numbers in an Array
// int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// int even = 0;
// int odd = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     {
//         even++;
//     }
//     else
//     {
//         odd++;
//     }
// }

// Console.WriteLine(even);
// Console.WriteLine(odd);

// Finding a Specific Element in an Array target is 30
int[] numbers = { 10, 20, 30, 40, 50 };