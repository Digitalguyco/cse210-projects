using System;

public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    public void Hide()
    {
        this.isHidden = true;
    }

    public string Display()
    {
        return isHidden ? "____" : text;
    }

    public bool IsHidden()
    {
        return isHidden;
    }
}
