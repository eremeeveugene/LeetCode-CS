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

using LeetCode.Algorithms.DesignFrontMiddleBackQueue;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DesignFrontMiddleBackQueue;

public abstract class DesignFrontMiddleBackQueueTestsBase<T> where T : IDesignFrontMiddleBackQueue, new()
{
    [TestMethod]
    [DataRow(
        "[\"PushFront\", \"PushBack\", \"PushMiddle\", \"PushMiddle\", \"PopFront\", \"PopMiddle\", \"PopMiddle\", \"PopBack\", \"PopFront\"]",
        "[1, 2, 3, 4, 0, 0, 0, 0, 0]",
        "[1, 3, 4, 2, -1]")]
    public void DequeOperations_WithPushAndPopOperations_PerformsCorrectly(string operationsJsonArray,
        string argumentsJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var operations = JsonHelper<string>.DeserializeToArray(operationsJsonArray);
        var arguments = JsonHelper<int>.DeserializeToArray(argumentsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case "PushFront":
                    solution.PushFront(arguments[i]);

                    break;
                case "PushMiddle":
                    solution.PushMiddle(arguments[i]);

                    break;
                case "PushBack":
                    solution.PushBack(arguments[i]);

                    break;
                case "PopFront":
                    actualResult.Add(solution.PopFront());

                    break;
                case "PopMiddle":
                    actualResult.Add(solution.PopMiddle());

                    break;
                case "PopBack":
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