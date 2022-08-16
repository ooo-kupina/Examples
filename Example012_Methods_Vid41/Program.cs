// Методы

// Вид4 Что-то принимают и что-то возвращают с циклом for


string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method41(10, "Будьте здоровы! Живите богато! ");
Console.WriteLine(res);

