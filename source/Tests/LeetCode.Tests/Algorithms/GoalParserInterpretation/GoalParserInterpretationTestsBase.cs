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

using LeetCode.Algorithms.GoalParserInterpretation;

namespace LeetCode.Tests.Algorithms.GoalParserInterpretation;

public abstract class GoalParserInterpretationTestsBase<T> where T : IGoalParserInterpretation, new()
{
    [TestMethod]
    [DataRow("G()(al)", "Goal")]
    [DataRow("G()()()()(al)", "Gooooal")]
    [DataRow("(al)G(al)()()G", "alGalooG")]
    public void Interpret_GivenCommandString_ReturnsExpectedString(string command, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Interpret(command);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}