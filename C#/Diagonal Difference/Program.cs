static int diagonalDifference(List<List<int>> arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        sum += arr[i][i];
        sum -= arr[arr.Count-1-i][i];
    }
    return Math.Abs(sum);
}

List<List<int>> arr = new List<List<int>>()
{
    new List<int>(){1,2,3},
    new List<int>(){4,5,6},
    new List<int>(){9,8,9}
};

Console.WriteLine(diagonalDifference(arr));

