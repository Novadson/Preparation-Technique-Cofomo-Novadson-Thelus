using System;
using System.Linq;
public class Program
{
    static void Main(string[] args)
    {
        string[] words = { "one", "two", "three", "four", "five", "six" };
        var result = words.Skip(4);

        Console.WriteLine("Skips the first 4 words:");
        foreach (string word in result)
            Console.WriteLine(word);//Ignora as 4 primeiras palavras(Saute les 4 premiers mots)
        Console.ReadKey();

        }

}
