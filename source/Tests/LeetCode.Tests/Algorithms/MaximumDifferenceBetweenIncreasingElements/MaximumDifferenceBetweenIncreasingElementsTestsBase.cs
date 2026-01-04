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

using LeetCode.Algorithms.MaximumDifferenceBetweenIncreasingElements;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumDifferenceBetweenIncreasingElements;

public abstract class MaximumDifferenceBetweenIncreasingElementsTestsBase<T>
    where T : IMaximumDifferenceBetweenIncreasingElements, new()
{
    [TestMethod]
    [DataRow("[7,1,5,4]", 4)]
    [DataRow("[9,4,3,2]", -1)]
    [DataRow("[1,5,2,10]", 9)]
    [DataRow(
        "[999,997,980,976,948,940,938,928,924,917,907,907,881,878,864,862,859,857,848,840,824,824,824,805,802,798,788,777,775,766,755,748,735,732,727,705,700,697,693,679,676,644,634,624,599,596,588,583,562,558,553,539,537,536,509,491,485,483,454,449,438,425,403,368,345,327,287,285,270,263,255,248,235,234,224,221,201,189,187,183,179,168,155,153,150,144,107,102,102,87,80,57,55,49,48,45,26,26,23,15]",
        -1)]
    public void MaximumDifference_WithValidIncreasingPairs_ReturnsMaximumDifference(string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaximumDifference(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}