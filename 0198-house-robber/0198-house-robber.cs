public class Solution {
    public int Rob(int[] nums) {
        int houseOne = 0 , houseTwo = 0;

        foreach(var m in nums){
            int currA = Math.Max(houseOne+m, houseTwo);
            houseOne = houseTwo;
            houseTwo = currA;
        }
        return houseTwo;
    }
}