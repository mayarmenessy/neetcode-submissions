public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (freq.ContainsKey(complement))
            {
                return new int[] { freq[complement], i };
            }

            freq[nums[i]] = i;
        }

        return new int[] { };
    }
}

