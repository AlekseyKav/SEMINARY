Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

Console.WriteLine("Введите число 1 ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2 ");
int num2 = int.Parse(Console.ReadLine());

if (num1%num2 == 0)
{
    Console.WriteLine("кратно")
    }
    else{
        Console.WriteLine("Остаток: " + num1%num2)
    }