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

using LeetCode.Algorithms.FlippingAnImage;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FlippingAnImage;

public abstract class FlippingAnImageTestsBase<T> where T : IFlippingAnImage, new()
{
    [TestMethod]
    [DataRow("[[1,1,0],[1,0,1],[0,0,0]]", "[[1,0,0],[0,1,0],[1,1,1]]")]
    [DataRow("[[1,1,0,0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]", "[[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]")]
    public void FlipAndInvertImage_WithMatrixContainingBinaryValues_ReturnsHorizontallyFlippedAndInvertedMatrix(
        string imageJson, string expectedResultJson)
    {
        // Arrange
        var image = JsonHelper<int[][]>.Parse(imageJson);
        var expectedResult = JsonHelper<int[][]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.FlipAndInvertImage(image);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}