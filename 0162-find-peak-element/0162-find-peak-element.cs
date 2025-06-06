public class Solution {
    public int FindPeakElement(int[] nums) {
        
        int left = 0;
        int right = nums.Length -1;
        while(left < right){
            int mid = (left+right)/2;

            if(nums[mid] < nums[mid + 1]){
                left = mid + 1;
            }else if(nums[mid] > nums[mid + 1]){
                right = mid;
            }

        }

        return left;
    }
}