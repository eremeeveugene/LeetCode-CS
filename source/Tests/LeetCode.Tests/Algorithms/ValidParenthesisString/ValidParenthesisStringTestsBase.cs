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

using LeetCode.Algorithms.ValidParenthesisString;

namespace LeetCode.Tests.Algorithms.ValidParenthesisString;

public abstract class ValidParenthesisStringTestsBase<T> where T : IValidParenthesisString, new()
{
    [TestMethod]
    [DataRow("(", false)]
    [DataRow("()", true)]
    [DataRow("(*)", true)]
    [DataRow("(*))", true)]
    [DataRow("*", true)]
    [DataRow("(**(*()**()**((**(*)", true)]
    [DataRow("((*)(*))()*(*)****((*(*)())*()((()**(**)", true)]
    [DataRow(")(*()(**(*)())*))())())*)()()*(((*)()))(**()*)**(*", false)]
    [DataRow(")))(*)**)))*)))))*)*(((()(((*())(***)**(**((()))()((*((()(((", false)]
    [DataRow("(((((*(()((((*((**(((()()*)()()()*((((**)())*)*)))))))(())(()))())((*()()(((()((()*(())*(()**)()(())", false)]
    public void CheckValidString_WithVariousStrings_ReturnsExpectedValidity(string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckValidString(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}