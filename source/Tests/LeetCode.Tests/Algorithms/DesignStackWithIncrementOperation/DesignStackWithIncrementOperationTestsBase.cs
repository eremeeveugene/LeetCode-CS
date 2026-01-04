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

using LeetCode.Algorithms.DesignStackWithIncrementOperation;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.DesignStackWithIncrementOperation;

public abstract class DesignStackWithIncrementOperationTestsBase
{
    private const string Push = "push";
    private const string Pop = "pop";
    private const string Increment = "increment";

    [TestMethod]
    [DataRow(3,
        "[\"push\",\"push\",\"pop\",\"push\",\"push\",\"push\",\"increment\",\"increment\",\"pop\",\"pop\",\"pop\",\"pop\"]",
        "[[1],[2],[],[2],[3],[4],[5,100],[2,100],[],[],[],[]]",
        "[2,103,202,201,-1]")]
    public void DesignStackWithIncrementOperation_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        int maxSize, string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(maxSize);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Push:
                    solution.Push((int)arguments[i][0]);
                    break;
                case Pop:
                    actualResult.Add(solution.Pop());
                    break;
                case Increment:
                    solution.Increment((int)arguments[i][0], (int)arguments[i][1]);
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignStackWithIncrementOperation GetSolution(int maxSize);
}