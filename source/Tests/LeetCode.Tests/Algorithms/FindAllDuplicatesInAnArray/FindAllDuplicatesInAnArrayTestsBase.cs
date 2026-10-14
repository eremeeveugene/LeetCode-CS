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

using LeetCode.Algorithms.FindAllDuplicatesInAnArray;

namespace LeetCode.Tests.Algorithms.FindAllDuplicatesInAnArray;

public abstract class FindAllDuplicatesInAnArrayTestsBase<T> where T : IFindAllDuplicatesInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new[] { 2, 3 })]
    [DataRow(new[] { 1, 1, 2 }, new[] { 1 })]
    [DataRow(new[] { 1 }, new int[] { })]
    [DataRow(new[] { 2, 1, 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2 }, new int[] { })]
    [DataRow(new[] { 1, 1 }, new[] { 1 })]
    [DataRow(new[] { 2, 2, 1 }, new[] { 2 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, new int[] { })]
    [DataRow(new[] { 3, 1, 3 }, new[] { 3 })]
    [DataRow(new[] { 2, 3, 1, 3, 2 }, new[] { 3, 2 })]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 5, 4, 3, 2, 1, 5, 4 }, new[] { 5, 4 })]
    [DataRow(new[] { 4, 4, 3, 3, 2, 2, 1, 1 }, new[] { 4, 3, 2, 1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new int[] { })]
    [DataRow(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new int[] { })]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 6, 1, 2, 3, 4, 5, 6, 1 }, new[] { 6, 1 })]
    [DataRow(new[] { 2, 1, 2, 1 }, new[] { 2, 1 })]
    [DataRow(new[] { 3, 2, 3, 2, 1, 1 }, new[] { 3, 2, 1 })]
    [DataRow(new[] { 7, 6, 5, 4, 3, 2, 1, 7, 6 }, new[] { 7, 6 })]
    public void FindDuplicates_WithArrayOfIntegers_ReturnsElementsThatAppearExactlyTwice(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualList = solution.FindDuplicates(nums);

        var actualResult = new int[actualList.Count];

        actualList.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}