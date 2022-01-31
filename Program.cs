string [] arr = { "qwe", "asdasd", "zxczxc", "nbv", ":)", "( ͡° ͜ʖ ͡°)", "ಠ_ಠ"};

int j = 0;
string [] NewArr;
NewArr = new string[arr.Length];


    int count = arr.Length;

    for (int i = 0;  i < count ; i++)
    {
        int n = arr[i].Length;
        if (n < 4){ 
                void NewArray(string [] NewArr)
                {
                    j++;
                    NewArr[j] = arr[i]; 
                    Console.WriteLine($"{NewArr[j] }");
                    
                }
    NewArray(NewArr);        
        }
    }
