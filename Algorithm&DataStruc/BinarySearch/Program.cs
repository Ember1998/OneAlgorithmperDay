int[] arry = { 1, 2, 2, 3, 3, 4, 5, 56, 6, 6, 74, 5, 7, 8, 8, 534, 7, 78 };
int i = 0; int j = arry.Length - 1;
int midInx = arry.Length / 2;
int.TryParse(Console.ReadLine(), out int num);

while (num != arry[midInx])
{
    if (arry[midInx] > num)
    {
        j = midInx;
    }
    else if(arry[midInx] < num) 
    {
        i  = midInx;
    }
    else {
        Console.WriteLine(midInx);
    }
    midInx = (i + j) / 2;
}

