namespace leetcode75.Leetcode.ArrayString;
public class CanPlaceFlowersC
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        bool isPositionGood(int i)
        {
            if (i == -1) return true;
            if (i == flowerbed.Length) return true;
            return flowerbed[i] == 0;
        }

        var c = 0;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (isPositionGood(i - 1) && isPositionGood(i) && isPositionGood(i + 1))
            {
                flowerbed[i] = 1;
                c++;
            }

            if (c >= n) return true;
        }

        return false;
    }
}