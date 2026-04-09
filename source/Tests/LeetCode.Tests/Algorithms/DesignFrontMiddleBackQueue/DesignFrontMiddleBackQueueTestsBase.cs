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

using LeetCode.Algorithms.DesignFrontMiddleBackQueue;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DesignFrontMiddleBackQueue;

public abstract class DesignFrontMiddleBackQueueTestsBase<T> where T : IDesignFrontMiddleBackQueue, new()
{
    private const string PushFront = "pushFront";
    private const string PushMiddle = "pushMiddle";
    private const string PushBack = "pushBack";
    private const string PopFront = "popFront";
    private const string PopMiddle = "popMiddle";
    private const string PopBack = "popBack";

    [TestMethod]
    [DataRow(
        "[\"pushFront\", \"pushBack\", \"pushMiddle\", \"pushMiddle\", \"popFront\", \"popMiddle\", \"popMiddle\", \"popBack\", \"popFront\"]",
        "[1, 2, 3, 4, 0, 0, 0, 0, 0]",
        "[1, 3, 4, 2, -1]")]
    public void DesignFrontMiddleBackQueue_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        string operationsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var operations = JsonHelper<string[]>.Parse(operationsJson);
        var arguments = JsonHelper.Parse<int[]>(argumentsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case PushFront:
                    solution.PushFront(arguments[i]);

                    break;
                case PushMiddle:
                    solution.PushMiddle(arguments[i]);

                    break;
                case PushBack:
                    solution.PushBack(arguments[i]);

                    break;
                case PopFront:
                    actualResult.Add(solution.PopFront());

                    break;
                case PopMiddle:
                    actualResult.Add(solution.PopMiddle());

                    break;
                case PopBack:
                    actualResult.Add(solution.PopBack());

                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Unexpected operation '{operations[i]}' at index {i}.");
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}