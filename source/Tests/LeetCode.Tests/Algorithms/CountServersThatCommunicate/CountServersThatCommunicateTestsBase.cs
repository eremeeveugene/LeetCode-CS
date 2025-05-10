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

using LeetCode.Algorithms.CountServersThatCommunicate;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountServersThatCommunicate;

public abstract class CountServersThatCommunicateTestsBase<T> where T : ICountServersThatCommunicate, new()
{
    [TestMethod]
    [DataRow("[[1,0],[0,1]]", 0)]
    [DataRow("[[1,0],[1,1]]", 3)]
    [DataRow("[[1,1,0,0],[0,0,1,0],[0,0,1,0],[0,0,0,1]]", 4)]
    public void CountServers_WithGridInput_ReturnsNumberOfCommunicatingServers(string numsJson, int expectedResult)
    {
        // Arrange
        var grid = JsonHelper<int>.DeserializeToJaggedArray(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountServers(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}