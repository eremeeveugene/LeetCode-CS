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
    [DataRow(new[] { 'a', 'b' }, 'a', 'b')]
    [DataRow(new[] { 'a', 'b' }, 'b', 'a')]
    [DataRow(new[] { 'a', 'b' }, 'z', 'a')]
    [DataRow(new[] { 'a', 'a' }, 'a', 'a')]
    [DataRow(new[] { 'a', 'b' }, 'c', 'a')]
    [DataRow(new[] { 'c', 'f', 'j' }, 'j', 'c')]
    [DataRow(new[] { 'c', 'f', 'j' }, 'd', 'f')]
    [DataRow(new[] { 'c', 'f', 'j' }, 'k', 'c')]
    [DataRow(new[] { 'c', 'f', 'j' }, 'f', 'j')]
    [DataRow(new[] { 'a', 'c', 'e', 'g', 'i' }, 'e', 'g')]
    [DataRow(new[] { 'a', 'c', 'e', 'g', 'i' }, 'b', 'c')]
    [DataRow(new[] { 'a', 'c', 'e', 'g', 'i' }, 'i', 'a')]
    [DataRow(new[] { 'e', 'e', 'e', 'k', 'q', 'q', 'q', 'v', 'z', 'z' }, 'q', 'v')]
    [DataRow(new[] { 'e', 'e', 'e', 'k', 'q', 'q', 'q', 'v', 'z', 'z' }, 'a', 'e')]
    [DataRow(new[] { 'e', 'e', 'e', 'k', 'q', 'q', 'q', 'v', 'z', 'z' }, 'y', 'z')]
    [DataRow(new[] { 'e', 'e', 'e', 'k', 'q', 'q', 'q', 'v', 'z', 'z' }, 'z', 'e')]
    [DataRow(new[] { 'm', 'n', 'o' }, 'l', 'm')]
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