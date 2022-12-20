// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int SumCalculation(int[]array)
{
  int sum = 0;  
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] % 2 == 0)
    {
        sum = sum + array[i];
    }
  }
  return sum;
}

int[] Newarray(int length,int start, int end)
{
    int[] array  = new int[length];
      for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
return array;
}

// Задать массив из положительных трехзначных чисел
int[] threedigit = Newarray(20, 100, 1000);
Console.WriteLine(String.Join(",", threedigit));
// Посчитать количество четных чисел в массиве
int specificsum = SumCalculation(threedigit);

// Вывести результат на экран
Console.WriteLine($"Сумма четных чисел массива равна {specificsum} ");