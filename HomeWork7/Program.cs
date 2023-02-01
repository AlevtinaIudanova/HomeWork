/*Показать вторую цифру трёхзначного числа*/

Console.WriteLine("Введите трехзначное число ");
double number = double.Parse(Console.ReadLine());

string str_num = number.ToString();
int a = int.Parse(str_num[0].ToString());
int b = int.Parse(str_num[0].ToString());
int c = int.Parse(str_num[0].ToString());

Console.WriteLine(str_num[1]);





