using LeetCode.Core.Models;

namespace LeetCode.Algorithms.FindModeInBinarySearchTree;

/// <inheritdoc />
public class FindModeInBinarySearchTreeBreadthFirstSearch : IFindModeInBinarySearchTree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int[] FindMode(TreeNode? root)
    {
        if (root == null)
        {
            return [];
        }

        var dictionary = new Dictionary<int, int>();

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var treeNode = queue.Dequeue();

            if (!dictionary.TryAdd(treeNode.val, 1))
            {
                dictionary[treeNode.val]++;
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

        var maxValue = dictionary.Values.Max();

        return dictionary.Where(i => i.Value == maxValue).Select(i => i.Key).ToArray();
    }
}