/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
import java.util.ArrayList;

class Solution {
    public TreeNode searchBST(TreeNode root, int val) {
        var queue = new ArrayList<TreeNode>() {{ add(root); }};

        do {
            var item = queue.remove(queue.size() - 1);
            if (item.val == val) {
                return item;
            }

            if (item.left != null) {
                queue.add(item.left);
            }

            if (item.right != null) {
                queue.add(item.right);
            }
        } while (!queue.isEmpty());

        return null;
    }
}
