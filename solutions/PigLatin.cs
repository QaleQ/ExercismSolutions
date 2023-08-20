using System;

public static class PigLatin
{
    public static string Translate(string word)
    {
        string[] words = word.Split(" ");
        for (int i = 0; i < words.Length; i++) words[i] = ConvertWord(words[i]);
        word = String.Join(" ", words);
        return word;
    }

    static string ConvertWord(string word)
    {
        if (word[0] is 'a' or 'e' or 'i' or 'o' or 'u' || word.StartsWith("xr") || word.StartsWith("yt"))
            return word + "ay";
        else if (word.StartsWith("squ") || word.StartsWith("thr") || word.StartsWith("sch"))
        {
            string add = word.Remove(3);
            word = word.Remove(0, 3);
            word += add;
        }
        else if (word.StartsWith("ch") || word.StartsWith("sh") || word.StartsWith("qu") || word.StartsWith("th") ||
                 word.StartsWith("rh"))
        {
            string add = word.Remove(2);
            word = word.Remove(0, 2);
            word += add;
        }
        else
        {
            word += word[0];
            word = word.Remove(0, 1);
        }

        return word + "ay";
    }
}