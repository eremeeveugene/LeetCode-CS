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

using LeetCode.Algorithms.MajorityElement2;

namespace LeetCode.Tests.Algorithms.MajorityElement2;

public abstract class MajorityElement2TestsBase<T> where T : IMajorityElement2, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 3 }, new[] { 3 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 2, 2 }, new[] { 2 })]
    [DataRow(new[] { 1, 1, 1, 3, 3, 2, 2, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2, 3 }, new int[] { })]
    [DataRow(new[] { 0, 0, 0 }, new[] { 0 })]
    [DataRow(new[] { -1, -1, -1, 2, 2 }, new[] { -1 })]
    [DataRow(new[] { 5, 5, 5, 5 }, new[] { 5 })]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3 }, new[] { 3 })]
    [DataRow(new[] { 4, 4, 4, 5, 5, 5, 6 }, new[] { 4, 5 })]
    [DataRow(new[] { 7, 7, 7, 8, 8, 8, 9, 9, 9 }, new[] { 7, 8, 9 })]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, new int[] { })]
    [DataRow(new[] { -1000000000, -1000000000, 1000000000 }, new[] { -1000000000 })]
    [DataRow(new[] { 1000000000, 1000000000, 1000000000 }, new[] { 1000000000 })]
    [DataRow(new[] { 2, 2, 1, 1, 1, 2, 2 }, new[] { 2 })]
    [DataRow(new[] { 0, 1, 0, 1, 0 }, new[] { 0 })]
    [DataRow(new[] { -5, -5, -5, 3, 3, 3, 1 }, new[] { -5, 3 })]
    [DataRow(new[] { 8, 8, 8, 8, 1, 2, 3 }, new[] { 8 })]
    [DataRow(new[] { 6, 6, 6, 7, 7, 8, 8 }, new[] { 6 })]
    [DataRow(new[] { 9, 9, 8, 8, 7, 7, 9, 8 }, new[] { 8, 9 })]
    [DataRow(new[] { 3, 3, 3, 3, 3 }, new[] { 3 })]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 10, 10, 10, 20, 30, 40 }, new[] { 10 })]
    public void MajorityElement_WithIntegerArray_ReturnsElementsAboveOneThird(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MajorityElement(nums);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult.ToArray());
    }
}