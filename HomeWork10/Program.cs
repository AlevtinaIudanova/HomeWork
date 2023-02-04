/*Выяснить, кратно ли число заданному, если нет, вывести остаток*/

int a;
int b;

Console.Write("Введите число 1: ");
int.TryParse(Console.ReadLine(), out a);
Console.Write("Введите число 2: ");
int.TryParse(Console.ReadLine(), out b);

if (a % b == 0)
{
    Console.Write("Число кратно -> ");
}
else
{
    Console.Write($"Число не кратное -> остаток {a % b} ");
}


