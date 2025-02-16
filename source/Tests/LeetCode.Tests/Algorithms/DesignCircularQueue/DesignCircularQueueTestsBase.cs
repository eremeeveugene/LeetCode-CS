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

using LeetCode.Algorithms.DesignCircularQueue;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DesignCircularQueue;

public abstract class DesignCircularQueueTestsBase<T> where T : IDesignCircularQueueFactory, new()
{
    [TestMethod]
    [DataRow(3,
        "[\"EnQueue\", \"EnQueue\", \"EnQueue\", \"DeQueue\", \"EnQueue\", \"Rear\", \"Front\", \"IsFull\"]",
        "[1, 2, 3, 0, 4, 0, 0, 0]",
        "[true, true, true, true, true, 4, 2, true]")]
    [DataRow(1,
        "[\"EnQueue\", \"Rear\", \"IsFull\", \"DeQueue\", \"IsEmpty\"]",
        "[1, 0, 0, 0, 0]",
        "[true, 1, true, true, true]")]
    [DataRow(5,
        "[\"EnQueue\", \"EnQueue\", \"EnQueue\", \"EnQueue\", \"EnQueue\", \"IsFull\", \"Rear\", \"Front\", \"DeQueue\", \"DeQueue\", \"EnQueue\", \"Rear\"]",
        "[1, 2, 3, 4, 5, 0, 0, 0, 0, 0, 6, 0]",
        "[true, true, true, true, true, true, 5, 1, true, true, true, 6]")]
    [DataRow(2,
        "[\"EnQueue\", \"EnQueue\", \"IsFull\", \"DeQueue\", \"IsEmpty\", \"DeQueue\", \"IsEmpty\"]",
        "[10, 20, 0, 0, 0, 0, 0]",
        "[true, true, true, true, false, true, true]")]
    [DataRow(0,
        "[\"IsEmpty\", \"IsFull\", \"EnQueue\", \"DeQueue\"]",
        "[0, 0, 1, 0]",
        "[true, true, false, false]")]
    public void CircularQueueOperations_WithGivenCapacityAndOperations_PerformsCorrectly(int k,
        string operationsJsonArray, string argumentsJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var operations = JsonHelper<string>.DeserializeToArray(operationsJsonArray);
        var arguments = JsonHelper<int>.DeserializeToArray(argumentsJsonArray);
        var expectedResult = JsonHelper<object>.DeserializeToArray(expectedResultJsonArray);

        var solutionFactory = new T();
        var solution = solutionFactory.Create(k);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case "EnQueue":
                    actualResult.Add(solution.EnQueue(arguments[i]));
                    break;
                case "DeQueue":
                    actualResult.Add(solution.DeQueue());
                    break;
                case "Front":
                    actualResult.Add(solution.Front());
                    break;
                case "Rear":
                    actualResult.Add(solution.Rear());
                    break;
                case "IsFull":
                    actualResult.Add(solution.IsFull());
                    break;
                case "IsEmpty":
                    actualResult.Add(solution.IsEmpty());
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Unexpected operation '{operations[i]}' at index {i}.");
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult.Select(i => i.ToString()).ToArray(),
            actualResult.Select(i => i.ToString()).ToArray());
    }
}