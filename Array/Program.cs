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

// //  string [] = ["Ade", "Tolu"];

// int[] food = [1, 2, 3, 4, 5];

// // Calculate the sum of all items in the array
// int sum = 0;

// for (int i = 0; i < food.Length; i++)
// {
//     sum += food[i];
// }

// // Console.WriteLine(sum);
// int sum2 = food.Sum();
// // Console.WriteLine(sum2);

// //  Find the largest element in the Array using loop
// int largest = food[0];
// for (int i = 0; i < food.Length; i++)
// {
//     if (food[i] > largest)
//     {
//         largest = food[i];
//     }
// }

// int maxNum = food.Max();
// int mixNum = food.Min();
// double avgNum = food.Average();
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
/*
// Counting Even and Odd Numbers in an Array
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int even = 0;
int odd = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        even++;
    }
    else
    {
        odd++;
    }
}
Console.WriteLine(even);
Console.WriteLine(odd);
*/

/*
// Finding a Specific Element in an Array target is 30
int num = 0;
int[] numbers = { 10, 20, 30, 40, 50 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 30)
    {
        num += numbers[i];
    }
}
Console.WriteLine(num);
*/

/*
// Removing an Element from an Array
int[] numbers = { 1, 2, 3, 4, 5 }; // remove 2
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 2)
    {
        numbers[i] = 0;
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
*/


/*
// Sort the array in ascending order.
int[] numbers = { 3, 1, 4, 5, 2 };
Array.Sort(numbers);
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);

}
*/


/*
// Find the second largest element in an array.
int secondLargest = 0;
int largest = 0;
int[] numbers = { 5, 1, 4, 2, 3 };

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > largest)
    {
        secondLargest = largest;
        largest = numbers[i];
    }
    else if (numbers[i] > secondLargest && numbers[i] != largest)
    {
        secondLargest = numbers[i];
    }
}
Console.WriteLine(secondLargest);
int[] numbers = { 5, 1, 4, 2, 3 };
Array.Sort(numbers);
Array.Reverse(numbers);
int secondLargest = numbers[1];
Console.WriteLine(secondLargest);
*/

/*
// Multiply all elements of an array by a scalar.
int[] numbers = { 1, 2, 3, 4, 5 };
int scalar = 3;

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i] * scalar);
}
*/


/*
// Find the product of all elements in an array.
int[] numbers = { 1, 2, 3, 4, 5 };
int product = 1;

for (int i = 0; i < numbers.Length; i++)
{
    product *= numbers[i];
}
Console.WriteLine(product);

*/


// Print all prime numbers in an array.
// int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] >= 2 && numbers[i] % 2 != 0)
//     {
//         Console.WriteLine(numbers[i]);
//     }

// }


/*
// Find the sum of all even elements in an array.
int[] numbers = { 1, 2, 3, 4, 5, 6 };
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        sum += numbers[i];
    }
}
Console.WriteLine(sum);
*/

/*
// Sort the array in descending order.
int[] numbers = { 3, 1, 4, 5, 2 };
Array.Sort(numbers);
Array.Reverse(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);

}
*/

/*
// Find the second smallest element in an array.
int[] numbers = { 5, 1, 4, 2, 3 };

Array.Sort(numbers);
int secondSmallest = numbers[1];
Console.WriteLine(secondSmallest);
*/


/*
// Create an array of 20 elements and initialize them with the index multiplied by 5:
int[] numbers = new int[20];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i * 5;
    Console.WriteLine(numbers[i]);
}
*/


// 0(COL) // 1 2 3 // (0 1 2 - ROW)
// 1 // 4 5 6 // 0 1 2

// Multi-dimensional array has row and col
// Col comes first before row (col, row)

// 1 is position (0, 0)
// 2 is position ()

// 2D Multi-dimensional array
// int[,] matrix = {
//     {1, 2, 3,},
//     {4, 5, 6,}
// };

// Q: Write a program to print all elements of a 2D array.
// //  1st array loops thru the row
/*
for (int i = 0; i < matrix.GetLength(0); i++)
{
    // 2nd array loops thru the col
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}
*/


