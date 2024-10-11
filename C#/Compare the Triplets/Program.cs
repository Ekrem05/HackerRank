static List<int> compareTriplets(List<int> a, List<int> b)
{
    List<int> results = new List<int>() { 0, 0 };
    for (int i = 0; i < 3; i++)
    {
        if (a[i] > b[i])
        {
            results[0]++;
        }
        else if (a[i] < b[i])
        {
            results[1]++;
        }
    }

    return results;
}

List<int> alice = new List<int>() { 17, 28, 30 };
List<int> bob = new List<int>() { 99, 16, 8 };
Console.WriteLine(string.Join(" ",compareTriplets(alice, bob)));