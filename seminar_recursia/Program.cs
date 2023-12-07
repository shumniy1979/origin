/*
Задача 1.
Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
*/


int summaCifr(int n){
    if (n < 10)
        return n;
    return summaCifr(n / 10) + n % 10;
}

/* n = 456 S = summaCifr
S(456) -> S(45) + 6 = 4 + 5 + 6 = 15
            |
            S(4) + 5 = 4 + 5
              |
              4

*/


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
// int result = 0;
// while (n >= 10){ // n < 10 || n % 10 = n || n / 10 == 0
//     result += n % 10;
//     n /= 10;
// }
// Console.WriteLine(result + n);
Console.WriteLine(summaCifr(n));