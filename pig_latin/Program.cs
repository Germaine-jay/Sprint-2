// A PROGRAMME THAT CONVERTS A SENTENCE IN ENGLISH TO PIG LATIN

string wordInEnglish = "The quick brown fox jumps over the lazy dog";

string pig_latin="";
foreach(string  word in wordInEnglish.Split())
    {
        var NewWord = word.Substring(1) + word.Substring(0,1);
        pig_latin += NewWord + "ay" +" ";
    }
Console.WriteLine(pig_latin.TrimEnd());



// A PROGRAMME THAT CONVERTS A SENTENCE IN PIG LATIN TO ENGLISH

string PigLatin = "heTay uickqay rownbay oxfay umpsjay veroay hetay azylay ogday";

string newWord = "";
foreach(string word in PigLatin.Split())
    {
        string word2 = word.Replace("ay","");
        var len = word2.Length;
        var NewWord2 = word2.Substring(len-1,1)+ word2.Substring(0,len-1);
        newWord += NewWord2 + " ";
    }

Console.WriteLine(newWord.TrimStart());