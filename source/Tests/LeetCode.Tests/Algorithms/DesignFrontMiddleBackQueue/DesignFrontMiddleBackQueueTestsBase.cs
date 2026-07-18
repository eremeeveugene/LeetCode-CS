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
        new[] { "pushFront", "pushBack", "pushMiddle", "pushMiddle", "popFront", "popMiddle", "popMiddle", "popBack", "popFront" },
        new[] { 1, 2, 3, 4, 0, 0, 0, 0, 0 },
        new[] { 1, 3, 4, 2, -1 })]
    [DataRow(new[] { "popFront" }, new[] { 0 }, new[] { -1 })]
    [DataRow(new[] { "popMiddle" }, new[] { 0 }, new[] { -1 })]
    [DataRow(new[] { "popBack" }, new[] { 0 }, new[] { -1 })]
    [DataRow(new[] { "pushFront", "popFront" }, new[] { 5, 0 }, new[] { 5 })]
    [DataRow(new[] { "pushBack", "popBack" }, new[] { 7, 0 }, new[] { 7 })]
    [DataRow(new[] { "pushMiddle", "popMiddle" }, new[] { 3, 0 }, new[] { 3 })]
    [DataRow(new[] { "pushFront", "pushFront", "popFront", "popFront" }, new[] { 1, 2, 0, 0 }, new[] { 2, 1 })]
    [DataRow(new[] { "pushBack", "pushBack", "popBack", "popBack" }, new[] { 1, 2, 0, 0 }, new[] { 2, 1 })]
    [DataRow(new[] { "pushFront", "pushBack", "popMiddle" }, new[] { 1, 2, 0 }, new[] { 1 })]
    [DataRow(new[] { "pushFront", "pushBack", "pushFront", "popMiddle" }, new[] { 1, 2, 3, 0 }, new[] { 1 })]
    [DataRow(new[] { "pushMiddle", "pushMiddle", "popFront", "popFront" }, new[] { 1, 2, 0, 0 }, new[] { 2, 1 })]
    [DataRow(new[] { "pushFront", "pushFront", "pushFront", "popMiddle", "popMiddle" }, new[] { 1, 2, 3, 0, 0 }, new[] { 2, 3 })]
    [DataRow(new[] { "pushBack", "pushBack", "pushBack", "popMiddle", "popMiddle" }, new[] { 1, 2, 3, 0, 0 }, new[] { 2, 1 })]
    [DataRow(new[] { "pushFront", "pushMiddle", "popFront", "popFront" }, new[] { 5, 10, 0, 0 }, new[] { 10, 5 })]
    [DataRow(new[] { "pushFront", "pushBack", "pushMiddle", "popFront", "popMiddle", "popBack" }, new[] { 1, 3, 2, 0, 0, 0 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { "pushBack", "pushFront", "popMiddle" }, new[] { 2, 1, 0 }, new[] { 1 })]
    [DataRow(new[] { "pushFront", "pushFront", "pushFront", "pushFront", "popFront", "popBack" }, new[] { 1, 2, 3, 4, 0, 0 }, new[] { 4, 1 })]
    [DataRow(
        new[] { "pushMiddle", "pushMiddle", "pushMiddle", "popMiddle", "popMiddle", "popMiddle" },
        new[] { 1, 2, 3, 0, 0, 0 },
        new[] { 3, 2, 1 })]
    [DataRow(new[] { "pushFront", "pushBack", "popBack", "popFront" }, new[] { 10, 20, 0, 0 }, new[] { 20, 10 })]
    [DataRow(new[] { "pushMiddle", "pushFront", "pushBack", "popMiddle" }, new[] { 1, 2, 3, 0 }, new[] { 1 })]
    [DataRow(new[] { "pushFront", "pushFront", "pushBack", "popMiddle", "popBack" }, new[] { 1, 2, 3, 0, 0 }, new[] { 1, 3 })]
    [DataRow(new[] { "pushBack", "pushMiddle", "pushFront", "popFront", "popBack" }, new[] { 5, 10, 15, 0, 0 }, new[] { 15, 5 })]
    [DataRow(new[] { "popFront", "popBack", "popMiddle" }, new[] { 0, 0, 0 }, new[] { -1, -1, -1 })]
    [DataRow(new[] { "pushFront", "pushBack", "pushMiddle", "popFront" }, new[] { 1, 2, 3, 0 }, new[] { 1 })]
    public void DesignFrontMiddleBackQueue_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        string[] operations,
        int[] arguments,
        int[] expectedResult)
    {
        // Arrange
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
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}