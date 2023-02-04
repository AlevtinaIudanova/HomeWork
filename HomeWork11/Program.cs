/*Найти третью цифру числа или сообщить, что её нет*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

string str_num = number.ToString();
int a = int.Parse(str_num[2].ToString());

Console.WriteLine(str_num[2]);

