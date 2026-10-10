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

using LeetCode.Algorithms.SpiralMatrix;

namespace LeetCode.Tests.Algorithms.SpiralMatrix;

public abstract class SpiralMatrixTestsBase<T> where T : ISpiralMatrix, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SpiralOrder_With2DMatrix_ReturnsElementsInSpiralOrder(int[][] matrix, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var spiralOrder = solution.SpiralOrder(matrix);

        var actualResult = new int[spiralOrder.Count];

        spiralOrder.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }];

        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 } }, new[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }];
        yield return [new[] { new[] { -100 } }, new[] { -100 }];
        yield return [new[] { new[] { 29, -57 } }, new[] { 29, -57 }];
        yield return [new[] { new[] { -23 }, new[] { 52 } }, new[] { -23, 52 }];
        yield return [new[] { new[] { -86, -48, -54, -20, -73, 42, 8, 50, -16, 91 } }, new[] { -86, -48, -54, -20, -73, 42, 8, 50, -16, 91 }];
        yield return [new[] { new[] { -15 }, new[] { -62 }, new[] { -99 }, new[] { -80 }, new[] { -30 }, new[] { 43 }, new[] { 26 }, new[] { 75 }, new[] { 61 }, new[] { -53 } }, new[] { -15, -62, -99, -80, -30, 43, 26, 75, 61, -53 }];
        yield return [new[] { new[] { -97, 76 }, new[] { -61, 18 } }, new[] { -97, 76, 18, -61 }];
        yield return [new[] { new[] { 93, -55, 25 }, new[] { -60, -19, -11 } }, new[] { 93, -55, 25, -11, -19, -60 }];
        yield return [new[] { new[] { -52, -16 }, new[] { 42, -62 }, new[] { -59, 74 } }, new[] { -52, -16, -62, 74, -59, 42 }];
        yield return [new[] { new[] { -17, -11, -86 }, new[] { 86, 9, -53 }, new[] { 12, -8, 80 } }, new[] { -17, -11, -86, -53, 80, -8, 12, 86, 9 }];
        yield return [new[] { new[] { 86, 1, -81, 30 }, new[] { 29, -77, 0, 22 }, new[] { 71, -40, 19, 97 }, new[] { -100, -68, 65, -38 } }, new[] { 86, 1, -81, 30, 22, 97, -38, 65, -68, -100, 71, 29, -77, 0, 19, -40 }];
        yield return [new[] { new[] { -86, -100, -87 }, new[] { 35, 87, -36 }, new[] { -52, -59, 50 }, new[] { -90, -41, -15 }, new[] { 69, -32, -57 } }, new[] { -86, -100, -87, -36, 50, -15, -57, -32, 69, -90, -52, 35, 87, -59, -41 }];
        yield return [new[] { new[] { 33, 55, 10, -89, -10 }, new[] { -78, 74, 28, -75, -69 }, new[] { -35, -29, -45, 11, 54 } }, new[] { 33, 55, 10, -89, -10, -69, 54, 11, -45, -29, -35, -78, 74, 28, -75 }];
        yield return [new[] { new[] { 60 }, new[] { -86 }, new[] { -24 }, new[] { 55 } }, new[] { 60, -86, -24, 55 }];
        yield return [new[] { new[] { 18, -86, 40, 15, -25, 100, -69 } }, new[] { 18, -86, 40, 15, -25, 100, -69 }];
        yield return [new[] { new[] { -67, 11, -29, 88, -18, 40 }, new[] { 99, 44, 79, 88, 87, -10 }, new[] { -81, -58, 66, 86, -91, -30 }, new[] { 5, -92, 3, -37, -56, -32 }, new[] { 1, -14, -47, 77, 99, -30 }, new[] { -72, 89, 54, 100, -81, 92 } }, new[] { -67, 11, -29, 88, -18, 40, -10, -30, -32, -30, 92, -81, 100, 54, 89, -72, 1, 5, -81, 99, 44, 79, 88, 87, -91, -56, 99, 77, -47, -14, -92, -58, 66, 86, -37, 3 }];
        yield return [new[] { new[] { -51, 98, 20, -68, 75, -50, -70, 31, 63, 91 }, new[] { -25, -38, -77, 3, -28, -33, 89, 55, -77, 34 }, new[] { 8, -92, 46, 54, 56, -4, 51, 42, 24, 9 }, new[] { -71, 49, 45, 61, 98, 82, 49, 67, -73, 78 }, new[] { -83, -20, -75, -52, 17, -78, -69, 9, 3, 72 }, new[] { -28, 33, -70, -1, -63, -6, -35, -24, -76, 3 }, new[] { 5, -29, -34, -68, 26, -45, -87, -1, -92, -12 }, new[] { 12, -48, 35, 65, 42, -80, 43, -41, 51, -96 }, new[] { 0, 60, 38, 61, 35, 11, 63, -20, -31, -48 }, new[] { 49, -95, -81, -49, 49, 25, -56, 45, 86, 74 } }, new[] { -51, 98, 20, -68, 75, -50, -70, 31, 63, 91, 34, 9, 78, 72, 3, -12, -96, -48, 74, 86, 45, -56, 25, 49, -49, -81, -95, 49, 0, 12, 5, -28, -83, -71, 8, -25, -38, -77, 3, -28, -33, 89, 55, -77, 24, -73, 3, -76, -92, 51, -31, -20, 63, 11, 35, 61, 38, 60, -48, -29, 33, -20, 49, -92, 46, 54, 56, -4, 51, 42, 67, 9, -24, -1, -41, 43, -80, 42, 65, 35, -34, -70, -75, 45, 61, 98, 82, 49, -69, -35, -87, -45, 26, -68, -1, -52, 17, -78, -6, -63 }];
        yield return [new[] { new[] { 7, -79, 13, 83 }, new[] { 34, 86, -5, 19 }, new[] { 18, -62, 0, -49 }, new[] { 75, -26, 42, 35 }, new[] { 33, -22, -37, -21 }, new[] { -10, -96, -61, 84 }, new[] { 70, 10, 34, -74 } }, new[] { 7, -79, 13, 83, 19, -49, 35, -21, 84, -74, 34, 10, 70, -10, 33, 75, 18, 34, 86, -5, 0, 42, -37, -61, -96, -22, -26, -62 }];
        yield return [new[] { new[] { -73, -51, 84, 9, -92, 50, -84, -67, 38 }, new[] { 77, -66, 50, 9, -24, 65, 66, 84, -94 } }, new[] { -73, -51, 84, 9, -92, 50, -84, -67, 38, -94, 84, 66, 65, -24, 9, 50, -66, 77 }];
    }
}