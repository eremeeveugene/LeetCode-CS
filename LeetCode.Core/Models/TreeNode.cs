namespace LeetCode.Core.Models;

/// <summary>
/// Definition for a binary tree node
/// </summary>
public class TreeNode
{
    public TreeNode? left;
    public TreeNode? right;
    public int val;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static TreeNode BuildTree(IList<int?> nums)
    {
        if (!nums.Any() || nums[0] == null) return new TreeNode();

        TreeNode root = new TreeNode(nums[0].Value);

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 1;

        while (queue.Count > 0 && i < nums.Count)
        {
            TreeNode current = queue.Dequeue();

            // Process the left child
            if (i < nums.Count && nums[i].HasValue)
            {
                current.left = new TreeNode(nums[i].Value);
                queue.Enqueue(current.left);
            }
            i++;

            // Process the right child
            if (i < nums.Count && nums[i].HasValue)
            {
                current.right = new TreeNode(nums[i].Value);
                queue.Enqueue(current.right);
            }
            i++;
        }

        return root;
    }
}