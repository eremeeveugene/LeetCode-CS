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

public abstract class DesignNeighborSumServiceTestsBase<T>
    where T : IDesignNeighborSumServiceFactory, new()
{
    private const string AdjacentSum = "adjacentSum";
    private const string DiagonalSum = "diagonalSum";

    [TestMethod]
    [DataRow("[[0, 1, 2], [3, 4, 5], [6, 7, 8]]", "[\"adjacentSum\",\"adjacentSum\",\"diagonalSum\",\"diagonalSum\"]",
        "[[1],[4],[4],[8]]", "[6,16,16,4]")]
    public void NeighborSum_WithAdjacentAndDiagonalSum_ReturnsSums(string gridJsonArray,
        string methodsJsonArray, string argsJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var grid = JsonHelper<int>.DeserializeToJaggedArray(gridJsonArray);
        var methods = JsonHelper<string>.DeserializeToArray(methodsJsonArray);
        var args = JsonHelper<int>.DeserializeToJaggedArray(argsJsonArray);
        var expectedResult = JsonHelper<int?>.DeserializeToArray(expectedResultJsonArray);

        var solutionFactory = new T();
        var solution = solutionFactory.Create(grid);

        // Act
        var actualResult = new List<int>();

        for (var i = 0; i < methods.Length; i++)
        {
            var value = args[i][0];

            switch (methods[i])
            {
                case AdjacentSum:
                    var adjacentSum = solution.AdjacentSum(value);

                    actualResult.Add(adjacentSum);
                    break;
                case DiagonalSum:
                    var diagonalSum = solution.DiagonalSum(value);

                    actualResult.Add(diagonalSum);
                    break;
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}