using System;

public static class PigLatin
{
    static string[] startVowelSounds = {"a", "e", "i", "o", "u", "yt", "xr"};
    static string otherVowelSounds = "aeiouy";
    
    public static string Translate(string word)
    {
        string[] words = word.Split(" ");
        for (int i = 0; i < words.Length; i++) words[i] = ConvertWord(words[i]);
        word = String.Join(" ", words);
        return word;
    }

    static string ConvertWord(string word)
    {
        foreach (string sound in startVowelSounds) if (word.StartsWith(sound))
            return word + "ay";

        int charsToMove = 1;
        for (int i = 1; i < word.Length; ++i)
        {
            if (otherVowelSounds.Contains(word[i]))
            {
                if (word[i] == 'u' && word[i - 1] == 'q') charsToMove++;
                break;
            }
            charsToMove++;
        }
        return word.Remove(0, charsToMove) + word.Remove(charsToMove) + "ay";
    }
}