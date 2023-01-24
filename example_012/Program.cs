string text="- Я, придя домой, смотрю дуракцие лекции," 
+"в которых объяснения мне не понятны в 90% случаях." 
+"Вывод - за что заплачены деньги?";

string Replace(string text, char oldValue, char newValue)
{
    string result=String.Empty;

    int length=text.Length;
    for (int i=0; i<length; i++)
    {
        if(text[i]==oldValue) result=result+$"{newValue}";
        else result=result+$"{text[i]}";
    }
    return result;
}
string newText=Replace(text, ' ','|');
Console.WriteLine(newText);