/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        return MaxSubArrayHelper(nums, 0, nums.Length - 1);
    }

    private int MaxSubArrayHelper(int[] nums, int left, int right)
    {
        int mid = left + (right - left) / 2;

        if (left == right)
        {
            return nums[left];
        }

        int leftMax = int.MinValue;
        int sum = 0;

        for (int i = mid; i >= left; i--)
        {
            sum = sum + nums[i];
            if (sum > leftMax)
            {
                leftMax = sum;
            }
        }
        ;

        int rightMax = int.MinValue;
        sum = 0;

        for (int i = mid + 1; i <= right; i++)
        {
            sum = sum + nums[i];
            if (sum > rightMax)
            {
                rightMax = sum;
            }
        }

        int crossSum = leftMax + rightMax;

        int leftSum = MaxSubArrayHelper(nums, left, mid);
        int rightSum = MaxSubArrayHelper(nums, mid + 1, right);

        return Math.Max(Math.Max(leftSum, rightSum), crossSum);
    }
}
// @lc code=end
