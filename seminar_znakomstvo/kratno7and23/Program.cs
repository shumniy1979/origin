using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
      Console.Write("Введите 1-ое число: ");
      int num1 = int.Parse(Console.ReadLine());
      Console.Write("Введите 2-ое число: ");
      int num2 = int.Parse(Console.ReadLine());
      if (num1 == num2){
                    Console.Write("Числа одинаковые ");
                    } 
        else
      {  
      if (num1 > num2)
      {
      firstNumber = num1;
      }
      else 
        {
        secondNumber = num2;
        }
    Console.Write(" 1-ое число: ");
    Console.Write(firstNumber);
    Console.Write(" 2-ое число: ");
    Console.Write(secondNumber);
        }
    }
  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 7;
            secondNumber = 6;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}