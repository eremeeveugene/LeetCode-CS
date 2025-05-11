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
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.DesignCircularQueue;

public abstract class DesignCircularQueueTestsBase
{
    private const string EnQueue = "enQueue";
    private const string DeQueue = "deQueue";
    private const string IsEmpty = "isEmpty";
    private const string IsFull = "isFull";
    private const string Rear = "rear";
    private const string Front = "front";

    [TestMethod]
    [DataRow(3,
        "[\"enQueue\", \"enQueue\", \"enQueue\", \"enQueue\", \"rear\", \"isFull\", \"deQueue\", \"enQueue\", \"rear\"]",
        "[[1], [2], [3], [4], [], [], [], [4], []]", "[true, true, true, false, 3, true, true, true, 4]")]
    public void DesignCircularQueue_WithMixedOperations_ProcessesOperationsAccordingToSpecification(int k,
        string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(k);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case EnQueue:
                    actualResult.Add(solution.EnQueue((int)arguments[i][0]));
                    break;
                case DeQueue:
                    actualResult.Add(solution.DeQueue());
                    break;
                case Front:
                    actualResult.Add(solution.Front());
                    break;
                case Rear:
                    actualResult.Add(solution.Rear());
                    break;
                case IsFull:
                    actualResult.Add(solution.IsFull());
                    break;
                case IsEmpty:
                    actualResult.Add(solution.IsEmpty());
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignCircularQueue GetSolution(int k);
}