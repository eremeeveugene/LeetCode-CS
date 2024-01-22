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

using LeetCode.Algorithms.ValidParentheses;

namespace LeetCode.Tests.Algorithms.ValidParentheses;

public abstract class ValidParenthesesTestsBase<T> where T : IValidParentheses, new()
{
    [TestMethod]
    [DataRow("()", true)]
    [DataRow("()[]{}", true)]
    [DataRow("(]", false)]
    [DataRow("{[]}", true)]
    [DataRow("[[[[]]]]", true)]
    public void SearchInsert_WithSortedArrayAndTarget_ReturnsCorrectInsertionIndex(string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsValid(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}