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

        List<List<int>> output = new();

        
        VisitNode(root,0, output);

        return output;

    }

    public void VisitNode(TreeNode n, int depth, List<List<int>> output){

        if (n==null)
            return;

          List<int> list;

          if (output.Count <= depth)  {
              list = new List<int>();
              output.Add(list); 
          }
          else {
               list = output[depth];
          }
        
          list.Add(n.val);

          VisitNode(n.left,depth+1, output);
          VisitNode(n.right,depth+1, output);

    }
}
