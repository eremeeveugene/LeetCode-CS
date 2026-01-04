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

using LeetCode.Algorithms.DesignTaskManager;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.DesignTaskManager;

public abstract class DesignTaskManagerTestsBase
{
    private const string Add = "add";
    private const string Edit = "edit";
    private const string Rmv = "rmv";
    private const string ExecTop = "execTop";

    [TestMethod]
    [DataRow("[[1, 101, 10], [2, 102, 20], [3, 103, 15]]",
        "[\"add\", \"edit\", \"execTop\", \"rmv\", \"add\", \"execTop\"]",
        "[[4, 104, 5], [102, 8], [], [101], [5, 105, 15], []]",
        "[3, 5]")]
    public void DesignTaskManager_WithMixedOperations_ProcessesOperationsAccordingToSpecification(string tasksJson,
        string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var tasks = JsonHelper<IList<IList<int>>>.Parse(tasksJson);
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(tasks);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Add:
                    solution.Add((int)arguments[i][0], (int)arguments[i][1], (int)arguments[i][2]);
                    break;
                case Edit:
                    solution.Edit((int)arguments[i][0], (int)arguments[i][1]);
                    break;
                case Rmv:
                    solution.Rmv((int)arguments[i][0]);
                    break;
                case ExecTop:
                    actualResult.Add(solution.ExecTop());
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignTaskManager GetSolution(IList<IList<int>> tasks);
}