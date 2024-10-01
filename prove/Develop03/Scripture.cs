using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            this.words.Add(new Word(word));
        }
    }

    // Display the scripture with hidden words
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(reference.GetReference());

        foreach (Word word in words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }

    // Hide random words
    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = 3; // Number of words to hide at a time

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(words.Count);
            words[index].Hide();
        }
    }

    // Check if all words are hidden
    public bool AreAllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
