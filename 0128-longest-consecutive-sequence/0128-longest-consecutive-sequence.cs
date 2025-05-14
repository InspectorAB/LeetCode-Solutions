public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> s = new HashSet<int>();

        for(int i = 0; i < nums.Length;i++){            
            s.Add(nums[i]);            
        }

        int maxLength = 0;
        foreach( int num in s ){
            if (!s.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentLength = 1;

                    // Count consecutive numbers starting from currentNum
                    while (s.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentLength++;
                    }

                    // Update the maxLength with the longest found
                    maxLength = Math.Max(maxLength, currentLength);
                }
        }
        return maxLength;
    }
}