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
        IList<IList<int>> result = new List<IList<int>>();

    public IList<IList<int>> LevelOrder(TreeNode root) {
                DFS(root,0);
        return result;
    }
    private void DFS(TreeNode node, int lvl)
    {
        if(node == null) return ;
        if (result.Count() == lvl)
        {
            result.Add(new List<int>());
        }
        result[lvl].Add(node.val);
        ++lvl;
        if (node.left != null)
            DFS(node.left, lvl);
        if (node.right != null)
            DFS(node.right, lvl);
        return;
    }
    }
