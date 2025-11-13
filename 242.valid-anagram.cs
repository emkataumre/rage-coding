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
        char[] arrayS = s.ToCharArray();
        char[] arrayT = t.ToCharArray();

        Array.Sort(arrayS);
        Array.Sort(arrayT);

        if (arrayS.Length != arrayT.Length)
            return false;

        for (int i = 0; i < arrayS.Length; i++)
        {
            if (arrayS[i] != arrayT[i])
                return false;
        }

        return true;
    }
}
// @lc code=end
