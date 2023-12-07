// Рекурсия
// Напишите программу, которая принимает от пользователя 2 числа. 
// Необходимо сложить введенные числа, без прямого сложения.

int summa(int a, int b){
    if (b == 0)
        return a;
    return summa(a + 1, b - 1);
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Результат: {a} + {b} = {summa(a, b)}");

/*
a = 5 b = 3 S = summa

S(5, 3) -> S(6, 2) -> S(7, 1) -> S(8, 0) -> 8
*/
