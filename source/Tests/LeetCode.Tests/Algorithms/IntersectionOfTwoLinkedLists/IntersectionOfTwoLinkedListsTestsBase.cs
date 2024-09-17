// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.IntersectionOfTwoLinkedLists;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.IntersectionOfTwoLinkedLists;

public abstract class IntersectionOfTwoLinkedListsTestsBase<T> where T : IIntersectionOfTwoLinkedLists, new()
{
    [TestMethod]
    [DataRow("[4, 1]", "[5, 6, 1]", "[8, 4, 5]", "[8, 4, 5]")]
    [DataRow("[1, 9, 1]", "[3]", "[2, 4]", "[2, 4]")]
    [DataRow("[2, 6, 4]", "[1, 5]", "[]", "[]")]
    [DataRow("[1, 2, 3]", "[4, 5]", "[6]", "[6]")]
    [DataRow("[1]", "[2]", "[3, 4]", "[3, 4]")]
    [DataRow("[]", "[1, 2, 3]", "[]", "[]")]
    [DataRow("[1, 2, 3]", "[]", "[]", "[]")]
    [DataRow("[]", "[]", "[]", "[]")]
    [DataRow("[1, 2]", "[3, 4]", "[5, 6, 7]", "[5, 6, 7]")]
    public void GetIntersectionNode_WithTwoLinkedLists_ReturnsIntersectionNode(string headAJsonArray,
        string headBJsonArray, string intersectJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var intersectArray = JsonHelper<int>.DeserializeToArray(intersectJsonArray);
        var intersect = ListNode.ToListNode(intersectArray);

        var headAArray = JsonHelper<int>.DeserializeToArray(headAJsonArray);
        var headA = ListNode.ToListNode(headAArray);

        if (headA != null)
        {
            headA.next = intersect;
        }

        var headBArray = JsonHelper<int>.DeserializeToArray(headBJsonArray);
        var headB = ListNode.ToListNode(headBArray);

        if (headB != null)
        {
            headB.next = intersect;
        }

        var expectedResultArray = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.GetIntersectionNode(headA, headB);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}