namespace StaticInterfaceOperatocOvverloading1;

class Program
{
    static void Main(string[] args)
    {
        int number = 7;
        Console.WriteLine(number.IsOdd());
        Console.WriteLine(number.IsEven());

        string text = "Hello123";
        Console.WriteLine(text.IsContainsDigit());

        string name = "AllAHverd";
        Console.WriteLine(name.ToCapitalize());

        string word = "banana";
        Console.WriteLine(string.Join(", ", word.GetValueIndexes('a')));

        string sentence = "Hello someone. How are you?";
        Console.WriteLine(sentence.GetFirstSentence());

        string phrase = "Privet Jalya ,kak ti??";
        Console.WriteLine(phrase.GetSecondWord());

        string sentence2 = "Privet Jalya. Kak ti Jalya?";
        Console.WriteLine(sentence.MatchCount("Jalya")); 

       
        int num1 = 121;
        int num2 = 1234;
        Console.WriteLine(num1.IsPalindrome()); 
        Console.WriteLine(num2.IsPalindrome());
    }
}

