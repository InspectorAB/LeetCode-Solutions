/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var res = new List<IList<int>>();
        DFS(0, res,root);
        return res;
    }

    public void DFS(int start,List<IList<int>> res,TreeNode root){

        if (root == null) return;

        if (res.Count == start) {
            res.Add(new List<int>());
        }
        if (start % 2 == 0) {
            res[start].Add(root.val);
        } else {
            res[start].Insert(0, root.val);
        }

        DFS(start+1,res,root.left);
        DFS(start+1,res,root.right);
    }


}