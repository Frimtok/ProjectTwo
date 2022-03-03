using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        string word = Console.ReadLine();
        if (int.TryParse(word, out int number))
        {
            Console.WriteLine("число");
        }
        else
        {
            number = ConverWord(word);
            Console.WriteLine(number);
        }
            Console.WriteLine("палиндром ли это - " + IsPalindrome(number));

    }
    private static int ConverWord(string word)
    {
        int number = 0;
        string[] newWord;
        newWord = word.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < newWord.Length; i++)
        {
            switch (newWord[i])
            {
                case "тысячи":

                    number *= 1000;
                    break;
                case "тысяча":

                    number += 1000;
                    break ;
                case "тысяч":

                    number *= 1000;
                    break;
                case "один":
                    number += 1;
                   break;
                case "два":
                    number += 2;
                    break;
                case "две":
                    number += 2;
                    break;
                case "три":
                    number += 3;
                    break;
                case "четыре":
                    number += 4;
                    break;
                case "пять":
                    number += 5;
                    break;
                case "шесть":
                    number += 6;
                    break;
                case "семь":
                    number += 7;
                    break;
                case "восемь":
                    number += 8;
                    break;
                case "девять":
                    number += 9;
                    break;
                case "десять":
                    number += 10;
                    break;
                case "одиннадцать":
                    number += 11;
                    break;
                case "двадцать":
                    number += 20;
                    break;
                case "тридцать":
                    number += 30;
                    break;
                case "сорок":
                    number += 40;
                    break;
                case "пятьдесят":
                    number += 50;
                    break;
                case "шестьдесят":
                    number += 60;
                    break;
                case "семьдесят":
                    number += 70;
                    break;
                case "восемьдесят":
                    number += 80;
                    break;
                case "девяносто":
                    number += 90;
                    break;
                case "сто":
                    number += 100;
                    break;
                case "двести":
                    number += 200;
                    break;
                case "триста":
                    number += 300;
                    break;
                case "четыреста":
                    number += 400;
                    break;
                case "пятьсот":
                    number += 500;
                    break;
                case "шесот":
                    number += 600;
                    break;
                case "семьсот":
                    number += 700;
                    break;
                case "восемьсот":
                    number += 800;
                    break;
                case "девятьсот":
                    number += 900;
                    break;
                default:
                    Console.WriteLine(" не могу понять число");
                    return number;
            }
        }
            return number;
    }
    private static bool IsPalindrome(int num)
    {
        if (num >= 0 && num < 10)
            return true;
        int numLength = GetLength(num);
        int[] digits = new int[numLength];
        for (int i = numLength - 1; i >= 0; i--)
        {
            digits[i] = num % 10;
            num /= 10;
        }
        for (int i = 0; i < numLength / 2; i++)
        {
            if (digits[i] != digits[numLength - i - 1])
                return false;
        }
        return true;
    }
    private static int GetLength(int num)
    {
        int n = 0;
        while (num > 0)
        {
            num /= 10;
            n++;
        }
        return n;
    }
}