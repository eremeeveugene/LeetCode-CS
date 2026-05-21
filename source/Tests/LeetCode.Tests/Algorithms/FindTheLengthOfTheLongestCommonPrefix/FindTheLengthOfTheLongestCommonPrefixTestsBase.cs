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

using LeetCode.Algorithms.FindTheLengthOfTheLongestCommonPrefix;

namespace LeetCode.Tests.Algorithms.FindTheLengthOfTheLongestCommonPrefix;

public abstract class FindTheLengthOfTheLongestCommonPrefixTestsBase<T> where T : IFindTheLengthOfTheLongestCommonPrefix, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 10, 100 }, new[] { 1000 }, 3)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 4, 4, 4 }, 0)]
    [DataRow(new[] { 98765432 }, new[] { 987 }, 3)]
    [DataRow(new[] { 12, 3456 }, new[] { 12345, 456789, 12 }, 2)]
    [DataRow(new[] { 1248, 364524, 73264823, 2937935 }, new[] { 73249, 94895, 656324, 239583, 1249 }, 3)]
    [DataRow(new[] { 123987, 567890, 234567, 890123, 456789 }, new[] { 908123, 456123, 789012, 234567 }, 6)]
    [DataRow(new[] { 10987654, 123, 87654321, 654321 }, new[] { 109876, 1234567, 87654321, 654 }, 8)]
    [DataRow(new[] { 1 }, new[] { 1 }, 1)]
    [DataRow(new[] { 1 }, new[] { 9 }, 0)]
    [DataRow(new[] { 100000000 }, new[] { 100000000 }, 9)]
    [DataRow(new[] { 100000000 }, new[] { 100000001 }, 8)]
    [DataRow(new[] { 99999999 }, new[] { 99999998 }, 7)]
    [DataRow(new[] { 12345678 }, new[] { 12349999 }, 4)]
    [DataRow(new[] { 12345678 }, new[] { 87654321 }, 0)]
    [DataRow(new[] { 5, 55, 555, 5555 }, new[] { 55555, 54 }, 4)]
    [DataRow(new[] { 10, 101, 1010 }, new[] { 10101, 11 }, 4)]
    [DataRow(new[] { 90, 901, 9012 }, new[] { 90123, 90234 }, 4)]
    [DataRow(new[] { 7, 70, 700, 7000 }, new[] { 8, 80, 8000 }, 0)]
    [DataRow(new[] { 123, 456, 789 }, new[] { 1239, 4567, 78901 }, 3)]
    [DataRow(new[] { 100, 200, 300 }, new[] { 199, 299, 399 }, 1)]
    public void LongestCommonPrefix_GivenTwoIntegerArrays_ReturnsLongestCommonPrefix(int[] arr1, int[] arr2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestCommonPrefix(arr1, arr2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}