// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.WordSearch;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.WordSearch;

public abstract class WordSearchTestsBase<T> where T : IWordSearch, new()
{
    [TestMethod]
    [DataRow("[[\"A\",\"B\",\"C\",\"E\"],[\"S\",\"F\",\"C\",\"S\"],[\"A\",\"D\",\"E\",\"E\"]]", "ABCCED", true)]
    [DataRow("[[\"A\",\"B\",\"C\",\"E\"],[\"S\",\"F\",\"C\",\"S\"],[\"A\",\"D\",\"E\",\"E\"]]", "SEE", true)]
    [DataRow("[[\"A\",\"B\",\"C\",\"E\"],[\"S\",\"F\",\"C\",\"S\"],[\"A\",\"D\",\"E\",\"E\"]]", "ABCB", false)]
    public void Exist_GivenBoardAndWord_ReturnsExpectedBoolean(string jsonBoard, string word, bool expectedResult)
    {
        // Arrange
        var board = JsonConvertHelper<char>.JsonArrayToJaggedArray(jsonBoard);

        var solution = new T();

        // Act
        var actualResult = solution.Exist(board, word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}