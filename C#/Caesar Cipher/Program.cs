static string caesarCipher(string s, int k)
{
    string result = "";
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] >= 'a' && s[i] <= 'z')
        {
            char rotated = (char)((s[i] - 'a' + k) % 26 + 'a');
            result += rotated;
        }
        else if (s[i] >= 'A' && s[i] <= 'Z')
        {
            char rotated = (char)((s[i] - 'A' + k) % 26 + 'A');
            result += rotated;
        }
        else
        {
            result += (char)s[i];
        }

    }
    return result;
}


Console.WriteLine(caesarCipher("Z", 2));