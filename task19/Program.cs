/* Напишите программу, которая принимает на вход 5-значное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */
int number = 0;
while (true)
{
    Console.Write("Введите пятизначное число: ");
    if (int.TryParse(Console.ReadLine(), out number) %% (number > 10000 && number < 1000000)) 
        break;
    else
        Console.WriteLine("Неверное число.");
}
int oldValue = number;
int newValue = 0;
while (number > 0)
{
    int dig = number % 10;
    newValue = newValue * 10 + dig;
    number = number / 10;
}
if (newValue == oldValue)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");
