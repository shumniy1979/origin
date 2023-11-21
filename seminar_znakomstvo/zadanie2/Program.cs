// Задание 2
Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 100 || n > 999)
{
    Console.Write("Вы ошиблись! \nВведите трехзначное число:");
    n = int.Parse(Console.ReadLine()!);
}
// 385 : 10 = 38 ост 5
int n2 = (n / 10) % 10;
int n3 = n % 10, result = 1;
for (int i = 1; i <= n3; i++){
    result = result * n2;
                             }
Console.Write($"{n2}^{n3} = {result}");