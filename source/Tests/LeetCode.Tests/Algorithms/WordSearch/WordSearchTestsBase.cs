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

using LeetCode.Algorithms.WordSearch;

namespace LeetCode.Tests.Algorithms.WordSearch;

public abstract class WordSearchTestsBase<T> where T : IWordSearch, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Exist_WithCharacterBoardAndWord_ReturnsTrueIfWordExistsBySequentialAdjacentCells(char[][] board,
        string word, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Exist(board, word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 'A', 'B', 'C', 'E' }, new[] { 'S', 'F', 'C', 'S' }, new[] { 'A', 'D', 'E', 'E' } }, "ABCCED", true];

        yield return [new[] { new[] { 'A', 'B', 'C', 'E' }, new[] { 'S', 'F', 'C', 'S' }, new[] { 'A', 'D', 'E', 'E' } }, "SEE", true];

        yield return [new[] { new[] { 'A', 'B', 'C', 'E' }, new[] { 'S', 'F', 'C', 'S' }, new[] { 'A', 'D', 'E', 'E' } }, "ABCB", false];
    }
}
