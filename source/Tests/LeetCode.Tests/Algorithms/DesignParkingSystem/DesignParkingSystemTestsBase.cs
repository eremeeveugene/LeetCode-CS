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

using LeetCode.Algorithms.DesignParkingSystem;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.DesignParkingSystem;

public abstract class DesignParkingSystemTestsBase
{
    private const string AddCar = "addCar";

    [TestMethod]
    [DataRow(
        0, 0, 0,
        "[\"addCar\"]",
        "[[1]]",
        "[false]")]
    [DataRow(
        1, 0, 0,
        "[\"addCar\", \"addCar\"]",
        "[[1], [1]]",
        "[true, false]")]
    [DataRow(
        0, 1, 0,
        "[\"addCar\", \"addCar\"]",
        "[[2], [2]]",
        "[true, false]")]
    [DataRow(
        0, 0, 1,
        "[\"addCar\", \"addCar\"]",
        "[[3], [3]]",
        "[true, false]")]
    [DataRow(
        2, 2, 2,
        "[\"addCar\", \"addCar\", \"addCar\", \"addCar\", \"addCar\", \"addCar\", \"addCar\"]",
        "[[1], [1], [2], [2], [3], [3], [1]]",
        "[true, true, true, true, true, true, false]")]
    [DataRow(
        1, 1, 1,
        "[\"addCar\", \"addCar\", \"addCar\"]",
        "[[3], [2], [1]]",
        "[true, true, true]")]
    [DataRow(
        1, 1, 1,
        "[\"addCar\", \"addCar\", \"addCar\", \"addCar\"]",
        "[[3], [2], [1], [2]]",
        "[true, true, true, false]")]
    [DataRow(
        3, 0, 0,
        "[\"addCar\", \"addCar\", \"addCar\", \"addCar\"]",
        "[[1], [1], [1], [1]]",
        "[true, true, true, false]")]
    [DataRow(
        0, 3, 0,
        "[\"addCar\", \"addCar\", \"addCar\", \"addCar\"]",
        "[[2], [2], [2], [2]]",
        "[true, true, true, false]")]
    [DataRow(
        0, 0, 3,
        "[\"addCar\", \"addCar\", \"addCar\", \"addCar\"]",
        "[[3], [3], [3], [3]]",
        "[true, true, true, false]")]
    [DataRow(
        1, 1, 1,
        "[\"addCar\", \"addCar\", \"addCar\", \"addCar\"]",
        "[[1], [4], [2], [3]]",
        "[true, false, true, true]")]
    public void DesignParkingSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        int bigCapacity,
        int mediumCapacity,
        int smallCapacity,
        string methodsJson,
        string argumentsJson,
        string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(bigCapacity, mediumCapacity, smallCapacity);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case AddCar:
                    actualResult.Add(solution.AddCar((int)arguments[i][0]));
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignParkingSystem GetSolution(int bigCapacity, int mediumCapacity, int smallCapacity);
}