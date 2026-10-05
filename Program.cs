Console.WriteLine("Glosprogram");
/*
List<string> words = [
    "hus", "house",
    "hem", "home",
    "stor", "big",
    "stor", "large"
];
*/

List<Word> words = [
new Word("hus", "house", "swedish", "english"),
new Word("hem", "home", "swedish", "english"),
new Word("stor", "big", "swedish", "english"),
//new Word("stor", "large", "swedish", "english"),
];

//Referera till ett ord:
Console.WriteLine(words[1].WordOut);

//Dictionary

Dictionary<string, string> swedishToEnglish = words.ToDictionary(
    word => word.WordIn, //nyckeln
    word => word.WordOut //värdet
);

//Referera till ett ord i dictionary:
Console.WriteLine(swedishToEnglish["hem"]);

class Word(string wordIn, string wordOut, string languageIn, string languageOut)
{
    public string WordIn { get; } = wordIn;
    public string WordOut { get; } = wordOut;
    public string LanguageIn { get; } = languageIn;
    public string LanguageOut { get; } = languageOut;



}

