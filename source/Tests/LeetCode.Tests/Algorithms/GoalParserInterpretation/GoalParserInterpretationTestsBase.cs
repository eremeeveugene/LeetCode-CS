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

using LeetCode.Algorithms.GoalParserInterpretation;

namespace LeetCode.Tests.Algorithms.GoalParserInterpretation;

public abstract class GoalParserInterpretationTestsBase<T> where T : IGoalParserInterpretation, new()
{
    [TestMethod]
    [DataRow("G()(al)", "Goal")]
    [DataRow("G()()()()(al)", "Gooooal")]
    [DataRow("(al)G(al)()()G", "alGalooG")]
    [DataRow("G", "G")]
    [DataRow("()", "o")]
    [DataRow("(al)", "al")]
    [DataRow("()()", "oo")]
    [DataRow("(al)(al)", "alal")]
    [DataRow("GGG", "GGG")]
    [DataRow("()G", "oG")]
    [DataRow("(al)G()", "alGo")]
    [DataRow("G(al)(al)G", "GalalG")]
    [DataRow("()(al)()", "oalo")]
    [DataRow("G()G()", "GoGo")]
    [DataRow("(al)()G", "aloG")]
    [DataRow("GG(al)()()", "GGaloo")]
    [DataRow("(al)(al)(al)G", "alalalG")]
    [DataRow("G(al)G()G()()()(al)()GG", "GalGoGoooaloGG")]
    [DataRow("()G()()(al)G(al)()()(al)G(al)", "oGooalGalooalGal")]
    [DataRow("(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)(al)", "alalalalalalalalalalalalalalalalalalalalalalalalal")]
    [DataRow("G()G()G()G()G()G()G()G()G()G()G()G()G()G()G()G()G()G()G()G()G()G()G()G()G()", "GoGoGoGoGoGoGoGoGoGoGoGoGoGoGoGoGoGoGoGoGoGoGoGoGo")]
    public void Interpret_WithGoalParserCommand_ReturnsInterpretedString(string command, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Interpret(command);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}