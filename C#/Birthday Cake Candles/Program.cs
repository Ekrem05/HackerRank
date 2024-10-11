static int birthdayCakeCandles(List<int> candles)
{

    int tallest = candles[0];
    int count = 1;
    for (int i = 1; i < candles.Count; i++)
    {
        if (candles[i] > tallest)
        {
            tallest = candles[i];
            count = 1;
        }
        else if(candles[i] == tallest)
        {
            count++;
        }
    }
    return count;
   
}

Console.WriteLine(birthdayCakeCandles(new List<int>() { 4, 4, 1, 3 }));