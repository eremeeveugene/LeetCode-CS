using LeetCode.Core.Models;

namespace LeetCode.Algorithms.LinkedListInBinaryTree;

/// <inheritdoc />
public class LinkedListInBinaryTreeKnuthMorrisPratt : ILinkedListInBinaryTree
{
    /// <summary>
    ///     Time complexity - O(n + l), where n is the length of the tree and l is the length of the linked list
    ///     Space complexity - O(n + l) for an unbalanced tree, O(log n + l) for a balanced tree, where n is the length of the
    ///     tree and l is the length of the linked list
    /// </summary>
    /// <param name="head"></param>
    /// <param name="root"></param>
    /// <returns></returns>
    public bool IsSubPath(ListNode head, TreeNode root)
    {
        var patternList = new List<int> { head.val };

        var prefixList = new List<int> { 0 };

        var patternIndex = 0;

        var currentListNode = head.next;

        while (currentListNode != null)
        {
            while (patternIndex > 0 && currentListNode.val != patternList[patternIndex])
            {
                patternIndex = prefixList[patternIndex - 1];
            }

            if (currentListNode.val == patternList[patternIndex])
            {
                patternIndex++;
            }

            patternList.Add(currentListNode.val);
            prefixList.Add(patternIndex);

            currentListNode = currentListNode.next;
        }

        return IsSubPath(root, 0, patternList, prefixList);
    }

    private static bool IsSubPath(TreeNode? treeNode, int patternIndex, List<int> patternList, List<int> prefixList)
    {
        if (treeNode == null)
        {
            return false;
        }

        while (patternIndex > 0 && treeNode.val != patternList[patternIndex])
        {
            patternIndex = prefixList[patternIndex - 1];
        }

        if (treeNode.val == patternList[patternIndex])
        {
            patternIndex++;
        }

        if (patternIndex == patternList.Count)
        {
            return true;
        }

        return IsSubPath(treeNode.left, patternIndex, patternList, prefixList) ||
               IsSubPath(treeNode.right, patternIndex, patternList, prefixList);
    }
}