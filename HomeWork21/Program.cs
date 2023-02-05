/*Дано число обозначающее день недели. Выяснить является номер дня недели выходным*/

Console.WriteLine("Enter number: ");
int a = int.Parse(Console.ReadLine());

if (a == 1)
    Console.WriteLine("Monday - go to work");
else if (a == 2)
    Console.WriteLine("Tuesday - go to work");
else if (a == 3)
    Console.WriteLine("Wednesday - go to work");
else if (a == 4)
    Console.WriteLine("Friday - - go to work");
else if (a == 6)
    Console.WriteLine("Saturday - weekend");
else if (a == 7)
    Console.WriteLine("Saturday - weekend");

