Console.Clear();
// char[] chars = {'a', 'b', 'c', 'd'};
Console.Write("Введите символы через пробел: ");
char[] chars = Console.ReadLine()!.Split().Select(x => char.Parse(x)).ToArray();
/*
1. "a b 1 2 3 4 6 c d e"
2. ["a", "b", "1", "2", "3", "4", "6", "c", "d", "e"]
3. 'a', 'b', '1', '2', '3', '4', '6', 'c', 'd', 'e'
4. ['a', 'b', '1', '2', '3', '4', '6', 'c', 'd', 'e']
*/
string result = string.Empty; // создание пустой строки
// string result = "";
foreach (char element in chars)
{
    result = result + element;
}
Console.WriteLine(result);