using LeetCode.Core.Models;

namespace LeetCode.Algorithms.RangeSumOfBST;

/// <inheritdoc />
public class RangeSumOfBSTBreadthFirstSearch : IRangeSumOfBST
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(h), where h is the height of the tree
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

        var stack = new Stack<TreeNode>();

        stack.Push(root);

        while (stack.Count > 0)
        {
            var treeNode = stack.Pop();

            if (treeNode.val >= low && treeNode.val <= high)
            {
                result += treeNode.val;
            }

            if (treeNode.left != null)
            {
                stack.Push(treeNode.left);
            }

            if (treeNode.right != null)
            {
                stack.Push(treeNode.right);
            }
        }

        return result;
    }
}