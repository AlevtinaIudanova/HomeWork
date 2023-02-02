/*Удалить вторую цифру трёхзначного числа*/
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

/*int num = new Random().Next(100, 1000);*/

int a = number / 100;
int b = number % 10;

Console.Write($"{number} -> {a}{b} ");
