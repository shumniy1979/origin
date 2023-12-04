// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите строку: ");
string initial = Console.ReadLine()!;
char[] chars = new char [initial.Length];
// hello
for (int i = 0; i < initial.Length; i++)
{
    chars[i] = initial[i];
}
    Console.WriteLine($"Результат: [{string.Join(" ", chars)}]");