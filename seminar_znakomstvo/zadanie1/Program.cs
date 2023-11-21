// Семинар 2
// Задание 1
// Алгебра логики (Булевская логика) 0(false) или 1(true)
// алфавит СС:0 1 2 3 4 5 6 7 8 9
//Console.Clear();
//Console.Write("Введите число: ");
//int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n > 10 && n < 15 || n % 2 == 0); // ???

// && (and) конюн
// || (or) дизю

Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 100 || n > 999)
{
    Console.Write("Вы ошиблись! \nВведите трехзначное число:");
    n = int.Parse(Console.ReadLine()!);
}
int n1 = n / 100; // количество сотен
int n3 = n % 10; // деление на 10
Console.Write(n1 * 10 + n3 * 1);