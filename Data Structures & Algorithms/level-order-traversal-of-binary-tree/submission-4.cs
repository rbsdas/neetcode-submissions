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
    public List<List<int>> LevelOrder(TreeNode root) {                
        var result = new List<List<int>>();
        if(root == null) return result;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0){
            int n = q.Count;
            var list = new List<int>();

            for(var i = 0; i < n; i++){
                var node = q.Dequeue();
                list.Add(node.val);
                if(node.left != null){
                    q.Enqueue(node.left);
                }

                if(node.right != null){
                    q.Enqueue(node.right);
                }
            }

            result.Add(list);
        }

        return result;
    }
}
