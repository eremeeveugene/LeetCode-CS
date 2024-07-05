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

using LeetCode.Algorithms.FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints;

public abstract class FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPointsTestsBase<T>
    where T : IFindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 1 }, new[] { -1, -1 })]
    [DataRow(new[] { 5, 3, 1, 2, 5, 1, 2 }, new[] { 1, 3 })]
    [DataRow(new[] { 1, 3, 2, 2, 3, 2, 2, 2, 7 }, new[] { 3, 3 })]
    public void NodesBetweenCriticalPoints_WithValidInputs_ReturnsExpectedResults(int[] array1, int[] expectedResult)
    {
        // Arrange
        var head = ListNode.ToListNode(array1);

        var solution = new T();

        // Act
        var actualResult = solution.NodesBetweenCriticalPoints(head);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}