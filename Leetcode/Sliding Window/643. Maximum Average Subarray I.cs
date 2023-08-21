namespace leetcode75.Leetcode.Sliding_Window;
public class Find_Max_Average
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            int current = 0;
            int max = 0;

            for (int i = 0; i < k; i++)
            {
                current += nums[i];
            }
            max = current;

            for (int i = k; i < nums.Length; i++)
            {
                current = current + nums[i] - nums[i - k];
                if (nums[i] > nums[i - k])
                {
                    max = current > max ? current : max;
                }
            }

            return (double)max / k;
        }
    }