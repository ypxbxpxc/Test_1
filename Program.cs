string [] arr = { "qwe", "asdasd", "zxczxc", "nbv", ":)", "( ͡° ͜ʖ ͡°)", "ಠ_ಠ"};

void PrintArray(string [] array)
{
    int count = array.Length;

    for (int i = 0;  i < count ; i++)
    {
        int n = arr[i].Length;
        if (n < 4){
            Console.WriteLine($"{array[i] }");
        }
    }
    Console.WriteLine();
}


PrintArray(arr);

