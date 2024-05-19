/* Задача 1: Напишите программу, которая бесконечно 
запрашивает целые числа с консоли. Программа завершается 
при вводе символа ‘q’ или при вводе числа, сумма цифр 
которого чётная. */



    
        while (true)
        {
            Console.Write("Input number (or 'q' for exit): ");
            string input = Console.ReadLine();

            if (input == "q")
            {
                Console.WriteLine("End of the programm.");
                break;
            }
        
      if (int.TryParse(input, out int number))
      {
            if (IsSumOfDigitsEven(number))
            {
                Console.WriteLine("Sum of numbers are even. End of the program");
                break;
            }
            else
            {
                Console.WriteLine("Sum of numbers are odd. Continue to input numbers.");
            }
        }
            else
        {
            Console.WriteLine("Input error. Please, please input number or 'q' for exit.");
        }
    }
    

static bool IsSumOfDigitsEven(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum % 2 == 0;
}
