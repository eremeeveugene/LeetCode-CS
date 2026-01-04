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

using LeetCode.Algorithms.FindTheKthCharacterInStringGame1;

namespace LeetCode.Tests.Algorithms.FindTheKthCharacterInStringGame1;

public abstract class FindTheKthCharacterInStringGame1TestsBase<T> where T : IFindTheKthCharacterInStringGame1, new()
{
    [TestMethod]
    [DataRow(5, 'b')]
    [DataRow(10, 'c')]
    public void KthCharacter_WithGivenIndex_ReturnsCorrespondingCharacter(int k, char expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.KthCharacter(k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}