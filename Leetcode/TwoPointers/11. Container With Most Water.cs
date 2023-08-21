namespace leetcode75.Leetcode.TwoPointers;
public class Max_Area
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int max = 0;
        int left_h, right_h, p;

        while (right > left)
        {
            left_h = height[left];
            right_h = height[right];

            if (left_h > right_h)
            {
                p = (right - left) * right_h;
                right--;
            }
            else
            {
                p = (right - left) * left_h;
                left++;
            }

            if (p > max)
            {
                max = p;
            }
        }

        return max;
    }
}

// Example 1:


// Input: height = [1,8,6,2,5,4,8,3,7]
// Output: 49
// Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
// Example 2:

// Input: height = [1,1]
// Output: 1
