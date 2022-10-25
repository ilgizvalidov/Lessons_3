string Method4 (int count, string text)
{
    int i = 0;
    string result = string.Empty;
    
        while ( i < count)
        {
            result = result + text;
            i++;
        }
    return result;
}

string res = Method4 (10, " этот текс будет выведен 10 раз ");
Console.WriteLine (res);
