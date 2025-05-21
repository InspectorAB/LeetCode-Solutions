public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        var res = new List<IList<int>>();
        var subset = new List<int>();
        Array.Sort(nums);
        Dfs(nums, 0, subset, res);
        return res;
    }

    private void Dfs(int[] nums, int index, List<int> subset, List<IList<int>> res) {
        res.Add(new List<int>(subset));
    
        for (int i = index; i < nums.Length; i++) {
            if (i > index && nums[i] == nums[i - 1]) continue;  // skip duplicates
            subset.Add(nums[i]);
            Dfs(nums, i + 1, subset, res);
            subset.RemoveAt(subset.Count - 1);
        }
    }
}