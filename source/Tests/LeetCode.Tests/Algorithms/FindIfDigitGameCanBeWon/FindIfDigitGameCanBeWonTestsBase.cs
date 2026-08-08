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

using LeetCode.Algorithms.FindIfDigitGameCanBeWon;

namespace LeetCode.Tests.Algorithms.FindIfDigitGameCanBeWon;

public abstract class FindIfDigitGameCanBeWonTestsBase<T> where T : IFindIfDigitGameCanBeWon, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 10 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 14 }, true)]
    [DataRow(new[] { 5, 5, 5, 25 }, true)]
    [DataRow(new[] { 1 }, true)]
    [DataRow(new[] { 10 }, true)]
    [DataRow(new[] { 9, 90 }, true)]
    [DataRow(new[] { 9, 9 }, true)]
    [DataRow(new[] { 10, 10 }, true)]
    [DataRow(new[] { 5, 5, 10 }, false)]
    [DataRow(new[] { 9, 1, 10 }, false)]
    [DataRow(new[] { 9, 9, 18 }, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 45 }, false)]
    [DataRow(new[] { 50, 49, 1 }, true)]
    [DataRow(new[] { 33, 33, 33, 99 }, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, true)]
    [DataRow(new[] { 10, 20, 30, 40 }, true)]
    [DataRow(new[] { 15, 15, 30 }, true)]
    [DataRow(new[] { 49, 51 }, true)]
    [DataRow(new[] { 11, 22, 33, 66 }, true)]
    [DataRow(new[] { 99 }, true)]
    public void CanAliceWin_WithNums_ReturnsWhetherAliceCanWin(int[] nums, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanAliceWin(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}