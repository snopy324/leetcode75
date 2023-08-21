namespace leetcode75.Leetcode.TwoPointers;
public class Max_Operations
{
    public int MaxOperations(int[] nums, int k)
    {
        Dictionary<int, int> pairs = new Dictionary<int, int>();
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int m = nums[i];
            int p = k - m;

            int pt = 0;
            if (pairs.TryGetValue(p, out pt))
            {
                pairs.Remove(p);
            }


            int mt = 0;
            if (pairs.TryGetValue(m, out mt))
            {
                pairs.Remove(m);
            }


            if (pt > 0)
            {
                pairs.Add(p, pt - 1);
                result++;
            }
            else
            {
                pairs.Add(m, mt + 1);
            }
        }

        return result;
    }
}

// Example 1:

// Input: nums = [1,2,3,4], k = 5
// Output: 2
// Explanation: Starting with nums = [1,2,3,4]:
// - Remove numbers 1 and 4, then nums = [2,3]
// - Remove numbers 2 and 3, then nums = []
// There are no more pairs that sum up to 5, hence a total of 2 operations.
// Example 2:

// Input: nums = [3,1,3,4,3], k = 6
// Output: 1
// Explanation: Starting with nums = [3,1,3,4,3]:
// - Remove the first two 3's, then nums = [1,4,3]
// There are no more pairs that sum up to 6, hence a total of 1 operation.
