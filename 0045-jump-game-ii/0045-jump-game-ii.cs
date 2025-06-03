public class Solution {
    public int Jump(int[] nums) {
        if (nums.Length <= 1) return 0;
            int start = 0, end = 0;
            int count = 0;

            while (end < nums.Length)
            {
                count++;
                int maxEnd = 0;
                for (int i = start; i <= end; i++)
                {
                    maxEnd = Math.Max(maxEnd, i + nums[i]);
                }
                if (maxEnd >= nums.Length - 1) return count;
                start = end + 1;
                end = maxEnd;
            }

            return count;
    }
}