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

using LeetCode.Algorithms.CheckIfNAndItsDoubleExist;

namespace LeetCode.Tests.Algorithms.CheckIfNAndItsDoubleExist;

public abstract class CheckIfNAndItsDoubleExistTestsBase<T> where T : ICheckIfNAndItsDoubleExist, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 0 }, true)]
    [DataRow(new[] { 10, 2, 5, 3 }, true)]
    [DataRow(new[] { 3, 1, 7, 11 }, false)]
    [DataRow(new[] { -2, 0, 10, -19, 4, 6, -8 }, false)]
    [DataRow(new[] { -10, 12, -20, -8, 15 }, true)]
    [DataRow(new[] { 7, 1, 14, 11 }, true)]
    [DataRow(new[] { 0, 0, 1 }, true)]
    [DataRow(new[] { 1, 2 }, true)]
    [DataRow(new[] { 2, 1 }, true)]
    [DataRow(new[] { -3, -6 }, true)]
    [DataRow(new[] { -6, -3 }, true)]
    [DataRow(new[] { 4, 8, 1 }, true)]
    [DataRow(new[] { 5, 10 }, true)]
    [DataRow(new[] { 0, 5, 0 }, true)]
    [DataRow(new[] { 100, 50, 25 }, true)]
    [DataRow(new[] { -1000, -500 }, true)]
    [DataRow(new[] { 3, 5 }, false)]
    [DataRow(new[] { 0, 1 }, false)]
    [DataRow(new[] { 1, 3, 5, 7 }, false)]
    [DataRow(new[] { 1, 1 }, false)]
    public void CheckIfExist_WithArrayInput_ReturnsTrueIfAnyValueDoublesExist(int[] arr, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckIfExist(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}