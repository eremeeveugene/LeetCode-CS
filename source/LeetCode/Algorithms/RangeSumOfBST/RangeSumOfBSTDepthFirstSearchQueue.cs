using LeetCode.Core.Models;

namespace LeetCode.Algorithms.RangeSumOfBST;

/// <inheritdoc />
public class RangeSumOfBSTDepthFirstSearchQueue : IRangeSumOfBST
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <param name="low"></param>
    /// <param name="high"></param>
    /// <returns></returns>
    public int RangeSumBST(TreeNode? root, int low, int high)
    {
        if (root == null)
        {
            return 0;
        }

        var result = 0;

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var treeNode = queue.Dequeue();

            if (treeNode.val >= low && treeNode.val <= high)
            {
                result += treeNode.val;
            }

            if (treeNode.left != null)
            {
                queue.Enqueue(treeNode.left);
            }

            if (treeNode.right != null)
            {
                queue.Enqueue(treeNode.right);
            }
        }

        return result;
    }
}