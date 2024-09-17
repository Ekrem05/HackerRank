static string twoArrays(int k, List<int> A, List<int> B)
{
    A.Sort();
    B=B.OrderByDescending(x=>x).ToList();

    for (int i = 0; i < A.Count; i++)
    {
        if (A[i] + B[i] < k)
            return "NO";
    }

    return "YES";
}

List<int> a = new List<int>() { 1, 2, 2, 1 };
List<int> b = new List<int>() { 3, 3, 3, 4 };

Console.WriteLine(twoArrays(5,a,b));
