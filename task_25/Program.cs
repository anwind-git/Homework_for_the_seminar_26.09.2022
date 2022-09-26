// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int number_b = Convert.ToInt32(Console.ReadLine());

int sum = number_a;

for (int i = 1; i < number_b; i++)
{
    sum = sum * number_a;
}
Console.WriteLine($"{number_a} в {number_b} степени равно: " + sum);
