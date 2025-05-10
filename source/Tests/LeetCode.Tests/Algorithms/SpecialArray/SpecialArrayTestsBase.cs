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

using LeetCode.Algorithms.SpecialArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SpecialArray;

public abstract class SpecialArrayTestsBase<T> where T : ISpecialArray, new()
{
    [TestMethod]
    [DataRow("[1]", true)]
    [DataRow("[2,1,4]", true)]
    [DataRow("[4,3,1,6]", false)]
    public void IsArraySpecial_WithArrayInput_ReturnsWhetherArrayIsSpecial(string numsJson, bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.IsArraySpecial(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}