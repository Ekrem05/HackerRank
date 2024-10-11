static long aVeryBigSum(List<long> ar)
{
    long sum=0;
    for (int i = 0; i < ar.Count; i++)
    {
        sum += ar[i];
    }
    return sum;
}

List<long> numbers = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004,1000000005 };
Console.WriteLine(aVeryBigSum(numbers));