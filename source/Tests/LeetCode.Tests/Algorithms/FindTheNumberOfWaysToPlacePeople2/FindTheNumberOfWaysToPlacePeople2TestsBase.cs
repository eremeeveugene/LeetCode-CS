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

using LeetCode.Algorithms.FindTheNumberOfWaysToPlacePeople2;

namespace LeetCode.Tests.Algorithms.FindTheNumberOfWaysToPlacePeople2;

public abstract class FindTheNumberOfWaysToPlacePeople2TestsBase<T> where T : IFindTheNumberOfWaysToPlacePeople2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void NumberOfPairs_With2DPointsArray_ReturnsCountOfValidPairs(int[][] points, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfPairs(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 } }, 0];

        yield return [new[] { new[] { 3, 1 }, new[] { 1, 3 }, new[] { 1, 1 } }, 2];

        yield return [new[] { new[] { 6, 2 }, new[] { 4, 4 }, new[] { 2, 6 } }, 2];

        yield return [new[] { new[] { 6, 2 }, new[] { 4, 4 }, new[] { 2, 6 }, new[] { 4, 8 } }, 3];

        yield return [new[] { new[] { 6, 2 }, new[] { 4, 4 }, new[] { 2, 6 }, new[] { 4, 8 }, new[] { 1, 4 } }, 4];

        yield return [new[] { new[] { 6, 2 }, new[] { 4, 4 }, new[] { 2, 6 }, new[] { 4, 8 }, new[] { 1, 4 }, new[] { 2, 2 } }, 7];

        yield return [new[] { new[] { 1, 1 }, new[] { 5, 0 } }, 1];

        yield return [new[] { new[] { 6, 4 }, new[] { 4, 5 } }, 1];

        yield return [new[] { new[] { 300883282, 228063029 }, new[] { 219020650, 804216645 }, new[] { 985007987, 982417824 } }, 1];

        yield return [new[] { new[] { 289044777, 441765906 }, new[] { 478572662, 267430466 }, new[] { 64913680, 50034369 } }, 1];

        yield return [new[] { new[] { 2, 4 }, new[] { 1, 3 }, new[] { 0, 2 }, new[] { 4, 1 } }, 3];

        yield return [new[] { new[] { 4, 0 }, new[] { 0, 3 }, new[] { 2, 5 }, new[] { 2, 0 } }, 3];

        yield return [new[] { new[] { 784366237, 334001415 }, new[] { 486502501, 586365427 }, new[] { 342421092, 146679362 }, new[] { 77773330, 80812926 }, new[] { 517796670, 72231225 } }, 4];

        yield return [new[] { new[] { 508178856, 967265230 }, new[] { 91189479, 735669865 }, new[] { 366805316, 377778985 }, new[] { 83396782, 935337854 }, new[] { 851763604, 982476537 } }, 2];

        yield return [new[] { new[] { 4, 0 }, new[] { 0, 0 }, new[] { 3, 3 }, new[] { 4, 5 }, new[] { 2, 3 }, new[] { 5, 0 } }, 5];

        yield return [new[] { new[] { 0, 2 }, new[] { 3, 3 }, new[] { 6, 4 }, new[] { 3, 0 }, new[] { 4, 0 }, new[] { 0, 4 } }, 6];

        yield return [new[] { new[] { 728144037, 656870244 }, new[] { 217512618, 556621989 }, new[] { 274695602, 962521988 }, new[] { 323231338, 153781709 }, new[] { 182114291, 809355755 }, new[] { 12141021, 395084754 }, new[] { 972511163, 367782633 } }, 9];

        yield return [new[] { new[] { 3, 1 }, new[] { 4, 2 }, new[] { 3, 6 }, new[] { 1, 1 }, new[] { 5, 2 }, new[] { 1, 5 }, new[] { 1, 3 }, new[] { 6, 6 } }, 8];

        yield return [new[] { new[] { 4, 3 }, new[] { 5, 6 }, new[] { 3, 3 }, new[] { 3, 5 }, new[] { 6, 3 }, new[] { 2, 1 }, new[] { 6, 4 }, new[] { 5, 2 } }, 8];

        yield return [new[] { new[] { 688252991, 145901280 }, new[] { 380335156, 331818808 }, new[] { 697165922, 849881168 }, new[] { 825936312, 890849698 }, new[] { 605632246, 20523518 }, new[] { 728270449, 760886664 }, new[] { 301796988, 612657718 }, new[] { 203923430, 26549881 }, new[] { 435068434, 488372590 } }, 8];
    }
}