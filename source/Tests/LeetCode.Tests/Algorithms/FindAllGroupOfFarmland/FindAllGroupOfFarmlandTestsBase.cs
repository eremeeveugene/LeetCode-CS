﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.FindAllGroupOfFarmland;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.FindAllGroupOfFarmland;

public abstract class FindAllGroupOfFarmlandTestsBase<T> where T : IFindAllGroupOfFarmland, new()
{
    [TestMethod]
    [DataRow("[[0]]", "[]")]
    [DataRow("[[1,1],[0,0]]", "[[0,0,0,1]]")]
    [DataRow("[[1,1],[1,1]]", "[[0,0,1,1]]")]
    [DataRow("[[0,1],[0,1]]", "[[0,1,1,1]]")]
    [DataRow("[[1,0,0],[0,1,1],[0,1,1]]", "[[0,0,0,0],[1,1,2,2]]")]
    [DataRow("[[0,0,0,0,0],[0,1,1,1,0],[0,1,1,1,0],[0,1,1,1,0],[0,0,0,0,0]]", "[[1,1,3,3]]")]
    public void FindFarmland_GivenLandArray_ReturnsExpectedFarmBoundaries(string landJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var expectedResult = JsonHelper<int>.DeserializeToJaggedArray(expectedResultJsonArray);

        var solution = new T();

        var land = JsonHelper<int>.DeserializeToJaggedArray(landJsonArray);

        // Act
        var actualResult = solution.FindFarmland(land);

        // Assert
        JaggedArrayAssert.AreEqual(expectedResult, actualResult);
    }
}