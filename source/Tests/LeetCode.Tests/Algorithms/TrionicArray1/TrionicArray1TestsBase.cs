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

using LeetCode.Algorithms.TrionicArray1;

namespace LeetCode.Tests.Algorithms.TrionicArray1;

public abstract class TrionicArray1TestsBase<T> where T : ITrionicArray1, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 5, 4, 2, 6 }, true)]
    [DataRow(new[] { 2, 1, 3 }, false)]
    [DataRow(new[] { 1, 2, 3 }, false)]
    [DataRow(new[] { 3, 2, 1 }, false)]
    [DataRow(new[] { 1, 2, 1, 2 }, true)]
    [DataRow(new[] { 1, 2, 1 }, false)]
    [DataRow(new[] { 1, 3, 2, 4 }, true)]
    [DataRow(new[] { 1, 2, 3, 2, 3, 4 }, true)]
    [DataRow(new[] { 5, 6, 4, 5 }, true)]
    [DataRow(new[] { 1, 1, 2, 1, 2 }, false)]
    [DataRow(new[] { 1, 2, 2, 1, 2 }, true)]
    [DataRow(new[] { 1, 3, 2, 1, 2, 3 }, true)]
    [DataRow(new[] { 1 }, false)]
    [DataRow(new[] { 1, 2 }, false)]
    [DataRow(new[] { 1, 2, 1 }, false)]
    [DataRow(new[] { 1, 2, 3, 2 }, false)]
    [DataRow(new[] { 2, 4, 3, 1, 2, 4 }, true)]
    [DataRow(new[] { 1, 3, 5, 4, 3, 4, 5 }, true)]
    [DataRow(new[] { 1, 2, 3, 4 }, false)]
    [DataRow(new[] { 4, 3, 2, 3 }, false)]
    public void IsTrionic_WithNumsArray_ReturnsTrueIfTrionic(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsTrionic(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}