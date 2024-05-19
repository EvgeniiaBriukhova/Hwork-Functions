/* Задача 2: Задайте массив заполненный случайными 
трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве. */

int[] CreateArrayRndInt(int size, int min, int max) 
{
    int[] array = new int[size];  
    Random rnd = new Random(); 

    for (int i = 0; i < size; i++) 
    {
        array[i] = rnd.Next(min, max); 
    }
    return array; 
}

void PrintArray(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) 
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
        Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }



int[]arr = CreateArrayRndInt(10, 100, 1000); 
PrintArray(arr); 
int evenCount = CountEvenNumbers(arr);
Console.WriteLine($"\nAmount of even numbers in array: {evenCount}");