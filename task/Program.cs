string[] array = new string[] {"hello", "2", "world", ":)"};
string[] newArray = FindLessThan(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", newArray)}]");

string[] FindLessThan(string[] input, int n) 
{
    string[] output = new string[CountLessThan(input, n)];
    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            output[j] = input[i];
            j = j + 1;
        }
    }
    return output;
}

int CountLessThan(string[] input, int n) 
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            count = count + 1;
        }
    }
    return count;
}