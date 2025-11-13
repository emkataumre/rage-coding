/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
using System.Security.Cryptography.X509Certificates;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        char[] arrayS = s.ToCharArray();
        char[] arrayT = t.ToCharArray();

        Array.Sort(arrayS);
        Array.Sort(arrayT);

        return arrayS.SequenceEqual(arrayT);
    }
}
// @lc code=end
