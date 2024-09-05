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


    static void miniMaxSum(List<int> arr)
    {
        long minSum = long.MaxValue;
        long maxSum = long.MinValue;

        for (int i = 0; i < arr.Count; i++)
        {
            long currentSum = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                if (j != i)
                {
                    currentSum += arr[j];
                }
            }
            if (currentSum < minSum)
            {
                minSum = currentSum;
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        Console.WriteLine($"{minSum} {maxSum}");
    }



        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        miniMaxSum(arr);
    
