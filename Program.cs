Console.WriteLine("Введите кол-во слов");
int N = Convert.ToInt32(Console.ReadLine());
string [] EnterArray()
{
    string [] array = new string [N];
    for (int i=0; i<N; i++)
    {
        Console.WriteLine($"Введите {i+1} слово");
        array [i] = Console.ReadLine();
    }
return array;
}
//Console.WriteLine(string.Join("|",EnterArray()));
int CountWordArray(string []array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i].Length<=3)
        {
            count++;
        }
    }
    return count;
}
string[] SelectMemberArray(string [] array, int count)
{
    string [] NewArray = new string [count];
    int j=0;
    for (int i=0; i<N; i++)
    {
        if (array[i].Length<=3)
        {
            NewArray[j]=array[i];
            j++;
        }
    }
    return NewArray;
}
string [] NewArray = EnterArray();
Console.WriteLine(string.Join("|",SelectMemberArray(NewArray,CountWordArray(NewArray))));