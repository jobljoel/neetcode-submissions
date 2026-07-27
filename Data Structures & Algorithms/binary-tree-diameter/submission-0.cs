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
    private int maxDiameter = 0;

    public int DiameterOfBinaryTree(TreeNode root) {
        CalculateHeight(root);    
        return maxDiameter;
    }

    private int CalculateHeight(TreeNode node) {
        if (node == null) return 0;

        int leftHeight = CalculateHeight(node.left);
        int rightHeight = CalculateHeight(node.right);

        maxDiameter = Math.Max(maxDiameter, leftHeight + rightHeight);

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
