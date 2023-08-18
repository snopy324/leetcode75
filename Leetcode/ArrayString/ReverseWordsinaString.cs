// Example 1:

// Input: s = "the sky is blue"
// Output: "blue is sky the"
// Example 2:

// Input: s = "  hello world  "
// Output: "world hello"
// Explanation: Your reversed string should not contain leading or trailing spaces.
// Example 3:

// Input: s = "a good   example"
// Output: "example good a"
// Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.

using System.Text;

namespace leetcode75.Leetcode.ArrayString
{
    public class ReverseWordsinaStrings
    {
        public string ReverseWords(string s)
        {
            StringBuilder list = new StringBuilder();
            StringBuilder word = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    word.Append(s[i]);
                }
                else if (word.Length > 0)
                {
                    list.Insert(0, ' ' + word.ToString());
                    word.Clear();
                }
            }

            if (word.Length > 0)
            {
                list.Insert(0, ' ' + word.ToString());
                word.Clear();
            }

            return list.ToString().TrimStart();
        }
    }

}