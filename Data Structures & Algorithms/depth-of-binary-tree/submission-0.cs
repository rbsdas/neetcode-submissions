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
    public int MaxDepth(TreeNode root) {
            if (root == null) {
                //Log($"Reached leaf node, returning depth 0");
                return 0;
            }

            //Log($"Visiting node: {root.val}");
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            int depth = Math.Max(leftDepth, rightDepth) + 1;// Calculate max depth
            //Log($"Node: {root.val}, Left Depth: {leftDepth}, Right Depth: {rightDepth}, Returning Depth: {depth}");

            return depth;
    }
}
