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

using LeetCode.Algorithms.FindSmallestLetterGreaterThanTarget;

namespace LeetCode.Tests.Algorithms.FindSmallestLetterGreaterThanTarget;

public abstract class FindSmallestLetterGreaterThanTargetTestsBase<T> where T : IFindSmallestLetterGreaterThanTarget, new()
{
    [TestMethod]
    [DataRow(new[] { 'c', 'f', 'j' }, 'a', 'c')]
    [DataRow(new[] { 'c', 'f', 'j' }, 'c', 'f')]
    [DataRow(new[] { 'x', 'x', 'y', 'y' }, 'z', 'x')]
    public void NextGreatestLetter_WithSortedLettersAndTargetCharacter_ReturnsSmallestLetterGreaterThanTarget(
        char[] letters,
        char target,
        char expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NextGreatestLetter(letters, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}