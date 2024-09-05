using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

static void plusMinus(List<int> arr)
{
    int negative = 0;
    int positive = 0;
    int zeros = 0;
    for (int i = 0; i <= arr.Count-1; i++)
    {
        if (arr[i] > 0)
        {
            positive++;
        }
        else if (arr[i] < 0)
        {
            negative++;
          }
        else
        {
            zeros++;
        }
    }
    Console.WriteLine((double) positive / arr.Count);
    Console.WriteLine((double) negative / arr.Count);
    Console.WriteLine((double) zeros / arr.Count);


}
int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
plusMinus(arr);

    