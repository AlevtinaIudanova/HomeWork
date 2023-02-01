/*Показать четные числа от 1 до N*/

int N;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int index = 2;
while (index <= N)
{
    if (index % 2 == 0)
    {
        Console.Write($"{index} ");
    }
    index += 2;
}
