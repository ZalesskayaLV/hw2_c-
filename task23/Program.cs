/* 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */ 

void GetCube(int num)
{
  Console.Write($"{num} -> ");
  for (int i = 1; i <= num; i++ )  
    {
        double cube = Math.Pow(i, 3); 
        Console.Write(cube);
        if (i == num) 
        { 
            Console.Write(".");
        }
        else  Console.Write(", "); 
    }
}

int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            if (number > 0)
                return number;
            else
            {
                Console.WriteLine("Число должно быть больше 0. Введите другое число");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля.");
        }
    }
}

string message = ("Введите число N больше 0:");
int numInp = GetNumber(message);


GetCube(numInp);
