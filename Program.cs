
using System.Net;

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
}

