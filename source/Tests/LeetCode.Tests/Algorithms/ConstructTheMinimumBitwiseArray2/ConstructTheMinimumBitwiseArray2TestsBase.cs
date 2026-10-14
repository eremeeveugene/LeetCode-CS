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

using LeetCode.Algorithms.ConstructTheMinimumBitwiseArray2;

namespace LeetCode.Tests.Algorithms.ConstructTheMinimumBitwiseArray2;

public abstract class ConstructTheMinimumBitwiseArray2TestsBase<T> where T : IConstructTheMinimumBitwiseArray2, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, 5, 7 }, new[] { -1, 1, 4, 3 })]
    [DataRow(new[] { 11, 13, 31 }, new[] { 9, 12, 15 })]
    [DataRow(new[] { 2 }, new[] { -1 })]
    [DataRow(new[] { 3 }, new[] { 1 })]
    [DataRow(new[] { 5 }, new[] { 4 })]
    [DataRow(new[] { 7 }, new[] { 3 })]
    [DataRow(new[] { 1009 }, new[] { 1008 })]
    [DataRow(new[] { 1013 }, new[] { 1012 })]
    [DataRow(new[] { 2039 }, new[] { 2035 })]
    [DataRow(new[] { 4093 }, new[] { 4092 })]
    [DataRow(new[] { 8191 }, new[] { 4095 })]
    [DataRow(new[] { 10007 }, new[] { 10003 })]
    [DataRow(new[] { 65537 }, new[] { 65536 })]
    [DataRow(new[] { 131071 }, new[] { 65535 })]
    [DataRow(new[] { 524287 }, new[] { 262143 })]
    [DataRow(new[] { 1000003 }, new[] { 1000001 })]
    [DataRow(new[] { 999999937 }, new[] { 999999936 })]
    [DataRow(new[] { 999999929 }, new[] { 999999928 })]
    [DataRow(new[] { 999999893 }, new[] { 999999892 })]
    [DataRow(new[] { 536870909 }, new[] { 536870908 })]
    [DataRow(new[] { 268435399 }, new[] { 268435395 })]
    [DataRow(new[] { 16777213, 8388593 }, new[] { 16777212, 8388592 })]
    public void MinBitwiseArray_WithPrimeInputs_ConstructsMinimalBitwiseArrayOrSetsToNegativeOne(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinBitwiseArray(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}