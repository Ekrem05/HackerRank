using System.IO;

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<List<int>> arr = new List<List<int>>();

for (int i = 0; i < n; i++)
{
    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
}

int result = diagonalDifference(arr);

Console.WriteLine(result);



static int diagonalDifference(List<List<int>> arr)
{
    int primarySum = 0;
    int secondarySum = 0;
    for (int i = 0; i < arr.Count; i++)
    {
        secondarySum += arr[i][arr[i].Count-i-1];
        primarySum += arr[i][i];
    }

    return Math.Abs(secondarySum - primarySum);
}
