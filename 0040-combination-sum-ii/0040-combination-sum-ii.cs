public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<IList<int>>();
        var current = new List<int>();
        Array.Sort(candidates);
        Backtrack(candidates, target, 0, current, result);
        //Array.Sort(result);
        return result;
    }

    private void Backtrack(int[] candidates, int target, int index, List<int> current, List<IList<int>> result) {
        if (target == 0) {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = index; i < candidates.Length; i++) {
            if (candidates[i] <= target) {
                if (i > index && candidates[i] == candidates[i - 1]) continue;
                current.Add(candidates[i]);
                Backtrack(candidates, target - candidates[i], i+1, current, result); // not i + 1 because we can reuse same element
                current.RemoveAt(current.Count - 1); // backtrack
            }
        }
    }
}
