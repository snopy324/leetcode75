using System.Text;

namespace leetcode75.Leetcode.ArrayString
{
    public class MergeStringAlternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            var oneIsbigger = word1.Length >  word2.Length;
            var longer = oneIsbigger ? word1 : word2; 
            var shorter = !oneIsbigger ? word1 : word2; 
            for (int i = 0; i < shorter.Length; i++)
            {
                sb.Append(word1[i]);
                sb.Append(word2[i]);
            }
            for (int i = shorter.Length; i < longer.Length; i++)
            {
                sb.Append(longer[i]);
            }

            return sb.ToString();
        }
    }
}