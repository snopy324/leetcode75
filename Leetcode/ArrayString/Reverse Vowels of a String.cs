using System.Collections.Generic;
using System.Text;

namespace leetcode75.Leetcode.ArrayString;
public class ReverseVowelsofaString
{
    public string ReverseVowels(string s)
    {
        StringBuilder sb = new StringBuilder(s);
        Queue<char> q = new Queue<char>();
        Stack<int> st = new Stack<int>();
        HashSet<char> vowels = new HashSet<char> { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
        for (int i = 0; i < sb.Length; i++)
        {
            if (vowels.Contains(sb[i]))
            {
                q.Enqueue(sb[i]);
                st.Push(i);
                sb[i] = '_';
            }
        }

        while (st.Count > 0)
        {
            sb[st.Pop()] = q.Dequeue();
        }

        return sb.ToString();
    }
}