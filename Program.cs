string[] array1 = new string[5] {"kazan", "123", "one", "work", "msk"};
string[] array2 = new string[array1.Length];
int count = 0;
void Search(string[] array1, string[] array2)
{
    count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < count; i++)
    {
        
        Console.Write($"  [ {array[i]} ]  ");
    }
    Console.WriteLine();
}

Search(array1, array2);
PrintArray(array2);
