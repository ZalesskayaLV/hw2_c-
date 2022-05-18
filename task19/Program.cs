/*Напишите программу, которая на вход принимает пятизначное число и проверяет, является ли это число палиндромом
14212 -> нет
23432 -> да
12821 -> да
*/ 

void GetPalindrome (int num)
{
    string digit = num.ToString();
    if ((digit[0]==digit[4])&&(digit[1]==digit[3]))
    Console.WriteLine($"{num} -> да");
    else Console.WriteLine($"{num} -> нет");
}

int GetNumber(string msg)
{
while(true)
{
Console.WriteLine(msg);
string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        if((number>=10000) && (number<100000))  
            return number;
        else
        {
            Console.WriteLine("Вы ввели не пятизначное число.");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не число. Введите пятизначное число.");
    }
}
}

int result = GetNumber("Введите пятизначное число: ");

GetPalindrome(result);