// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

//С учетом условия, нет смысла прописывать юзеру необходимость ввода положительных чисел.

Console.WriteLine("Введите число M ");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N ");
int numberN = int.Parse(Console.ReadLine());

int FunAkk = FunAkkerman(numberM, numberN);
if (numberM >=0 && numberN >=0)
Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {FunAkk}");

int FunAkkerman(int numM, int numN)
{
    if (numM == 0)
    return numN + 1;
        else if ((numM != 0) && (numN == 0))
        return FunAkkerman(numM - 1, 1);
            if ((numM > 0) && (numN > 0))
            return FunAkkerman(numM - 1, FunAkkerman(numM, numN - 1));
return 0;
}