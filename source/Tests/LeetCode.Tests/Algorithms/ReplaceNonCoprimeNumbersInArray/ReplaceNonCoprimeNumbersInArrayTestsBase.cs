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
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 2 }, new[] { 2 })]
    [DataRow(new[] { 2, 2 }, new[] { 2 })]
    [DataRow(new[] { 1, 1 }, new[] { 1, 1 })]
    [DataRow(new[] { 7, 7, 7 }, new[] { 7 })]
    [DataRow(new[] { 2, 3, 5, 7 }, new[] { 2, 3, 5, 7 })]
    [DataRow(new[] { 6, 10, 15 }, new[] { 30 })]
    [DataRow(new[] { 3, 9, 27, 81 }, new[] { 81 })]
    [DataRow(new[] { 100000 }, new[] { 100000 })]
    [DataRow(new[] { 100000, 100000 }, new[] { 100000 })]
    [DataRow(new[] { 2, 4, 8, 16, 32, 64 }, new[] { 64 })]
    [DataRow(new[] { 5, 1, 5, 1, 5 }, new[] { 5, 1, 5, 1, 5 })]
    [DataRow(new[] { 4, 6, 3, 9, 2 }, new[] { 36 })]
    [DataRow(new[] { 10, 5, 3, 7, 14, 2 }, new[] { 10, 3, 14 })]
    [DataRow(new[] { 1, 2, 4, 1, 3, 9 }, new[] { 1, 4, 1, 9 })]
    [DataRow(new[] { 31622, 31622, 3 }, new[] { 31622, 3 })]
    [DataRow(new[] { 99991, 99991, 2 }, new[] { 99991, 2 })]
    [DataRow(new[] { 24, 1, 17, 11, 25, 21, 19, 4, 29, 9, 29, 10, 20, 25, 1, 4, 9, 17, 10, 3, 2, 11, 25, 12, 29 }, new[] { 24, 1, 17, 11, 25, 21, 19, 4, 29, 9, 29, 100, 1, 4, 9, 17, 10, 3, 2, 11, 25, 12, 29 })]
    public void ReplaceNonCoprimes_WithNumsArray_ReplacesWithLCMUntilNoMorePairs(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var result = solution.ReplaceNonCoprimes(nums);
        var actualResult = new int[result.Count];
        result.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}