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

using LeetCode.Algorithms.ValidArrangementOfPairs;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ValidArrangementOfPairs;

public abstract class ValidArrangementOfPairsTestsBase<T> where T : IValidArrangementOfPairs, new()
{
    [TestMethod]
    //[DataRow("[[1,2],[1,3],[2,1]]", "[[1,2],[2,1],[1,3]]")]
    //[DataRow("[[1,3],[3,2],[2,1]]", "[[1,3],[3,2],[2,1]]")]
    //[DataRow("[[5,1],[4,5],[11,9],[9,4]]", "[[11,9],[9,4],[4,5],[5,1]]")]
    //[DataRow("[[5,1],[4,5],[11,9],[9,4],[5,2],[2,6],[6,7],[7,8],[8,5],[5,12],[12,13],[13,5]]",
    //    "[[11,9],[9,4],[4,5],[5,12],[12,13],[13,5],[5,2],[2,6],[6,7],[7,8],[8,5],[5,1]]")]
    [DataRow("[[4,5],[11,9],[9,4],[5,2],[2,6],[6,7],[7,8],[8,5],[5,12],[12,13],[13,5],[5,1]] ",
        "[[11,9],[9,4],[4,5],[5,12],[12,13],[13,5],[5,2],[2,6],[6,7],[7,8],[8,5],[5,1]]")]
    public void ValidArrangement_WithDirectedEdgePairs_ReturnsValidArrangementOfPairs(string pairsJson,
        string expectedResultJson)
    {
        // Arrange
        var pairs = JsonHelper<int[][]>.Parse(pairsJson);
        var expectedResult = JsonHelper<int[][]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.ValidArrangement(pairs);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}