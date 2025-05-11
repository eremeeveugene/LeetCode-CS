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

using LeetCode.Algorithms.NeighboringBitwiseXOR;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.NeighboringBitwiseXOR;

public abstract class NeighboringBitwiseXORTestsBase<T> where T : INeighboringBitwiseXOR, new()
{
    [TestMethod]
    [DataRow("[1,1,0]", true)]
    [DataRow("[1,1]", true)]
    [DataRow("[1,0]", false)]
    public void DoesValidArrayExist_WithDerivedArray_ReturnsWhetherValidArrayExists(string derivedJson,
        bool expectedResult)
    {
        // Arrange
        var derived = JsonHelper<int[]>.Parse(derivedJson);

        var solution = new T();

        // Act
        var actualResult = solution.DoesValidArrayExist(derived);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}