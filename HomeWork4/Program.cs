/*Выяснить является ли число чётным*/

Console.WriteLine("Введите первое число ");
double number = double.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write("Число четное ");
}
else
{
    Console.Write("Число не четное");
}

