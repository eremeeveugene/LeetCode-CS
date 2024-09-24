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

using LeetCode.Algorithms.FindTheLengthOfTheLongestCommonPrefix;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindTheLengthOfTheLongestCommonPrefix;

public abstract class FindTheLengthOfTheLongestCommonPrefixTestsBase<T>
    where T : IFindTheLengthOfTheLongestCommonPrefix, new()
{
    [TestMethod]
    [DataRow("[1,10,100]", "[1000]", 3)]
    [DataRow("[1,2,3]", "[4,4,4]", 0)]
    [DataRow("[98765432]", "[987]", 3)]
    [DataRow("[12,3456]", "[12345,456789,12]", 2)]
    [DataRow("[1248,364524,73264823,2937935]", "[73249,94895,656324,239583,1249]", 3)]
    [DataRow("[123987, 567890, 234567, 890123, 456789]", "[908123, 456123, 789012, 234567]", 6)]
    [DataRow("[10987654, 123, 87654321, 654321]", "[109876, 1234567, 87654321, 654]", 8)]
    public void LongestCommonPrefix_GivenTwoIntegerArrays_ReturnsLongestCommonPrefix(string arr1JsonArray,
        string arr2JsonArray, int expectedResult)
    {
        // Arrange
        var arr1 = JsonHelper<int>.DeserializeToArray(arr1JsonArray);
        var arr2 = JsonHelper<int>.DeserializeToArray(arr2JsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.LongestCommonPrefix(arr1, arr2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}