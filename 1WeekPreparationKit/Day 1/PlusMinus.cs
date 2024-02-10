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

class Result
{
    public static void plusMinus(List<int> arr)
    {
        int positiveCount = 0, negativeCount = 0, zeroCount = 0;

        foreach (int num in arr)
        {
            if (num > 0)
            {
                positiveCount++;
            }
            else if (num < 0)
            {
                negativeCount++;
            }
            else
            {
                zeroCount++;
            }
        }

        int totalCount = arr.Count;

        // Calculate ratios using floating-point division
        double positiveRatio = (double)positiveCount / totalCount;
        double negativeRatio = (double)negativeCount / totalCount;
        double zeroRatio = (double)zeroCount / totalCount;

        // Print ratios with 6 decimal places
        Console.WriteLine($"{positiveRatio:F6}");
        Console.WriteLine($"{negativeRatio:F6}");
        Console.WriteLine($"{zeroRatio:F6}");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
