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

using LeetCode.Algorithms.ArithmeticSubarrays;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ArithmeticSubarrays;

public abstract class ArithmeticSubarraysTestsBase<T> where T : IArithmeticSubarrays, new()
{
    [TestMethod]
    [DataRow("[4, 6, 5, 9, 3, 7]", "[0, 0, 2]", "[2, 3, 5]", "[true, false, true]")]
    [DataRow("[-12, -9, -3, -12, -6, 15, 20, -25, -20, -15, -10]", "[0, 1, 6, 4, 8, 7]", "[4, 4, 9, 7, 9, 10]",
        "[false, true, false, false, true, true]")]
    [DataRow("[1, 2, 3]", "[0, 1]", "[1, 2]", "[true, true]")]
    [DataRow("[10, 1, 3, 5]", "[0, 1]", "[2, 3]", "[false, true]")]
    [DataRow("[1, 3, 5, 7, 9]", "[0, 1, 2]", "[4, 3, 4]", "[true, true, true]")]
    [DataRow("[1, 2, 4]", "[0, 1]", "[2, 2]", "[false, true]")]
    public void CheckArithmeticSubarrays_WithVariousRanges_VerifiesIfSubarraysAreArithmetic(string numsJsonArray,
        string lJsonArray, string rJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var l = JsonHelper<int>.DeserializeToArray(lJsonArray);
        var r = JsonHelper<int>.DeserializeToArray(rJsonArray);
        var expectedResult = JsonHelper<bool>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.CheckArithmeticSubarrays(nums, l, r);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}