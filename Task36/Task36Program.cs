//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
int FindSumEvenPosition(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i = i +2)
    {
        sum = sum + array[i];
    }
    return sum;
}





int[] NewArray(int length, int start, int end)
{
    int[] array  = new int[length];
      for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
return array;
}


//Задать массив из случайных чисел.
int[] myarray = NewArray(20, 0, 10);
Console.WriteLine(String.Join(",", myarray));
//Найти сумму элементов, стоящих на четных позициях

int sumEven = FindSumEvenPosition(myarray); 

//Вывести результат
Console.WriteLine($"Cумма элементов массива на четных позициях равна {sumEven}");
