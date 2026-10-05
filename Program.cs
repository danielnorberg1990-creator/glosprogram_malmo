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
new Word("stor", "large", "swedish", "english"),
new Word("katt", "cat", "swedish", "english"), //nya ord läggs bara till här i listan
];

//Referera till ett ord:
//Console.WriteLine(words[1].WordOut);

//Dictionary

Dictionary<string, List<Word>> swedishToEnglish = words
.GroupBy(word => word.WordIn, StringComparer.OrdinalIgnoreCase) //gruppera alla ord med samma WordIn (t.ex. "hem")
.ToDictionary
(
    group => group.Key,      //nyckeln = gruppens nyckel (WordIn, t.ex. "hem")
    group => group.ToList(),   //värdet = lista med alla Word i gruppen
    StringComparer.OrdinalIgnoreCase
);

//Referera till ett ord i dictionary:
//Console.WriteLine(swedishToEnglish["hem"][0].WordOut);

while (true)
{
    Console.WriteLine("Ange vilket ord du vill översätta: ");
    string? wordToTranslate = Console.ReadLine();

    //avsluta om inget ord skrivs (Enter) eller om inmatningen tar slut
    if (string.IsNullOrEmpty(wordToTranslate))
    {
        break;
    }

    //loopa ut synonymer – TryGetValue så programmet inte kraschar om ordet saknas
    if (swedishToEnglish.TryGetValue(wordToTranslate, out var translations))
    {
        foreach (var word in translations)
        {
            Console.WriteLine(word.WordOut);
        }
    }
    
    {
        Console.WriteLine("Ordet finns inte i ordboken.");
    }
}
class Word(string wordIn, string wordOut, string languageIn, string languageOut)
{
    public string WordIn { get; } = wordIn;
    public string WordOut { get; } = wordOut;
    public string LanguageIn { get; } = languageIn;
    public string LanguageOut { get; } = languageOut;
}

