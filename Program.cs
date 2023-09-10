
using System;


class Program
{
    public static void Main(string[] args)
    {

        SayWord("Hello");

    }

    public static void SayWord(string word)
    {
        for (int i = 0; i < 10; i++)
        {
            System.Console.WriteLine(word);
        }
    }

    public static int Pow(int a)
    {
        return a * a;
    }
}

