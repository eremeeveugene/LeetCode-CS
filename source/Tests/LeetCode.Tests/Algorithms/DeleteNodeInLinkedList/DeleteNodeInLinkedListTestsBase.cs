// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.DeleteNodeInLinkedList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DeleteNodeInLinkedList;

public abstract class DeleteNodeInLinkedListTestsBase<T> where T : IDeleteNodeInLinkedList, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void DeleteNode_GivenNonTailNode_RemovesNodeFromList(ListNode head, ListNode nodeToDelete, int[] expectedResultArray)
    {
        // Arrange
        var expectedResult = ListNode.ToListNodeOrThrow(expectedResultArray);

        var solution = new T();

        // Act
        solution.DeleteNode(nodeToDelete);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, head);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        var head1 = new ListNode(1, new ListNode(2));

        yield return [head1, head1, new[] { 2 }];

        var head2 = new ListNode(4, new ListNode(5, new ListNode(1, new ListNode(9))));

        yield return [head2, head2, new[] { 5, 1, 9 }];

        var node3 = new ListNode(5, new ListNode(1, new ListNode(9)));

        yield return [new ListNode(4, node3), node3, new[] { 4, 1, 9 }];

        var node4 = new ListNode(1, new ListNode(9));

        yield return [new ListNode(4, new ListNode(5, node4)), node4, new[] { 4, 5, 9 }];

        var head5 = new ListNode(1, new ListNode(2, new ListNode(1, new ListNode(3))));

        yield return [head5, head5, new[] { 2, 1, 3 }];

        var head6 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

        yield return [head6, head6, new[] { 2, 3, 4, 5 }];

        var node7 = new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))));

        yield return [new ListNode(1, node7), node7, new[] { 1, 3, 4, 5 }];

        var node8 = new ListNode(3, new ListNode(4, new ListNode(5)));

        yield return [new ListNode(1, new ListNode(2, node8)), node8, new[] { 1, 2, 4, 5 }];

        var node9 = new ListNode(4, new ListNode(5));

        yield return [new ListNode(1, new ListNode(2, new ListNode(3, node9))), node9, new[] { 1, 2, 3, 5 }];

        var head10 = new ListNode(0, new ListNode(0, new ListNode()));

        yield return [head10, head10, new[] { 0, 0 }];

        var node11 = new ListNode(0, new ListNode());

        yield return [new ListNode(0, node11), node11, new[] { 0, 0 }];

        var head12 = new ListNode(-1, new ListNode(-2, new ListNode(-3)));

        yield return [head12, head12, new[] { -2, -3 }];

        var node13 = new ListNode(-2, new ListNode(-3));

        yield return [new ListNode(-1, node13), node13, new[] { -1, -3 }];

        var head14 = new ListNode(7, new ListNode(8));

        yield return [head14, head14, new[] { 8 }];

        var node15 = new ListNode(2, new ListNode(3));

        yield return [new ListNode(1, node15), node15, new[] { 1, 3 }];

        var node16 = new ListNode(20, new ListNode(30));

        yield return [new ListNode(10, node16), node16, new[] { 10, 30 }];

        var node17 = new ListNode(7, new ListNode(8, new ListNode(9)));

        yield return [new ListNode(5, new ListNode(6, node17)), node17, new[] { 5, 6, 8, 9 }];

        var node18 = new ListNode(8, new ListNode(7, new ListNode(6)));

        yield return [new ListNode(9, node18), node18, new[] { 9, 7, 6 }];

        var node19 = new ListNode(300, new ListNode(400));

        yield return [new ListNode(100, new ListNode(200, node19)), node19, new[] { 100, 200, 400 }];

        var node20 = new ListNode(0, new ListNode(5));

        yield return [new ListNode(-5, node20), node20, new[] { -5, 5 }];

        var node21 = new ListNode(3, new ListNode(2));

        yield return [new ListNode(2, new ListNode(2, node21)), node21, new[] { 2, 2, 2 }];

        var head22 = new ListNode(1, new ListNode(1, new ListNode(2)));

        yield return [head22, head22, new[] { 1, 2 }];

        var node23 = new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1))));

        yield return [new ListNode(6, new ListNode(5, node23)), node23, new[] { 6, 5, 3, 2, 1 }];
    }
}