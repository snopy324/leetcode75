using System.Buffers;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using leetcode75.Leetcode.ArrayString;
using leetcode75.Leetcode.Monotonic_Stack;
using System;
using System.Text;
using leetcode75.Leetcode.Counting_Bits;
using System.Text.Json;

namespace leetcode75;

class Program
{
    static void Main(string[] args)
    {
        var cb = new Count_Bits();
        var a = cb.CountBits(2);
        var b = cb.CountBits(5);
        var c = cb.CountBits(10);
        var d = cb.CountBits(50);
        System.Console.WriteLine(JsonSerializer.Serialize(d));
    }

}