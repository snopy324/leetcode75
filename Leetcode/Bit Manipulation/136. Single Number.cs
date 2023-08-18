public class Single_Number
{
    public int SingleNumber(int[] nums)
    {
        HashSet<int> hash = new HashSet<int>();

        foreach (var n in nums)
        {
            if (hash.Contains(n))
            {
                hash.Remove(n);
                continue;
            }

            hash.Add(n);
        }
        
        return hash.ToArray().First();
    }
}