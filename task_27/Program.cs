// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Metod1()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int remains = 0;

    for (int i = 1; number > 0; i++)
    {
        remains = remains + number % 10;
        number = number / 10;
    }
    Console.WriteLine($"Сумма цифр в числе: " + remains);
}
Metod1();