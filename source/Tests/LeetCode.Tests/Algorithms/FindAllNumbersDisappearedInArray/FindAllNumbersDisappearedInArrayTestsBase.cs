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
    public void FindDisappearedNumbers_WithInputArrayContainingDuplicates_ReturnsMissingNumbers(int[] nums,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDisappearedNumbers(nums).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}