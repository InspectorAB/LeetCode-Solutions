public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        var current = new List<int>();
        Backtrack(candidates, target, 0, current, result);
        return result;
    }

    private void Backtrack(int[] candidates, int target, int index, List<int> current, List<IList<int>> result) {
        if (target == 0) {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = index; i < candidates.Length; i++) {
            if (candidates[i] <= target) {
                current.Add(candidates[i]);
                Backtrack(candidates, target - candidates[i], i, current, result); // not i + 1 because we can reuse same element
                current.RemoveAt(current.Count - 1); // backtrack
            }
        }
    }
}
