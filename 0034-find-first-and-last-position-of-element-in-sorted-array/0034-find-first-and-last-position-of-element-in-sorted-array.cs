public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int first = FindFirst(nums, target);
        int last = FindLast(nums, target);
        return new int[] {first, last};
    }

    private int FindFirst(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        int index = -1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target) {
                index = mid;         // store the index
                right = mid - 1;     // keep going left
            } else if (nums[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return index;
    }

    private int FindLast(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        int index = -1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target) {
                index = mid;         // store the index
                left = mid + 1;      // keep going right
            } else if (nums[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return index;
    }
}
