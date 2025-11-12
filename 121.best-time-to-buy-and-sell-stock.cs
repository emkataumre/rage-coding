/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length <= 1)
        {
            return 0;
        }

        int maxProfit = 0;
        int minPrice = int.MaxValue;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                int profit = prices[i] - minPrice;
                maxProfit = Math.Max(profit, maxProfit);
            }
        }
        return maxProfit;
    }
}
// @lc code=end
