/*
 * @lc app=leetcode id=217 lang=csharp
 *
 * [217] Contains Duplicate
 */

// @lc code=start
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                seen.Add(nums[i]);
            }
        }

        return false;
    }
}
// @lc code=end
