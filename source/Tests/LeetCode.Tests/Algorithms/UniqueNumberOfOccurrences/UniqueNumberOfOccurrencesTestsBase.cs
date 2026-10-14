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

using LeetCode.Algorithms.UniqueNumberOfOccurrences;

namespace LeetCode.Tests.Algorithms.UniqueNumberOfOccurrences;

public abstract class UniqueNumberOfOccurrencesTestsBase<T> where T : IUniqueNumberOfOccurrences, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2 }, false)]
    [DataRow(new[] { 1, 2, 2, 1, 1, 3 }, true)]
    [DataRow(new[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }, true)]
    [DataRow(new[] { 1 }, true)]
    [DataRow(new[] { 1, 1 }, true)]
    [DataRow(new[] { 1, 1, 2, 2 }, false)]
    [DataRow(new[] { 1, 2, 2 }, true)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3, 3 }, false)]
    [DataRow(new[] { 0 }, true)]
    [DataRow(new[] { -1000, 1000 }, false)]
    [DataRow(new[] { -1000, -1000, 1000 }, true)]
    [DataRow(new[] { 1000, 1000, 1000, -1000, -1000, 0 }, true)]
    [DataRow(new[] { 5, 5, 5, 5, 3, 3, 3, 7, 7, 9 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, false)]
    [DataRow(new[] { 1, 1, 1, 2, 2, 3 }, true)]
    [DataRow(new[] { 1, 1, 1, 2, 2, 3, 3 }, false)]
    [DataRow(new[] { 0, 0, 0, 0, 0, 0 }, true)]
    [DataRow(new[] { 7, -7, 7, -7 }, false)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 }, true)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 5 }, false)]
    public void UniqueOccurrences_WithIntegerArray_ReturnsIfOccurrencesAreUnique(int[] arr, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.UniqueOccurrences(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}