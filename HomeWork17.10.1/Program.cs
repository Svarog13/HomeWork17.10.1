using System;

int[] A = new int[5];
Console.WriteLine("Filling the array: ");

for (int i = 0; i < 5; i++) // Змінилася умова з 4 на 5, оскільки масив A має 5 елементів.
{
    Console.WriteLine($"Enter the {i} element of array: ");
    A[i] = int.Parse(Console.ReadLine());
}

Random random = new Random();
int[,] B = new int[3, 4];

for (int i = 0; i < 3; i++) 
{
    for (int j = 0; j < 4; j++) 
    {
        B[i, j] = random.Next(-99, 99);
    }
}

Console.WriteLine("Realisation of Array A.");
foreach (int item in A)
{
    Console.WriteLine($"Element: {item}");
}

Console.WriteLine("\nRealisation of Array B.");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(B[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int minElementA = A[0];
int maxElementA = A[0];
for (int i = 1; i < A.Length; i++)
{
    if (A[i] < minElementA)
    {
        minElementA = A[i];
    }
    if (A[i] > maxElementA)
    {
        maxElementA = A[i];
    }
}

Console.WriteLine($"Minimum element in the array A: {minElementA}");
Console.WriteLine($"Maximum element in the array A: {maxElementA}");
Console.WriteLine();

int minElementB = B[0,0];
int maxElementB = B[0, 0];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (B[i,j] < minElementB)
        {
            minElementB = B[i,j];
        }
        if (B[i,j] > maxElementB)
        {
            maxElementB = B[i, j];
        }
    }
}

Console.WriteLine($"Minimum element in the array B: {minElementB}");
Console.WriteLine($"Maximum element in the array B: {maxElementB}");
Console.WriteLine();

int sumA = 0;
int prodA = 1;
int sumOfEven = 0;

foreach (var item in A)
{
    sumA += item;
    prodA *= item;
    if (item % 2 == 0)
    {
        sumOfEven += item;
    }
}

Console.WriteLine($"Sum of all elements in A: {sumA}");
Console.WriteLine($"Product of all elements in A: {prodA}");
Console.WriteLine($"Sum of even elements in A: {sumOfEven}");
Console.WriteLine();

int sumB = 0;
int prodB = 1;
int sumOfNoEven = 0;

foreach (var item in B)
{
    sumB += item;
    prodB *= item;
    if (item %2 != 0)
    {
        sumOfNoEven += item;
    }
}

Console.WriteLine($"Sum of all elements in A: {sumB}");
Console.WriteLine($"Product of all elements in A: {prodB}");
Console.WriteLine($"Sum of no even elements in A: {sumOfNoEven}");


