string text = "какой-то текст, который надо обработать";

string Replace (string text1, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text1.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text1[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text1[i]}";

    }

    return result;
} 

string newText = Replace (text, 'к', 'ы');
Console.WriteLine (newText);  