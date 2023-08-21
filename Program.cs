using System.Diagnostics;
using leetcode75.Leetcode.TwoPointers;

namespace leetcode75;

class Program
{
    static void Main(string[] args)
    {
        var m1 = GC.GetTotalMemory(true);
        Stopwatch st = Stopwatch.StartNew();

        for (int i = 0; i < int.MaxValue; i++)
        {
            int a = i / 2;
        }

        var m2 = GC.GetTotalMemory(true);
        var t2 = st.ElapsedMilliseconds;

        int b;

        for (int i = 0; i < int.MaxValue; i++)
        {
            b = i / 2;
        }


        var m3 = GC.GetTotalMemory(true);
        var t3 = st.ElapsedMilliseconds;

        System.Console.WriteLine(m2 - m1);
        System.Console.WriteLine(t2);
        System.Console.WriteLine(m3 - m2);
        System.Console.WriteLine(t3 - t2);
    }

}