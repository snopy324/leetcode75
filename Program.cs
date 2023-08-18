using leetcode75.Leetcode.ArrayString;

namespace leetcode75;

class Program
{
    static void Main(string[] args)
    {
        var r = new GreatestCommonDivisorofStrings();
        System.Console.WriteLine(r.GcdOfStrings("ABCABC", "ABC"));
        System.Console.WriteLine(r.GcdOfStrings("ABABAB", "ABAB"));
        System.Console.WriteLine(r.GcdOfStrings("ABABABAB", "ABAB"));
        System.Console.WriteLine(r.GcdOfStrings("LEETCODE", "AB"));
        System.Console.WriteLine("END");
    }
}
