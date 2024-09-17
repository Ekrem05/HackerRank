static string pangrams(string s)
{
   HashSet<char> result = new HashSet<char>();

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] >= 'A' && s[i] <= 'Z')
        {
            result.Add((char)(s[i] + 32));
        }
        else if (s[i] >= 'a' && s[i] <= 'z')
        {
            result.Add(s[i]);
        }
    }

    return result.Count == 26 ? "pangram" : "not pangram";

}

Console.WriteLine(pangrams("We promptly judged antique ivory buckles for the next prize"));