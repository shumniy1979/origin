// Задание 3
Console.Clear();
Console.Write("Введите 1-ое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int secondNumber = int.Parse(Console.ReadLine()!);
if (firstNumber % secondNumber == 0)
    Console.WriteLine("Да");
else
    Console.WriteLine($"нет, {firstNumber % secondNumber}");
