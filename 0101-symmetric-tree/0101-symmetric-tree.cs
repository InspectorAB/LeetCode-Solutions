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
    public bool IsSymmetric(TreeNode root) {
        return DFS(root.left,root.right);
        
    }

    public bool DFS(TreeNode rootleft, TreeNode rootright){
        if(rootright == null && rootleft == null) return true;

        if(rootleft == null || rootright == null) return false;

        if(rootleft.val != rootright.val){
            return false;
        }
        
        bool left = DFS(rootleft.left,rootright.right);
        bool right = DFS(rootleft.right,rootright.left);

        return(left && right) ? true : false;
    }
}