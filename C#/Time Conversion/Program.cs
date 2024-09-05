

static string timeConversion(string s)
{
    char[] idk = s.TakeLast(2).ToArray();
    string last = string.Concat(idk);
    int[] result = s.Substring(0, s.Length - 2).Split(":").Select(x=>int.Parse(x)).ToArray();
    if (last == "AM")
    {
        if (result[0] == 12)
        {
            result[0] = 0;
        }
    }
    else if (last == "PM")
    {
        if (result[0] != 12)
        {
            result[0] += 12;
        }
       
    }
    return $"{result[0]:d2}:{result[1]:d2}:{result[2]:d2}";
}



string s = Console.ReadLine();

string result = timeConversion(s);
Console.WriteLine(result);