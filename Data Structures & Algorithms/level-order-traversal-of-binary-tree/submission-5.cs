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
        List<List<int>> outList = new();

        if (root == null)
            return outList;

        Queue<TreeNode> q = new();
        
        q.Enqueue(root);

        while (q.Count>0){

            int levelCount = q.Count; // for for loop, get all children for next level
            List<int> levelList = new();
            for (int i =0; i < levelCount; i++){
                 TreeNode tn = q.Dequeue();
                 if (tn.left != null)   
                    q.Enqueue(tn.left);
                 if (tn.right != null)   
                    q.Enqueue(tn.right);

                 levelList.Add(tn.val);
            }
            // we have all the nodes for this level
            outList.Add(levelList);
        }

        return outList;

        }
}
