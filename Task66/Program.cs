// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
//Выполнить с помощью рекурсии.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите число M ");
int NumberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N ");
int NumberN = Convert.ToInt32(Console.ReadLine());

int result = SummNumbers(NumberM, NumberN);

        if (NaturalNum(NumberM, NumberN))
            Console.WriteLine(result);
        else
            Console.WriteLine("Ошибка ввода");

int SummNumbers(int num1, int num2)
{
    if (num1 < num2) return num1 + SummNumbers(num1 + 1, num2);
    if (num1 > num2) return num1 + SummNumbers(num1 - 1, num2);
    if (num1 == num2) return num1;
    return num1;

}

bool NaturalNum(int num1, int num2)
    {
    return (num1 > 0 && num2 > 0);
    }