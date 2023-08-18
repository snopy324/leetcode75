using System.Text;

namespace leetcode75.Leetcode.ArrayString
{
    public class GreatestCommonDivisorofStrings
    {
        public string GcdOfStrings(string str1, string str2)
        {
            string anw = string.Empty;

            bool isChild(string tar, StringBuilder src, StringBuilder v)
            {
                v.Clear();

                for (int j = 0; j < tar.Length / src.Length; j++)
                {
                    v.Append(src.ToString());
                }

                return tar == v.ToString();
            }

            int gcd(int m, int n)
            {
                if (n == 0)
                {
                    return m;
                }
                else
                {
                    return gcd(n, m % n);
                }
            }

            var shorter = str1.Length < str2.Length ? str1 : str2;
            StringBuilder @base = new StringBuilder(shorter.Length);
            StringBuilder verify = new StringBuilder();
            for (int i = 0; i < shorter.Length; i++)
            {
                @base.Append(shorter[i]);

                if (isChild(str1, @base, verify) && isChild(str2, @base, verify))
                {
                    anw = @base.ToString();
                    break;
                }
            }

            if (anw.Length > 0)
            {
                var m = gcd(str1.Length, str2.Length);

                for (int i = 0; i < (m / anw.Length) - 1; i++)
                {
                    @base.Append(anw);
                }

                anw = @base.ToString();
            }

            return anw;
        }
    }
}