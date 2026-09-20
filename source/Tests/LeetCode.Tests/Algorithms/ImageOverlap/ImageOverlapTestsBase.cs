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

using LeetCode.Algorithms.ImageOverlap;

namespace LeetCode.Tests.Algorithms.ImageOverlap;

public abstract class ImageOverlapTestsBase<T> where T : IImageOverlap, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void LargestOverlap_WithGivenImages_ReturnsMaximumOverlap(int[][] img1, int[][] img2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestOverlap(img1, img2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { new[] { 1, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 } },
            new[] { new[] { 0, 0, 0 }, new[] { 0, 1, 1 }, new[] { 0, 0, 1 } },
            3
        ];

        yield return [new[] { new[] { 1 } }, new[] { new[] { 1 } }, 1];

        yield return [new[] { new[] { 0 } }, new[] { new[] { 0 } }, 0];

        yield return [new[] { new[] { 1 } }, new[] { new[] { 0 } }, 0];

        yield return [new[] { new[] { 0 } }, new[] { new[] { 1 } }, 0];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, new[] { new[] { 1, 1 }, new[] { 1, 1 } }, 0];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 0];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, new[] { new[] { 1, 1 }, new[] { 1, 1 } }, 4];

        yield return [new[] { new[] { 1, 0 }, new[] { 0, 0 } }, new[] { new[] { 0, 1 }, new[] { 0, 0 } }, 1];

        yield return [new[] { new[] { 0, 1 }, new[] { 0, 0 } }, new[] { new[] { 1, 0 }, new[] { 0, 0 } }, 1];

        yield return [new[] { new[] { 1, 0 }, new[] { 0, 0 } }, new[] { new[] { 0, 0 }, new[] { 1, 0 } }, 1];

        yield return [new[] { new[] { 0, 0 }, new[] { 1, 0 } }, new[] { new[] { 1, 0 }, new[] { 0, 0 } }, 1];

        yield return [new[] { new[] { 1, 0 }, new[] { 0, 0 } }, new[] { new[] { 0, 0 }, new[] { 0, 1 } }, 1];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 1 } }, new[] { new[] { 1, 0 }, new[] { 0, 0 } }, 1];

        yield return [new[] { new[] { 0, 1 }, new[] { 0, 0 } }, new[] { new[] { 0, 0 }, new[] { 1, 0 } }, 1];

        yield return [new[] { new[] { 0, 0 }, new[] { 1, 0 } }, new[] { new[] { 0, 1 }, new[] { 0, 0 } }, 1];

        yield return [new[] { new[] { 1, 1 }, new[] { 0, 0 } }, new[] { new[] { 0, 0 }, new[] { 1, 1 } }, 2];

        yield return [new[] { new[] { 0, 0 }, new[] { 1, 1 } }, new[] { new[] { 1, 1 }, new[] { 0, 0 } }, 2];

        yield return [new[] { new[] { 1, 0 }, new[] { 1, 0 } }, new[] { new[] { 0, 1 }, new[] { 0, 1 } }, 2];

        yield return [new[] { new[] { 0, 1 }, new[] { 0, 1 } }, new[] { new[] { 1, 0 }, new[] { 1, 0 } }, 2];

        yield return [new[] { new[] { 1, 1 }, new[] { 0, 0 } }, new[] { new[] { 1, 0 }, new[] { 1, 0 } }, 1];

        yield return [new[] { new[] { 1, 0 }, new[] { 0, 1 } }, new[] { new[] { 0, 1 }, new[] { 1, 0 } }, 1];

        yield return
        [
            new[] { new[] { 1, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 1 } },
            new[] { new[] { 1, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 1 } },
            3
        ];

        yield return
        [
            new[] { new[] { 1, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 1 } },
            new[] { new[] { 0, 0, 1 }, new[] { 0, 1, 0 }, new[] { 1, 0, 0 } },
            1
        ];

        yield return
        [
            new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } },
            new[] { new[] { 0, 1, 0 }, new[] { 1, 1, 1 }, new[] { 0, 1, 0 } },
            5
        ];

        yield return
        [
            new[] { new[] { 0, 1, 0 }, new[] { 1, 1, 1 }, new[] { 0, 1, 0 } },
            new[] { new[] { 0, 1, 0 }, new[] { 1, 1, 1 }, new[] { 0, 1, 0 } },
            5
        ];

        yield return
        [
            new[] { new[] { 1, 0, 1 }, new[] { 0, 1, 0 }, new[] { 1, 0, 1 } },
            new[] { new[] { 0, 1, 0 }, new[] { 1, 0, 1 }, new[] { 0, 1, 0 } },
            3
        ];

        yield return
        [
            new[] { new[] { 1, 1, 0 }, new[] { 1, 0, 0 }, new[] { 0, 0, 0 } },
            new[] { new[] { 0, 1, 1 }, new[] { 0, 0, 1 }, new[] { 0, 0, 0 } },
            2
        ];

        yield return
        [
            new[] { new[] { 1, 0, 0, 0 }, new[] { 0, 1, 0, 0 }, new[] { 0, 0, 1, 0 }, new[] { 0, 0, 0, 1 } },
            new[] { new[] { 0, 0, 0, 1 }, new[] { 0, 0, 1, 0 }, new[] { 0, 1, 0, 0 }, new[] { 1, 0, 0, 0 } },
            1
        ];

        yield return
        [
            new[] { new[] { 1, 0, 1, 0 }, new[] { 0, 0, 0, 0 }, new[] { 1, 0, 1, 0 }, new[] { 0, 0, 0, 0 } },
            new[] { new[] { 0, 0, 0, 0 }, new[] { 0, 1, 0, 1 }, new[] { 0, 0, 0, 0 }, new[] { 0, 1, 0, 1 } },
            4
        ];

        var fullImage = Enumerable.Range(0, 30).Select(_ => Enumerable.Repeat(1, 30).ToArray()).ToArray();
        var emptyImage = Enumerable.Range(0, 30).Select(_ => new int[30]).ToArray();
        var leftEdgeImage = Enumerable.Range(0, 30).Select(_ => new int[30]).ToArray();
        var rightEdgeImage = Enumerable.Range(0, 30).Select(_ => new int[30]).ToArray();

        for (var row = 0; row < 30; row++)
        {
            leftEdgeImage[row][0] = 1;
            rightEdgeImage[row][29] = 1;
        }

        yield return [fullImage, fullImage, 900];
        yield return [emptyImage, fullImage, 0];
        yield return [leftEdgeImage, rightEdgeImage, 30];
        yield return [rightEdgeImage, leftEdgeImage, 30];
    }
}