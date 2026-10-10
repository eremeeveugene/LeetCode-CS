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

using LeetCode.Algorithms.FindAllNumbersDisappearedInArray;

namespace LeetCode.Tests.Algorithms.FindAllNumbersDisappearedInArray;

public abstract class FindAllNumbersDisappearedInArrayTestsBase<T> where T : IFindAllNumbersDisappearedInArray, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new[] { 5, 6 })]
    [DataRow(new[] { 1, 1 }, new[] { 2 })]
    [DataRow(new[] { 1 }, new int[0])]
    [DataRow(new[] { 2, 2 }, new[] { 1 })]
    [DataRow(new[] { 1, 2, 3 }, new int[0])]
    [DataRow(new[] { 3, 3, 3 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 1, 1, 1 }, new[] { 2, 3, 4 })]
    [DataRow(new[] { 2, 3, 4, 1 }, new int[0])]
    [DataRow(new[] { 7, 2, 6, 7, 6, 7, 3 }, new[] { 1, 4, 5 })]
    [DataRow(new[] { 5, 2, 5, 1, 5, 6 }, new[] { 3, 4 })]
    [DataRow(new[] { 4, 4, 3, 4 }, new[] { 1, 2 })]
    [DataRow(new[] { 5, 1, 1, 6, 8, 6, 7, 7, 9, 3 }, new[] { 2, 4, 10 })]
    [DataRow(new[] { 3, 4, 4, 1, 3, 6, 3, 3, 9, 9 }, new[] { 2, 5, 7, 8, 10 })]
    [DataRow(new[] { 5, 6, 5, 2, 4, 7, 4 }, new[] { 1, 3 })]
    [DataRow(new[] { 6, 10, 6, 6, 8, 3, 7, 8, 9, 4 }, new[] { 1, 2, 5 })]
    [DataRow(new[] { 5, 8, 9, 9, 6, 8, 8, 6, 9 }, new[] { 1, 2, 3, 4, 7 })]
    [DataRow(new[] { 8, 4, 6, 3, 5, 8, 5, 5, 9 }, new[] { 1, 2, 7 })]
    [DataRow(new[] { 9, 9, 10, 10, 7, 5, 4, 8, 9, 6 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 10, 2, 6, 12, 1, 4, 12, 2, 1, 10, 11, 1 }, new[] { 3, 5, 7, 8, 9 })]
    [DataRow(new[] { 5, 2, 6, 1, 5, 2 }, new[] { 3, 4 })]
    [DataRow(new[] { 2, 2, 1, 4, 6, 1 }, new[] { 3, 5 })]
    public void FindDisappearedNumbers_WithInputArrayContainingDuplicates_ReturnsMissingNumbers(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDisappearedNumbers(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}