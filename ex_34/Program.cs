// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void PrintArray(int[] array)
{
    Console.Write($"[{String.Join(",", array)}]\n");
}


int[] MakeArray(int n, int min, int max)
{
    int[] arrNum = new int[n];
    
    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; i++)
    {
        arrNum[i] = rnd.Next(min, max + 1);
    }
 
    return arrNum;
}

int EvenNumbersCount(int[] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (num % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] array = MakeArray(4, 100, 1000);
Console.WriteLine("Задача 34");
PrintArray(array);
int evencounter = EvenNumbersCount(array);
Console.WriteLine($"In the array, there are {evencounter} even numbers");