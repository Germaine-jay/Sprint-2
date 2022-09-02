// A PROGRAMME THAT CONVERTS A SENTENCE IN ENGLISH TO PIG LATIN

string wordInEnglish = "The quick brown fox jumps over the lazy dog";
char[] charwordInEnglish = wordInEnglish.ToCharArray();
Array.Reverse(charwordInEnglish);

string newWordInPigLatin = new String(charwordInEnglish);
string [] new_Words = newWordInPigLatin.Split();
string pig_latin = "";

foreach(string word in new_Words)
    { 
        pig_latin += word + "ay" + " ";
    }
Console.WriteLine(pig_latin.TrimEnd());



// A PROGRAMME THAT CONVERTS A SENTENCE IN PIG LATIN TO ENGLISH

string PigLatin = "goday yzalay ehtay revoay spmujay xofay nworbay kciuqay ehTay";
string [] wordInPigLatin = PigLatin.Split();
string newWord = "";
foreach(string word in wordInPigLatin)
    {
        string word2 = word.Replace("ay","");
        newWord += word2 + " ";
    }

char[] WordInEnglish = newWord.ToCharArray();
Array.Reverse(WordInEnglish);
string newWordInEnglish = new String(WordInEnglish);
Console.WriteLine(newWordInEnglish.TrimStart());
