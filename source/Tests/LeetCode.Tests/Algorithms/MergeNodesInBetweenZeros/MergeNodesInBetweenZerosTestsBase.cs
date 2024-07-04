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

using LeetCode.Algorithms.MergeNodesInBetweenZeros;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.MergeNodesInBetweenZeros;

public abstract class MergeNodesInBetweenZerosTestsBase<T> where T : IMergeNodesInBetweenZeros, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 3, 1, 0, 4, 5, 2, 0 }, new[] { 4, 11 })]
    [DataRow(new[] { 0, 1, 0, 3, 0, 2, 2, 0 }, new[] { 1, 3, 4 })]
    [DataRow(new[] { 0, 200, 300, 0, 400, 500, 0 }, new[] { 500, 900 })]
    public void MergeNodes_WithVariousHeadArrays_ReturnsCorrectMergedNodes(int[] headArray, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.MergeNodes(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}