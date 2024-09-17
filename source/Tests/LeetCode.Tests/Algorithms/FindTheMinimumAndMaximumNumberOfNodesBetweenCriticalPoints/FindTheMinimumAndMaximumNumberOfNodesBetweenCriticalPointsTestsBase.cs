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
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints;

public abstract class FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPointsTestsBase<T>
    where T : IFindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints, new()
{
    [TestMethod]
    [DataRow("[3, 1]", "[-1, -1]")]
    [DataRow("[5, 3, 1, 2, 5, 1, 2]", "[1, 3]")]
    [DataRow("[1, 3, 2, 2, 3, 2, 2, 2, 7]", "[3, 3]")]
    public void NodesBetweenCriticalPoints_WithValidInputs_ReturnsExpectedResults(string headJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var headArray = JsonHelper<int>.DeserializeToArray(headJsonArray);
        var head = ListNode.ToListNode(headArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.NodesBetweenCriticalPoints(head);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}