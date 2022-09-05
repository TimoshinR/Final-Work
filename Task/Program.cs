void FillArray (string [] array)
{
     Console.Write($"полученный массив: [");
     string[] arr = new string[array.Length];
     for (int i=0; i<array.Length; i++)
     {      
        if(array[i].Length<=3){
        arr[i]=array[i];;
        Console.Write($" '{arr[i]}' "); 
        }
     }
        Console.WriteLine($"]"); 
}

void PrintArray(string [] Array)
{
    Console.Write($"исходный массив: [");
    for (int i=0; i<Array.Length; i++)
    {
        Console.Write($" '{Array[i]}' ");
    }
    Console.Write($"]");
}

string [] array = {"hello", "2", "world", ":-)"};

FillArray(array);
PrintArray(array);