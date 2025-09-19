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

using LeetCode.Algorithms.DesignSpreadsheet;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.DesignSpreadsheet;

public abstract class DesignSpreadsheetTestsBase
{
    private const string SetCell = "setCell";
    private const string ResetCell = "resetCell";
    private const string GetValue = "getValue";

    [TestMethod]
    [DataRow(3,
        "[\"getValue\",\"setCell\",\"getValue\",\"setCell\",\"getValue\",\"resetCell\",\"getValue\"]",
        "[[\"=5+7\"], [\"A1\", 10], [\"=A1+6\"], [\"B2\", 15], [\"=A1+B2\"], [\"A1\"], [\"=A1+B2\"]]",
        "[12, 16, 25, 15]")]
    public void DesignSpreadsheet_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        int rows, string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(rows);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case SetCell:
                    solution.SetCell((string)arguments[i][0], (int)arguments[i][1]);
                    break;
                case ResetCell:
                    solution.ResetCell((string)arguments[i][0]);
                    break;
                case GetValue:
                    actualResult.Add(solution.GetValue((string)arguments[i][0]));
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignSpreadsheet GetSolution(int rows);
}