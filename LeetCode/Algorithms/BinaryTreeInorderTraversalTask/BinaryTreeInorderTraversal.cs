using LeetCode.Core.Models;

namespace LeetCode.Algorithms.BinaryTreeInorderTraversalTask;

public static class BinaryTreeInorderTraversal
{
    public static IList<int>? GetResult(TreeNode? treeNode)
    {
        if (treeNode == null) return new List<int>();

        return InOrderTraversal(treeNode);
    }

    private static List<int> InOrderTraversal(TreeNode treeNode)
    {
        var res = new List<int>();

        var left = new List<int>();

        if (treeNode.left != null) left = InOrderTraversal(treeNode.left);

        res.AddRange(left);
        res.Add(treeNode.val);

        var right = new List<int>();

        if (treeNode.right != null) right = InOrderTraversal(treeNode.right);

        res.AddRange(right);

        return res;
    }
}