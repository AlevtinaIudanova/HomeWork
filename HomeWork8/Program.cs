/*Дано число из отрезка [10, 99]. Показать наибольшую цифру числа*/

Console.WriteLine("Введите число из отрезка [10, 99]: ");
int number = int.Parse(Console.ReadLine());

string str_num = number.ToString();
int a = int.Parse(str_num[0].ToString());
int b = int.Parse(str_num[1].ToString());

if (a > b)
{
    Console.Write(a);
}
else
{
    Console.Write(b);
}
