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

using LeetCode.Algorithms.FindAllDuplicatesInAnArray;

namespace LeetCode.Tests.Algorithms.FindAllDuplicatesInAnArray;

public abstract class FindAllDuplicatesInAnArrayTestsBase<T> where T : IFindAllDuplicatesInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new[] { 2, 3 })]
    [DataRow(new[] { 1, 1, 2 }, new[] { 1 })]
    [DataRow(new[] { 1 }, new int[] { })]
    public void FindDuplicates_WithInputArray_ReturnsExpectedDuplicates(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDuplicates(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}