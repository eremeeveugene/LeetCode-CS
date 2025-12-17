// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.DesignBrowserHistory;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.DesignBrowserHistory;

public abstract class DesignBrowserHistoryTestsBase
{
    private const string Visit = "visit";
    private const string Back = "back";
    private const string Forward = "forward";

    [TestMethod]
    [DataRow("leetcode.com",
        "[\"visit\",\"visit\",\"visit\",\"back\",\"back\",\"forward\",\"visit\",\"forward\",\"back\",\"back\"]",
        "[[\"google.com\"],[\"facebook.com\"],[\"youtube.com\"],[1],[1],[1],[\"linkedin.com\"],[2],[2],[7]]",
        "[\"facebook.com\",\"google.com\",\"facebook.com\",\"linkedin.com\",\"google.com\",\"leetcode.com\"]")]
    public void DesignBrowserHistory_WithMixedOperations_ProcessesOperationsAccordingToSpecification(string homepage,
        string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(homepage);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Visit:
                    solution.Visit((string)arguments[i][0]);
                    break;
                case Back:
                    actualResult.Add(solution.Back((int)arguments[i][0]));
                    break;
                case Forward:
                    actualResult.Add(solution.Forward((int)arguments[i][0]));
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignBrowserHistory GetSolution(string homepage);
}