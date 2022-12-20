// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


int[] NewArray(int length, int start, int end)
{
    int[] array  = new int[length];
      for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
return array;
}

//Задать массив из случайных чисел
int[] myarray = NewArray(20, 10, 1000);
Console.WriteLine(String.Join(",", myarray));

//Найти максимальное и минимальное значение и вычислить их разницу.
int max = myarray.Max();
int min = myarray.Min();

int diff = max - min;

//Вывести результат 
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {diff}");