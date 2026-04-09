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

using LeetCode.Algorithms.DesignHashMap;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DesignHashMap;

public abstract class DesignHashMapTestsBase<T> where T : IDesignHashMap, new()
{
    private const string Put = "put";
    private const string Get = "get";
    private const string Remove = "remove";

    [TestMethod]
    [DataRow(
        "[\"put\", \"put\", \"get\", \"get\", \"put\", \"get\", \"remove\", \"get\"]",
        "[[1, 1], [2, 2], [1], [3], [2, 1], [2], [2], [2]]",
        "[1, -1, 1, -1]")]
    public void DesignHashMap_WithMixedOperations_ProcessesOperationsAccordingToSpecification(string operationsJson,
        string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var operations = JsonHelper<string[]>.Parse(operationsJson);
        var arguments = JsonHelper<int[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case Put:
                    solution.Put(arguments[i][0], arguments[i][1]);

                    break;
                case Get:
                    actualResult.Add(solution.Get(arguments[i][0]));

                    break;
                case Remove:
                    solution.Remove(arguments[i][0]);

                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Unexpected operation '{operations[i]}' at index {i}.");
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}