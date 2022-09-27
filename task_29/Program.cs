// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив
int[] array = new int[8];
void RandomMas()
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(-99, 99);
    string arr1 = string.Join(", ", array);
    Console.WriteLine($"Массив до сортировки:    [" + arr1 + "]");
}

void SortMas()
{
    int temp;
    for (int i = 0; i < array.Length; i++)
        for (int j = i + 1; j < array.Length; j++)
            if (Math.Abs(array[i]) > Math.Abs(array[j]))
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }                              
    string arr2 = string.Join(", ", array);
    Console.WriteLine($"Массив после сортировки: [" + arr2 + "]");
}
RandomMas();
SortMas();