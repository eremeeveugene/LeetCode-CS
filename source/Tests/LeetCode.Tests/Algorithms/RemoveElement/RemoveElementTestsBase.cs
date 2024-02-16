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

using LeetCode.Algorithms.RemoveElement;

namespace LeetCode.Tests.Algorithms.RemoveElement;

public abstract class RemoveElementTestsBase<T> where T : IRemoveElement, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 2, 3 }, 3, new[] { 2, 2 }, 2)]
    [DataRow(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new[] { 0, 1, 4, 0, 3 }, 5)]
    public void RemoveElement_WithArrayAndValue_ReturnsModifiedArrayAndNewLength(int[] nums, int val,
        int[] expectedNums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveElement(nums, val);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        CollectionAssert.AreEquivalent(expectedNums, nums.Take(actualResult).ToArray());
    }
}