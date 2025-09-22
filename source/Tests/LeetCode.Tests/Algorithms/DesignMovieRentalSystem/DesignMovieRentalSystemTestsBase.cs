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

using LeetCode.Algorithms.DesignMovieRentalSystem;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.DesignMovieRentalSystem;

public abstract class DesignMovieRentalSystemTestsBase
{
    private const string Search = "search";
    private const string Rent = "rent";
    private const string Drop = "drop";
    private const string Report = "report";

    [TestMethod]
    [DataRow(3,
        "[[0, 1, 5], [0, 2, 6], [0, 3, 7], [1, 1, 4], [1, 2, 7], [2, 1, 5]]",
        "[\"search\", \"rent\", \"rent\", \"report\", \"drop\", \"search\"]",
        "[[1], [0, 1], [1, 2], [], [1, 2], [2]]",
        "[[1, 0, 2], [[0, 1], [1, 2]], [0, 1]]")]
    public void DesignMovieRentalSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        int n, string entriesJson, string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var entries = JsonHelper<int[][]>.Parse(entriesJson);
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(n, entries);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Search:
                    actualResult.Add(solution.Search((int)arguments[i][0]));
                    break;
                case Rent:
                    solution.Rent((int)arguments[i][0], (int)arguments[i][1]);
                    break;
                case Drop:
                    solution.Drop((int)arguments[i][0], (int)arguments[i][1]);
                    break;
                case Report:
                    actualResult.Add(solution.Report());
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignMovieRentalSystem GetSolution(int n, int[][] entries);
}