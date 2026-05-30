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

using LeetCode.Algorithms.ReplaceNonCoprimeNumbersInArray;

namespace LeetCode.Tests.Algorithms.ReplaceNonCoprimeNumbersInArray;

public abstract class ReplaceNonCoprimeNumbersInArrayTestsBase<T> where T : IReplaceNonCoprimeNumbersInArray, new()
{
    [TestMethod]
    [DataRow(new[] { 6, 4, 3, 2, 7, 6, 2 }, new[] { 12, 7, 6 })]
    [DataRow(new[] { 2, 2, 1, 1, 3, 3, 3 }, new[] { 2, 1, 1, 3 })]
    public void ReplaceNonCoprimes_WithNumsArray_ReplacesWithLCMUntilNoMorePairs(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReplaceNonCoprimes(nums).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}