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

using LeetCode.Algorithms.OneBitAndTwoBitCharacters;

namespace LeetCode.Tests.Algorithms.OneBitAndTwoBitCharacters;

public abstract class OneBitAndTwoBitCharactersTestsBase<T> where T : IOneBitAndTwoBitCharacters, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 0, 0 }, true)]
    [DataRow(new[] { 1, 1, 1, 0 }, false)]
    [DataRow(new[] { 0 }, true)]
    [DataRow(new[] { 1, 0, 0, 0 }, true)]
    [DataRow(new[] { 1, 1, 0 }, true)]
    [DataRow(new[] { 0, 0 }, true)]
    [DataRow(new[] { 1, 0, 1, 0, 0 }, true)]
    [DataRow(new[] { 1, 1, 0, 0 }, true)]
    [DataRow(new[] { 0, 1, 1, 0 }, true)]
    [DataRow(new[] { 1, 1, 1, 1, 0 }, true)]
    [DataRow(new[] { 1, 0, 1, 1, 0 }, false)]
    [DataRow(new[] { 0, 0, 0 }, true)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 0 }, false)]
    [DataRow(new[] { 0, 1, 0, 0 }, true)]
    [DataRow(new[] { 1, 0, 0, 1, 0, 0 }, true)]
    [DataRow(new[] { 1, 1, 0, 1, 0, 0 }, true)]
    [DataRow(new[] { 1, 0, 1, 0, 1, 0, 0 }, true)]
    [DataRow(new[] { 0, 0, 0, 0 }, true)]
    public void IsOneBitCharacter_WithBitsArray_ReturnsTrueIfLastIsOneBitCharacter(int[] bits, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsOneBitCharacter(bits);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}