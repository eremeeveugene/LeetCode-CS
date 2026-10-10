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

using LeetCode.Algorithms.DivideArrayIntoEqualPairs;

namespace LeetCode.Tests.Algorithms.DivideArrayIntoEqualPairs;

public abstract class DivideArrayIntoEqualPairsTestsBase<T> where T : IDivideArrayIntoEqualPairs, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 3, 2, 2, 2 }, true)]
    [DataRow(new[] { 1, 2, 3, 4 }, false)]
    [DataRow(new[] { 1, 1 }, true)]
    [DataRow(new[] { 500, 500 }, true)]
    [DataRow(new[] { 1, 2 }, false)]
    [DataRow(new[] { 1, 1, 1, 1 }, true)]
    [DataRow(new[] { 1, 1, 1, 2 }, false)]
    [DataRow(new[] { 1, 2, 1, 2 }, true)]
    [DataRow(new[] { 5, 5, 5, 5, 5, 5 }, true)]
    [DataRow(new[] { 4, 4, 4, 4, 2, 2 }, true)]
    [DataRow(new[] { 8, 9 }, false)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 4, 3, 2, 1 }, true)]
    [DataRow(new[] { 100, 200, 100, 200, 100, 300 }, false)]
    [DataRow(new[] { 500, 1, 500, 1, 250, 250 }, true)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2, 2, 2 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, false)]
    [DataRow(new[] { 9, 9, 8, 8, 7, 7, 6, 6, 5, 5 }, true)]
    [DataRow(new[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }, true)]
    [DataRow(new[] { 10, 20, 10, 20, 10, 20, 10, 30 }, false)]
    public void DivideArray_WithGivenIntegerArray_ReturnsTrueIfPairsCanBeFormedOtherwiseFalse(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DivideArray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}