namespace leetcode75.Leetcode.Monotonic_Stack;
public class StockSpanner
{
    private Stack<(int value, int day)> records;
    private int date = 0;
    public StockSpanner()
    {
        records = new Stack<(int, int)>();
        records.Push((int.MaxValue, 0));
    }

    public int Next(int price)
    {
        date++;

        while (records.TryPeek(out var lastPeak) && lastPeak.value <= price)
        {
            records.Pop();
        }

        var to = records.Peek();

        records.Push((price, date));

        return date - to.day;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);   
 */

//  Input
// ["StockSpanner", "next", "next", "next", "next", "next", "next", "next"]
// [[], [100], [80], [60], [70], [60], [75], [85]]
// Output
// [null, 1, 1, 1, 2, 1, 4, 6]

// Explanation
// StockSpanner stockSpanner = new StockSpanner();
// stockSpanner.next(100); // return 1
// stockSpanner.next(80);  // return 1
// stockSpanner.next(60);  // return 1
// stockSpanner.next(70);  // return 2
// stockSpanner.next(60);  // return 1
// stockSpanner.next(75);  // return 4, because the last 4 prices (including today's price of 75) were less than or equal to today's price.
// stockSpanner.next(85);  // return 6