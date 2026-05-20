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

using LeetCode.Algorithms.ValidElementsInAnArray;

namespace LeetCode.Tests.Algorithms.ValidElementsInAnArray;

public abstract class ValidElementsInAnArrayTestsBase<T> where T : IValidElementsInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 5, 5, 5, 5 }, new[] { 5, 5 })]
    [DataRow(new[] { 1, 2, 4, 2, 3, 2 }, new[] { 1, 2, 4, 3, 2 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 2, 1 }, new[] { 2, 1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, new[] { 5, 4, 3, 2, 1 })]
    [DataRow(new[] { 1, 1 }, new[] { 1, 1 })]
    [DataRow(new[] { 1, 1, 1 }, new[] { 1, 1 })]
    [DataRow(new[] { 1, 2, 2, 2, 1 }, new[] { 1, 2, 2, 1 })]
    [DataRow(new[] { 2, 1, 2 }, new[] { 2, 1, 2 })]
    [DataRow(new[] { 3, 1, 2 }, new[] { 3, 1, 2 })]
    [DataRow(new[] { 2, 1, 3 }, new[] { 2, 3 })]
    [DataRow(new[] { 4, 2, 5, 1, 3 }, new[] { 4, 5, 3 })]
    [DataRow(new[] { 3, 5, 4, 2, 1 }, new[] { 3, 5, 4, 2, 1 })]
    [DataRow(new[] { 1, 3, 2, 5, 4 }, new[] { 1, 3, 5, 4 })]
    [DataRow(new[] { 10, 1, 9, 2, 8, 3 }, new[] { 10, 9, 8, 3 })]
    [DataRow(new[] { 1, 100, 50, 99, 2 }, new[] { 1, 100, 99, 2 })]
    [DataRow(new[] { 100, 1, 1, 1, 100 }, new[] { 100, 1, 100 })]
    [DataRow(new[] { 2, 3, 3, 1, 4, 4, 2 }, new[] { 2, 3, 4, 4, 2 })]
    public void FindValidElements_WithGivenNums_ReturnsElementsGreaterThanAllLeftOrRightOrEdgeElements(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindValidElements(nums).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}