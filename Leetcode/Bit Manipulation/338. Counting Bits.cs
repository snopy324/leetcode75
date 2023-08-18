namespace leetcode75.Leetcode.Counting_Bits;
public class Count_Bits
{
    public int[] CountBits(int n)
    {
        // var result = new int[n + 1];

        // for (int i = 0; i <= n; i++)
        // {
        //     int sum = 0;
        //     int t = i;
        //     while (t >= 1)
        //     {
        //         sum = sum + t % 2;
        //         t = t >> 1;
        //     }
        //     result[i] = sum;
        // }

        // return result;
        var result = new int[n + 1];
        var power = 1;
        for (int i = 1; i <= n; i++)
        {
            if (i == power)
            {
                result[i] = 1;
                power <<= 1;
                continue;
            }

            result[i] = result[i - (power >> 1)] + 1;
        }


        return result;
    }
}

// [0,1,1,2,1,2,2,3,1,2,2,3,2,3,3,4,1,2,2,3,2,3,3,4,2,3,3,4,3,4,4,5,1,2,2,3,2,3,3,4,2,3,3,4,3,4,4,5,2,3,3]
// 0,1
// 0,1,1
// 0,1,1,2,1
// 0,1,1,2,1,2,2,3,1
// 0,1,1,2,1,2,2,3,1,2,2,3,2,3,3,4,1
