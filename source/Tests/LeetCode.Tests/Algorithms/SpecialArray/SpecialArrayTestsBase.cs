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

using LeetCode.Algorithms.SpecialArray;

namespace LeetCode.Tests.Algorithms.SpecialArray;

public abstract class SpecialArrayTestsBase<T> where T : ISpecialArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, true)]
    [DataRow(new[] { 2, 1, 4 }, true)]
    [DataRow(new[] { 4, 3, 1, 6 }, false)]
    [DataRow(new[] { 2 }, true)]
    [DataRow(new[] { 100 }, true)]
    [DataRow(new[] { 1, 2 }, true)]
    [DataRow(new[] { 2, 1 }, true)]
    [DataRow(new[] { 1, 3 }, false)]
    [DataRow(new[] { 2, 4 }, false)]
    [DataRow(new[] { 100, 99, 98, 97 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 9 }, false)]
    [DataRow(new[] { 2, 2 }, false)]
    [DataRow(new[] { 1, 1, 1 }, false)]
    [DataRow(new[] { 5, 6, 7, 8, 8 }, false)]
    [DataRow(new[] { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, true)]
    [DataRow(new[] { 99, 100, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 }, false)]
    [DataRow(new[] { 3, 3, 2 }, false)]
    [DataRow(new[] { 8, 7, 6, 5, 4, 3, 2, 1 }, true)]
    [DataRow(new[] { 10, 1, 20, 3, 30, 5, 40, 7, 50, 9, 60, 11 }, true)]
    public void IsArraySpecial_WithArrayInput_ReturnsWhetherArrayIsSpecial(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsArraySpecial(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}