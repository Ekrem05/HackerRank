static List<string> sort(List<string> grid)
{
   
    for (int e = 0; e < grid.Count; e++)
    {
        char[] chars = grid[e].ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            for (int j = i + 1; j < chars.Length; j++)
            {
                if (chars[j] < chars[i])
                {
                    char temp = chars[i];
                    chars[i] = chars[j];
                    chars[j] = temp;
                }
            }
        }
        grid[e] = string.Join("",chars);
        
    }
    return grid;
}

static string gridChallenge(List<string> grid)
{
        sort(grid);
    for (int f = 0; f < grid[0].Length; f++)
    {
        int current = grid[0][f];//Assci of the current  element of the first row
        for (int r = 1; r < grid.Count; r++)
        {
            if (grid[r][f] >= current)
            {
                current = grid[r][f];
            }
            else
            {
                return "NO";
            }
        }
    }
    return "YES";
}

List<string>grid = new List<string>(){ "abc", "hjk", "mpq", "rtv" };
Console.WriteLine(string.Join(" ",gridChallenge(grid)));