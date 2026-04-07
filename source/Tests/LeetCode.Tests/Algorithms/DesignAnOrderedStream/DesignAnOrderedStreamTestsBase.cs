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

using LeetCode.Algorithms.DesignAnOrderedStream;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.DesignAnOrderedStream;

public abstract class DesignAnOrderedStreamTestsBase
{
    private const string Insert = "insert";

    [TestMethod]
    [DataRow(5, "[\"insert\",\"insert\",\"insert\",\"insert\",\"insert\"]",
        "[[3, \"ccccc\"], [1, \"aaaaa\"], [2, \"bbbbb\"], [5, \"eeeee\"], [4, \"ddddd\"]]",
        "[[], [\"aaaaa\"], [\"bbbbb\", \"ccccc\"], [], [\"ddddd\", \"eeeee\"]]")]
    public void DesignAnOrderedStream_WithMixedOperations_ProcessesOperationsAccordingToSpecification(int size,
        string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[][]>.Parse(expectedResultJson);

        var solution = GetSolution(size);

        // Act 
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Insert:
                    actualResult.Add(solution.Insert((int)arguments[i][0], (string)arguments[i][1]));
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignAnOrderedStream GetSolution(int size);
}