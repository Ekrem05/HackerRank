using System;

//Removing from an array takes time

static int lonelyinteger(List<int> a)
{
   Dictionary<int,int> map = new Dictionary<int,int>();
    foreach (int num in a)
    {
        if (map.ContainsKey(num))
        {
            map[num] += 1; 
        }
        else
        {
            map[num] = 1; 
        }
    }
    foreach (var entry in map)
    {
        if (entry.Value == 1)
        {
            return entry.Key;
        }
    }
    return -1;
}
int n = Convert.ToInt32(Console.ReadLine().Trim());
List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

int result = lonelyinteger(a);

Console.WriteLine(result);