//  3D Mulit-dimensional array
// int[,,] matrix = {
//     {
//         {1, 2, 3},
//         {4, 5, 6}
//     },
//     {
//         {7, 8, 9},
//         {10, 11, 12}
//     }
// };

// Question 3: Print All Elements
// Console.Write(matrix[0,0,0]);

/*
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Console.Write(matrix[i, j, k]);
        }
        Console.WriteLine();
    }
}
*/

// Question 4: Sum of All Elements
// Q: Calculate the sum of all elements in the 2D array.
/*
int[,] matrix = {
    {1, 2, 3,},
    {4, 5, 6,}
};

int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
}

Console.Write(sum);

*/
/*
int[,,] matrix = {
    {
        {1, 2, 3},
        {4, 5, 6}
    },
    {
        {7, 8, 9},
        {10, 11, 12}
    }
};

int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            sum += matrix[i, j, k];
        }
    }
}
Console.Write(sum);
*/


// Question 5: Find the Maximum Element
// Q: Find the maximum element in the 2D array.
/*
int[,] matrix = {
    {4, 5, 6},
    {7, 8, 9}
};

int maxNum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] > maxNum)
        {
            maxNum = matrix[i, j];
        }
    }
}
Console.Write(maxNum);
*/

// Question 6: Find the Minimum Element
// Q: Find the minimum element in the 2D array.
/*
int[,] matrix = {
    {7, 8, 9},
    {4, 5, 6}
};

int minNum = matrix[0, 0];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < minNum)
        {
            minNum = matrix[i, j];
        }
    }
}
Console.Write(minNum);
*/

// Question 8: Row Sum
// Q: Calculate the sum of each row and print the results.
/*
int[,] matrix = {
    {7, 8, 9},
    {4, 5, 6}
};


for (int i = 0; i < matrix.GetLength(0); i++)
{
    int rowSum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        rowSum += matrix[i, j];
    }
    Console.WriteLine(rowSum);
}
*/


// Question 9: Column Sum
// Q: Calculate the sum of each column and print the results.
/*
int[,] matrix = {
    {7, 8, 9},
    {4, 5, 6}
};


for (int i = 0; i < matrix.GetLength(1); i++)
{
    int colSum = 0;

    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        colSum += matrix[j, i];
    }
    Console.WriteLine(colSum);
}
*/
/*
int[,,] matrix = {
    {
        {1, 2, 3},
        {4, 5, 6}
    },
    {
        {7, 8, 9},
        {10, 11, 12}
    }
};

for (int i = 0; i < matrix.GetLength(2); i++)
{
    int colSum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            colSum += matrix[k, j, i];
        }
    }

    Console.WriteLine(colSum);
}
*/

// Question 10: Find Element's Position
// Q: Write a program to find the position of an element (e.g., 6) in the array.

/*
int[,] matrix = {
    {4, 5, 6},
    {7, 8, 9}
};

int target = 6;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == target)
        {
            Console.WriteLine($"The position is Row:{i}, Column:{j}");
            return;
        }
    }
}
*/

// Question 11: Reverse Rows
// Q: Reverse the elements in each row of the array.
/*
int[,] matrix = {
    {4, 5, 6, 2},
    {7, 8, 9, 1}
};


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[i, j];
        // 4 
        // 5
        // 5
        // 4
        matrix[i, j] = matrix[i, matrix.GetLength(1) - j - 1]; // matrix[0, 4 - 0 - 1] // [0,3] = 2
                                                                // matrix[0, 4 - 1 - 1] // [0, 2] = 6
                                                                // matrix[0, 4 - 2 -1] // [0, 1] = 6
                                                                // matrix[0, 4 - 3 - 1] // [0, 0] = 2
        // [2, 5, 6, 2] // new array
        // [2, 6, 6, 4] // new array
        // [2, 6, 6, 4] // new array
        // [2, 5, 6, 2] // new array
        matrix[i, matrix.GetLength(1) - j - 1] = temp;
        // [2, 5, 6, 4]
        // [2, 6, 5, 4]
        // [2, 5, 6, 4]
        // [4, 5, 6, 2]
    }
}


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}
*/

