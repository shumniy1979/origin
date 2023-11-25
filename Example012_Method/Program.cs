string text = "– Я думаю, – сказал князь, улыбаясь, – что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length32 = text.Length;
    for (int i = 0; i < length32; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
       
    }
    return result;
}

string newText = Replace (text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace (newText, 'к', 'К');
Console.WriteLine(newText);
