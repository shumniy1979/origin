// Задание 4
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
number = Math.Abs(number); // |-5|=5
if (number < 100)
   Console.Write("Третьей цыфры нет"); 
else{
     Console.WriteLine(number % 1000 / 100); 
}
