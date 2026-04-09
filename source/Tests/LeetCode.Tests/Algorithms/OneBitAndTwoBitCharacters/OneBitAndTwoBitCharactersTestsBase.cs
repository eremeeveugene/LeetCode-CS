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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.OneBitAndTwoBitCharacters;

public abstract class OneBitAndTwoBitCharactersTestsBase<T> where T : IOneBitAndTwoBitCharacters, new()
{
    [TestMethod]
    [DataRow("[1,0,0]", true)]
    [DataRow("[1,1,1,0]", false)]
    public void IsOneBitCharacter_WithBitsArray_ReturnsTrueIfLastIsOneBitCharacter(string bitsJson, bool expectedResult)
    {
        // Arrange
        var bits = JsonHelper.Parse<int[]>(bitsJson);

        var solution = new T();

        // Act
        var actualResult = solution.IsOneBitCharacter(bits);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}