//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

int SumOddIndex(int[] array)
{
    int sum = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}


int[] array = MakeArray(4, 1, 50);
Console.WriteLine("Ex 36");
PrintArray(array);
int sumOdd = SumOddIndex(array);
Console.WriteLine($"Sum of elements at odd positions in the array = {sumOdd}");