Console.WriteLine("Glosprogram");
/*
List<string> words = [
    "hus", "house",
    "hem", "home",
    "stor", "big",
    "stor", "large"
];
*/

List<string> words = [
new Word("hus", "house", "swedish", "english");
new Word("hem", "home", "swedish", "english");
new Word("stor", "big", "swedish", "english");
new Word("stor", "large", "swedish", "english");
]

class Word(string wordIn, string wordOut, string languageIn, string languageOut)
{
    public string WordIn { get; } = wordIn;
    public string WordOut { get; } = wordOut;
    public string LanguageIn { get; } = languageIn;
    public string LanguageOut { get; } = languageOut;

}