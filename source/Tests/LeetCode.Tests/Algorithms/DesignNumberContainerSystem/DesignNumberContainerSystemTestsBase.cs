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

using LeetCode.Algorithms.DesignNumberContainerSystem;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.DesignNumberContainerSystem;

public abstract class DesignNumberContainerSystemTestsBase<T> where T : IDesignNumberContainerSystem, new()
{
    private const string Change = "change";
    private const string Find = "find";

    [TestMethod]
    [DataRow("[\"find\", \"change\", \"change\", \"change\", \"change\", \"find\", \"change\", \"find\"]",
        "[[10], [2, 10], [1, 10], [3, 10], [5, 10], [10], [1, 20], [10]]",
        "[-1, 1, 2]")]
    public void DesignNumberContainerSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Change:
                    solution.Change((int)arguments[i][0], (int)arguments[i][1]);
                    break;
                case Find:
                    actualResult.Add(solution.Find((int)arguments[i][0]));
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}