// Question 13: Find the Average
// Q: Calculate the average of all elements in the array.
/*
int[,] matrix = {
    {4, 5, 6},
    {7, 8, 9}
};

int sum = 0;
int count = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
        count++;
    }

}

double average = (double)sum / count;
Console.WriteLine($"The average of the array is: {average}");
*/

// Question 14: Count Even and Odd Numbers
// Q: Count how many even and odd numbers are in the array.
/*
int[,] matrix = {
    {4, 5, 6},
    {7, 7, 9}
};

int even = 0;
int odd = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] % 2 == 0)
        {
            even++;
        }
        else
        {
            odd++;
        }
    }
}

Console.WriteLine($"The number od even elementa are {even}, and odd are {odd}");
*/

// Question 17: Count the Number of Specific Elements
// Q: Count how many times the element 4 appears in the array

/*
int[,] matrix = {
    {4, 5, 6},
    {7, 8, 4}
};

int target = 4;
int count = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == target)
        {
            count++;
        }
    }
}

Console.WriteLine($"Count of 4 = {count}");
*/

// Question 18: Create a Multiplication Table
// Q: Create a 2D array that represents a multiplication table (1-10).

/*
int[,] table = new int[10, 10];

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        table[i, j] = (i + 1) * (j + 1);
    }
}

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        Console.Write(table[i, j]);
    }
    Console.WriteLine();
}

*/

// Question 20: Replace Negative Numbers
// Q: Replace all negative numbers in the array with zero.
/*
int[,] matrix = {
    {-2, 5, -6},
    {7, -1, 4}
};

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < 0)
        {
            matrix[i, j] = 0;
        }
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();

}
*/

// Question 22: Find the Row with Maximum Sum
// Q: Find the row that has the maximum sum

/*
int[,] matrix = {
    {4, 5, 6},
    {7, 8, 4}
};

// int maxRowIndex = 0;
int maxSum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int rowSum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        rowSum += matrix[i, j];
    }

    if (rowSum > maxSum)
    {
        maxSum = rowSum;
        // maxRowIndex = i;
    }

}
Console.WriteLine(maxSum);

*/



// Question 23: Flatten the 2D Array
// Q: Flatten the 2D array into a 1D array.
/*
int[,] matrix = {
    {4, 5, 6},
    {7, 8, 4}
};

int[] flatArray = new int[matrix.Length];
int index = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        flatArray[index++] = matrix[i, j];
    }
}

for (int i = 0; i < flatArray.Length; i++)
{
    Console.Write(flatArray[i] + " ");
}
*/


// Question 25: Check for Zero Row
// Q: Check if any row in the array contains only zeros.
// A: Yes, we can do this by iterating over each row and checking if all elements in
//    that row are zero.
// If all element in the row is zero
/*
int[,] matrix = {
    {4, 5, 6},
    {7, 8, 4},
    {0, 0, 0}
};

bool hasZeroRow = false;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    bool isZeroRow = true;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] != 0)
        {
            isZeroRow = false;
            break;
        }
    }
    if (isZeroRow)
    {
        hasZeroRow = true;
        break;
    }
}
Console.WriteLine(hasZeroRow);
*/


// Question 26: Column-wise Maximum
// Q: Find the maximum element in each column.
// DONE ABOVE


// Question 33: Find Min and Max
// Q: Find the minimum and maximum values in the array.

/*
int[,] matrix = {
    {4, 5, 2},
    {7, 1, 4}
};

int minVal = matrix[0, 0];
int maxVal = matrix[0, 0];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < minVal)
        {
            minVal = matrix[i, j];
        }
        if (matrix[i, j] > maxVal)
        {
            maxVal = matrix[i, j];
        }
    }
}
Console.WriteLine(minVal);
*/


// Question 34: Sum of Each Row
// Q: Calculate the sum of each row and store it in a 1D array.
// DONE ABOVE


// Question 36: Count Zeros in Matrix
// Q: Count the number of zeros present in the 2D array.
/*
int[,] matrix = {
    {4, 5, 0},
    {7, 0, 4}
};

int target = 0;
int count = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == target)
        {
            count++;
        }
    }
}

Console.WriteLine($"Count of 0 = {count}");
*/


// Question 38: Reverse Rows
// Q: Reverse each row in the 2D array.


