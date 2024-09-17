// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.FindMissingObservations;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindMissingObservations;

public abstract class FindMissingObservationsTestsBase<T> where T : IFindMissingObservations, new()
{
    [TestMethod]
    [DataRow("[3,2,4,3]", 4, 2, "[6,6]")]
    [DataRow("[1,5,6]", 3, 4, "[2,3,2,2]")]
    [DataRow("[1,2,3,4]", 6, 4, "[]")]
    [DataRow("[6,3,4,3,5,3]", 1, 6, "[]")]
    [DataRow("[4,2,2,5,4,5,4,5,3,3,6,1,2,4,2,1,6,5,4,2,3,4,2,3,3,5,4,1,4,4,5,3,6,1,5,2,3,3,6,1,6,4,1,3]", 2, 53, "[]")]
    public void MissingRolls_WithRollsMeanAndN_ReturnsMissingRolls(string rollsJsonArray, int mean, int n,
        string expectedResultJsonArray)
    {
        // Arrange
        var rolls = JsonHelper<int>.DeserializeToArray(rollsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MissingRolls(rolls, mean, n);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }
}