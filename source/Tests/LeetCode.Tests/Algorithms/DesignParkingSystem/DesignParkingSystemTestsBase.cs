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
        1,
        1,
        0,
        "[\"addCar\", \"addCar\", \"addCar\", \"addCar\"]",
        "[[1], [2], [3], [1]]",
        "[12, 16, 25, 15]")]
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
                    solution.AddCar((int)arguments[i][0]);
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