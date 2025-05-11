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

using LeetCode.Algorithms.DesignNeighborSumService;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DesignNeighborSumService;

public abstract class DesignNeighborSumServiceTestsBase
{
    private const string AdjacentSum = "adjacentSum";
    private const string DiagonalSum = "diagonalSum";

    [TestMethod]
    [DataRow("[[0, 1, 2], [3, 4, 5], [6, 7, 8]]", "[\"adjacentSum\",\"adjacentSum\",\"diagonalSum\",\"diagonalSum\"]",
        "[[1],[4],[4],[8]]", "[6,16,16,4]")]
    public void DesignNeighborSumService_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        string gridJson, string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var grid = JsonHelper<int[][]>.Parse(gridJson);
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(grid);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case AdjacentSum:
                    actualResult.Add(solution.AdjacentSum((int)arguments[i][0]));
                    break;
                case DiagonalSum:
                    actualResult.Add(solution.DiagonalSum((int)arguments[i][0]));
                    break;
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignNeighborSumService GetSolution(int[][] grid);
}