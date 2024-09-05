using System.IO;

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

List<int> result = countingSort(arr);

Console.WriteLine(String.Join(" ", result));



static List<int> countingSort(List<int> arr)
{
    int[] result = new int[100];
    for (int i = 0; i < arr.Count; i++)
    {
        result[arr[i]] += 1;
    }

    return result.ToList();
}