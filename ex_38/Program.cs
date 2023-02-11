// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// pull request
// [3 7 22 2 78] -> 76

void PrintArray(double[] array)
{
    Console.Write($"[{String.Join(",", array)}]\n");
}

double[] MakeArray(int n, int min, int max)
{
    double[] arrNum = new double[n];
    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; i++)
    {
        arrNum[i] = rnd.Next(min, max + 1);
    }
 
    return arrNum;
}

double FindDifference(double[] array)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    foreach(double i in array)
    {
        if (i < min)
        {
            min = i;
        }
        if (i > max)
        {
            max = i;
        }
    }
    return max - min;
}
Console.WriteLine("ex 38");
double[] array = MakeArray(10, 1, 100);
PrintArray(array);
Console.WriteLine("Difference between the maximum and minimum elements of the array = " + FindDifference(array));