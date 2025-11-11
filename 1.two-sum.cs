public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> answers = new Dictionary<int, int>();

        for (int i = 0; i <= nums.Length; i++)
        {
            int wanted = target - nums[i];

            if (answers.ContainsKey(wanted))
            {
                int[] result = { i, answers[wanted] };
                return result;
            }
            else
            {
                answers.TryAdd(nums[i], i);
            }
        }
        return null;
    }
}
