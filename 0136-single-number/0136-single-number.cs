public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;
        foreach(int a in nums){
            result ^= a;
        }
        return result;
    }
}