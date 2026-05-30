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