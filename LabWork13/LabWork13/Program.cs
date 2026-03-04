string str = " qwerqty ";
string text = "Text adadd. AAA frsfsf? Sfsefsefsresf sfsf! Eqeqeqeq.";

Console.WriteLine(str.Length);
Console.WriteLine(str.Replace(" ", "").Length);
Console.WriteLine(str.Count(char.IsLetter));

SearchSubstring(str);
SeparateText(text);

static void SearchSubstring(string str)
{
    Console.WriteLine("Введите значение:");
    string? subString = Console.ReadLine();
    subString = String.IsNullOrEmpty(subString) ? "" : subString;
    int index = str.IndexOf(subString);
    while (index > -1)
    {
        if (!String.IsNullOrEmpty(subString) && str.Contains(subString))
        {
            Console.WriteLine(index);
            index = str.IndexOf(subString, index + 1);
        }
    }
    if (index == -1)
        Console.WriteLine("Совпадений не найдено.");
}

static void SeparateText(string text)
{
    string[] stringSplit = text.Split(['.', '?', '!'], StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
    foreach (string s in stringSplit)
        Console.WriteLine(s);
    Console.WriteLine($"Найдено {stringSplit.Length} элементов.");

    string? subString = Console.ReadLine();
    subString = String.IsNullOrEmpty(subString) ? "" : subString;
    for (int i = 0; i < stringSplit.Length; i++)
    {
        stringSplit[i].IndexOf(subString);
    }

}