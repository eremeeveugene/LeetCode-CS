﻿// --------------------------------------------------------------------------------
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
using LeetCode.Core.Extensions;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.IntersectionOfTwoLinkedLists;

public abstract class IntersectionOfTwoLinkedListsTestsBase<T> where T : IIntersectionOfTwoLinkedLists, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 1 }, new[] { 5, 6, 1 }, new[] { 8, 4, 5 }, new[] { 8, 4, 5 })]
    [DataRow(new[] { 1, 9, 1 }, new[] { 3 }, new[] { 2, 4 }, new[] { 2, 4 })]
    [DataRow(new[] { 2, 6, 4 }, new[] { 1, 5 }, new int[] { }, new int[] { })]
    public void GetIntersectionNode_WithTwoLinkedLists_ReturnsIntersectionNode(int[] aHeadArray, int[] bHeadArray,
        int[] intersectArray, int[] expectedResultArray)
    {
        // Arrange
        var intersect = intersectArray.ToListNode();

        var headA = aHeadArray.ToListNode();

        if (headA != null)
        {
            headA.next = intersect;
        }

        var headB = bHeadArray.ToListNode();

        if (headB != null)
        {
            headB.next = intersect;
        }

        var expectedResult = expectedResultArray.ToListNode();

        var solution = new T();

        // Act
        var actualResult = solution.GetIntersectionNode(headA, headB);

        // Assert
        AssertExtensions.AreListNodesEqual(expectedResult, actualResult);
    }
}