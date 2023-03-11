using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference = new Reference();
        reference.LoadReference();
        Scripture scripture = new Scripture();
        scripture.LoadScriptures();
        Word word = new Word();

        Console.WriteLine("Scripture Memorizer");
        int userChoice = 0;

        while (userChoice != 3)
        {
            userChoice = UserChoice();
            switch (userChoice)
            {
                case 1:
                    reference.ReferenceDisplay();

                    break;
                case 2:
                    string script = scripture.RandomScripture();
                    string ref1 = reference.GetReference(scripture);
                    word.GetRenderedText(scripture);
                    word.GetRenderedRef(scripture);

                    while (word._hidden.Count < word._result.Length)
                    {
                        word.Show(ref1);
                        word.GetReadKey();
                    }
                    word.Show(ref1);
                    break;
                case 3:
                    Console.WriteLine("Congratulations on having the desire to memorize scriptures.");
                    break;
                default:
                    Console.WriteLine("The option is not valid.");
                    break;
            }
        }
    }

   static int UserChoice()
    {
        Reference reference = new Reference();
        string choices = $@"
        Select an option:
        1. Show available references
        2. Randomly select scriptures to memorize.
        Q. Quit
        >>>";
        
        Console.Write(choices);

        string userInput = Console.ReadLine();
        userInput.ToLower();
        int userChoice = 0;
        
        try
        {
            if (userInput == "q")
            {
                userInput = "3";
            }
            userChoice = int.Parse(userInput);
        }
        catch (FormatException)
        {
            userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return userChoice;
    }
}