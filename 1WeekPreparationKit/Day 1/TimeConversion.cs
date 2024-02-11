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
    public static string timeConversion(string s)
    {
        // Extract hour, minute, second and meridiem
        int hh = Int32.Parse(s.Substring(0, 2));
        int mm = Int32.Parse(s.Substring(3, 2));
        int ss = Int32.Parse(s.Substring(6, 2));
        string p = s.Substring(8, 2);

        // Convert to 24 hour format
        if (p.ToUpper() == "PM" && hh != 12)
            hh += 12;
        else if (p.ToUpper() == "AM" && hh == 12)
            hh = 0;

        return $"{hh:D2}:{mm:D2}:{ss:D2}";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

