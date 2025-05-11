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

using LeetCode.Algorithms.DesignCircularDeque;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.DesignCircularDeque;

public abstract class DesignCircularDequeTestsBase
{
    private const string InsertLast = "insertLast";
    private const string InsertFront = "insertFront";
    private const string GetRear = "getRear";
    private const string GetFront = "getFront";
    private const string IsEmpty = "isEmpty";
    private const string IsFull = "isFull";
    private const string DeleteFront = "deleteFront";
    private const string DeleteLast = "deleteLast";

    [TestMethod]
    [DataRow(3,
        "[\"insertLast\", \"insertLast\", \"insertFront\", \"insertFront\", \"getRear\", \"isFull\", \"deleteLast\", \"insertFront\", \"getFront\"]",
        "[[1], [2], [3], [4], [], [], [], [4], []]", "[true, true, true, false, 2, true, true, true, 4]")]
    public void DesignCircularDeque_WithMixedOperations_ProcessesOperationsAccordingToSpecification(int k,
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
                case InsertLast:
                    actualResult.Add(solution.InsertLast((int)arguments[i][0]));
                    break;
                case InsertFront:
                    actualResult.Add(solution.InsertFront((int)arguments[i][0]));
                    break;
                case GetRear:
                    actualResult.Add(solution.GetRear());
                    break;
                case GetFront:
                    actualResult.Add(solution.GetFront());
                    break;
                case DeleteLast:
                    actualResult.Add(solution.DeleteLast());
                    break;
                case DeleteFront:
                    actualResult.Add(solution.DeleteFront());
                    break;
                case IsEmpty:
                    actualResult.Add(solution.IsEmpty());
                    break;
                case IsFull:
                    actualResult.Add(solution.IsFull());
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignCircularDeque GetSolution(int k);
}