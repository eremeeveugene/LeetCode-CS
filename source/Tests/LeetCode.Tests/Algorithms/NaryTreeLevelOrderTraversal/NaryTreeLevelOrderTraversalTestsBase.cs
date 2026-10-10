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

using LeetCode.Algorithms.NaryTreeLevelOrderTraversal;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.NaryTreeLevelOrderTraversal;

public abstract class NaryTreeLevelOrderTraversalTestsBase<T> where T : INaryTreeLevelOrderTraversal, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void LevelOrder_WithNaryTree_ReturnsNodeValuesByLevel(int?[] rootArray, int[][] expectedResult)
    {
        // Arrange
        var root = Node.ToNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.LevelOrder(root);

        // Assert
        Assert.AreEquivalent<IEnumerable<IEnumerable<int>>>(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int[]>()];

        yield return [new int?[] { 1, null, 3, 2, 4, null, 5, 6 }, new[] { new[] { 1 }, new[] { 3, 2, 4 }, new[] { 5, 6 } }];

        yield return
        [
            new int?[] { 1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null, null, 14 },
            new[] { new[] { 1 }, new[] { 2, 3, 4, 5 }, new[] { 6, 7, 8, 9, 10 }, new[] { 11, 12, 13 }, new[] { 14 } }
        ];

        yield return [new int?[] { 1 }, new[] { new[] { 1 } }];

        yield return [new int?[] { 1, null, 2 }, new[] { new[] { 1 }, new[] { 2 } }];

        yield return [new int?[] { 3, null, 1, null, 2 }, new[] { new[] { 3 }, new[] { 1 }, new[] { 2 } }];

        yield return [new int?[] { 2, null, 3, 1 }, new[] { new[] { 2 }, new[] { 3, 1 } }];

        yield return [new int?[] { 2, null, 4, null, 5, null, 1, null, 3 }, new[] { new[] { 2 }, new[] { 4 }, new[] { 5 }, new[] { 1 }, new[] { 3 } }];

        yield return [new int?[] { 3, null, 5, 2, 4, 6, 1 }, new[] { new[] { 3 }, new[] { 5, 2, 4, 6, 1 } }];

        yield return [new int?[] { 7, null, 3, 6, 1, null, 2, null, 4, null, null, null, 5 }, new[] { new[] { 7 }, new[] { 3, 6, 1 }, new[] { 2, 4 }, new[] { 5 } }];

        yield return [new int?[] { 6, null, 5, 7, 8, null, 2, 1, null, 9, 4, null, null, 3 }, new[] { new[] { 6 }, new[] { 5, 7, 8 }, new[] { 2, 1, 9, 4 }, new[] { 3 } }];

        yield return [new int?[] { 9, null, 3, null, 2, 7, 5, 6, null, null, 1, null, 10, null, 8, null, null, null, 4 }, new[] { new[] { 9 }, new[] { 3 }, new[] { 2, 7, 5, 6 }, new[] { 1, 10, 8 }, new[] { 4 } }];

        yield return [new int?[] { 3, null, 2, 10, 1, null, 7, 4, null, 12, 5, null, 11, 6, 8, null, null, null, null, null, null, 9 }, new[] { new[] { 3 }, new[] { 2, 10, 1 }, new[] { 7, 4, 12, 5, 11, 6, 8 }, new[] { 9 } }];

        yield return [new int?[] { 4, null, 14, 6, 10, null, 3, 15, null, null, null, 9, 7, 11, null, null, 1, 12, 8, null, 5, null, 2, null, null, 13 }, new[] { new[] { 4 }, new[] { 14, 6, 10 }, new[] { 3, 15 }, new[] { 9, 7, 11 }, new[] { 1, 12, 8, 5, 2 }, new[] { 13 } }];

        yield return [new int?[] { 1, null, 9, 11, 4, 3, null, 6, 20, 12, 19, null, 7, 16, null, null, null, 14, null, 15, 17, 13, null, null, 2, null, null, 18, null, 8, null, null, null, null, 10, null, null, 5 }, new[] { new[] { 1 }, new[] { 9, 11, 4, 3 }, new[] { 6, 20, 12, 19, 7, 16 }, new[] { 14, 15, 17, 13, 2, 18 }, new[] { 8, 10 }, new[] { 5 } }];

        yield return [new int?[] { 3, null, 22, 10, 6, 9, null, 12, 1, null, 4, 24, null, 14, 2, 25, null, 8, null, 16, 7, null, null, null, null, 23, 20, null, null, null, 13, null, 21, null, 5, null, 18, null, null, null, 15, 17, 11, 19 }, new[] { new[] { 3 }, new[] { 22, 10, 6, 9 }, new[] { 12, 1, 4, 24, 14, 2, 25, 8 }, new[] { 16, 7, 23, 20, 13 }, new[] { 21, 5, 18 }, new[] { 15, 17, 11, 19 } }];

        yield return [new int?[] { 15, null, 13, 28, 2, 23, null, 8, 19, 30, null, 17, null, null, 24, null, 22, 18, 16, null, 10, 14, 25, null, 26, null, null, null, 20, 6, 9, null, 21, null, null, 11, 4, null, 29, 12, 7, 1, null, null, null, null, null, null, null, null, null, 27, 5, null, null, null, 3 }, new[] { new[] { 15 }, new[] { 13, 28, 2, 23 }, new[] { 8, 19, 30, 17, 24 }, new[] { 22, 18, 16, 10, 14, 25, 26 }, new[] { 20, 6, 9, 21, 11, 4, 29, 12, 7, 1 }, new[] { 27, 5, 3 } }];

        yield return [new int?[] { 74, null, 24, null, 68, null, 97, null, 8, null, 7, null, 81, null, 44, null, 36, null, 91, null, 28, null, 42, null, 55, null, 15, null, 89, null, 78, null, 80, null, 37, null, 65, null, 71, null, 32, null, 72, null, 40, null, 93, null, 5, null, 90, null, 31, null, 99, null, 70, null, 6, null, 25, null, 29, null, 58, null, 39, null, 41, null, 10, null, 48, null, 46, null, 54, null, 47, null, 34, null, 95, null, 30, null, 88, null, 76, null, 9, null, 27, null, 35, null, 57, null, 100, null, 38, null, 49, null, 92, null, 33, null, 73, null, 59, null, 69, null, 67, null, 66, null, 63, null, 53, null, 13, null, 64, null, 87, null, 18, null, 14, null, 2, null, 3, null, 77, null, 75, null, 96, null, 61, null, 19, null, 86, null, 20, null, 4, null, 17, null, 22, null, 21, null, 94, null, 52, null, 60, null, 51, null, 12, null, 43, null, 82, null, 56, null, 23, null, 98, null, 26, null, 50, null, 16, null, 85, null, 11, null, 83, null, 45, null, 84, null, 62, null, 1, null, 79 }, new[] { new[] { 74 }, new[] { 24 }, new[] { 68 }, new[] { 97 }, new[] { 8 }, new[] { 7 }, new[] { 81 }, new[] { 44 }, new[] { 36 }, new[] { 91 }, new[] { 28 }, new[] { 42 }, new[] { 55 }, new[] { 15 }, new[] { 89 }, new[] { 78 }, new[] { 80 }, new[] { 37 }, new[] { 65 }, new[] { 71 }, new[] { 32 }, new[] { 72 }, new[] { 40 }, new[] { 93 }, new[] { 5 }, new[] { 90 }, new[] { 31 }, new[] { 99 }, new[] { 70 }, new[] { 6 }, new[] { 25 }, new[] { 29 }, new[] { 58 }, new[] { 39 }, new[] { 41 }, new[] { 10 }, new[] { 48 }, new[] { 46 }, new[] { 54 }, new[] { 47 }, new[] { 34 }, new[] { 95 }, new[] { 30 }, new[] { 88 }, new[] { 76 }, new[] { 9 }, new[] { 27 }, new[] { 35 }, new[] { 57 }, new[] { 100 }, new[] { 38 }, new[] { 49 }, new[] { 92 }, new[] { 33 }, new[] { 73 }, new[] { 59 }, new[] { 69 }, new[] { 67 }, new[] { 66 }, new[] { 63 }, new[] { 53 }, new[] { 13 }, new[] { 64 }, new[] { 87 }, new[] { 18 }, new[] { 14 }, new[] { 2 }, new[] { 3 }, new[] { 77 }, new[] { 75 }, new[] { 96 }, new[] { 61 }, new[] { 19 }, new[] { 86 }, new[] { 20 }, new[] { 4 }, new[] { 17 }, new[] { 22 }, new[] { 21 }, new[] { 94 }, new[] { 52 }, new[] { 60 }, new[] { 51 }, new[] { 12 }, new[] { 43 }, new[] { 82 }, new[] { 56 }, new[] { 23 }, new[] { 98 }, new[] { 26 }, new[] { 50 }, new[] { 16 }, new[] { 85 }, new[] { 11 }, new[] { 83 }, new[] { 45 }, new[] { 84 }, new[] { 62 }, new[] { 1 }, new[] { 79 } }];

        yield return [new int?[] { 1, null, 11, 53, 28, 41, 60, 6, 24, 43, 55, 44, 42, 2, 20, 23, 15, 19, 37, 25, 12, 32, 59, 4, 10, 30, 7, 50, 14, 46, 22, 3, 56, 38, 26, 8, 27, 9, 48, 51, 36, 17, 34, 16, 47, 31, 35, 52, 57, 18, 45, 13, 54, 39, 33, 40, 21, 29, 5, 58, 49 }, new[] { new[] { 1 }, new[] { 11, 53, 28, 41, 60, 6, 24, 43, 55, 44, 42, 2, 20, 23, 15, 19, 37, 25, 12, 32, 59, 4, 10, 30, 7, 50, 14, 46, 22, 3, 56, 38, 26, 8, 27, 9, 48, 51, 36, 17, 34, 16, 47, 31, 35, 52, 57, 18, 45, 13, 54, 39, 33, 40, 21, 29, 5, 58, 49 } }];

        yield return [new int?[] { 124, null, 4, 136, 159, null, 184, 140, 162, null, 101, 48, 77, null, 178, 128, 46, null, 41, 150, null, 116, 82, null, 32, null, 151, 27, null, 63, 93, 97, null, 102, 36, 153, null, 95, 146, 90, null, 100, 60, 134, null, 190, 69, null, 156, 81, null, 179, 65, null, null, null, null, null, null, 43, 196, null, 167, 121, 148, null, 1, 14, null, 26, null, 137, null, null, 114, 55, 165, null, 50, 39, 34, null, 75, null, 130, 106, 20, null, 139, 174, null, 143, null, null, null, 163, 108, null, 45, 175, null, 133, 24, null, 135, null, 168, 157, 123, null, 166, 112, 172, null, 105, null, 85, null, null, 129, null, 42, 59, 17, null, 56, null, 176, 47, null, 86, 54, 187, null, 31, 154, null, 73, 152, 74, null, null, null, null, 91, 22, null, 110, 111, 144, null, 125, null, 58, 185, null, 13, null, 193, null, 120, 38, 3, null, 194, null, 192, null, 171, null, null, null, null, null, 126, 12, 118, null, 7, 64, 61, null, 44, 19, 76, null, 96, 30, 104, null, 28, 79, null, null, null, null, 49, null, 132, null, null, null, 158, 51, null, 181, null, null, 199, 122, 37, null, 9, null, null, 164, null, null, 83, null, 78, null, 88, 141, 161, null, null, null, 40, 188, null, 115, 6, 66, null, 57, null, null, null, null, null, null, null, null, null, null, 177, 109, null, null, 33, 155, null, null, null, 84, null, 169, null, null, 113, null, null, null, 8, 10, 71, null, null, null, 186, 11, null, 170, 87, null, 25, null, null, null, null, null, 16, 191, 119, null, 117, 70, null, 62, null, 98, null, null, 183, 103, null, null, 89, 53, null, 189, 131, 138, null, null, 200, 195, 160, null, null, 72, null, null, 2, 52, 147, null, null, null, null, null, 15, 182, null, 94, null, null, null, 21, 18, null, null, null, null, null, null, null, null, 197, 198, null, null, null, 68, null, null, null, null, null, 35, null, 80, null, 173, 99, null, 145, null, 149, 107, 67, null, null, 29, 92, null, null, null, null, 180, 23, 127, null, null, null, null, null, null, null, null, null, null, 142, null, null, null, null, null, null, null, null, null, null, null, 5 }, new[] { new[] { 124 }, new[] { 4, 136, 159 }, new[] { 184, 140, 162, 101, 48, 77, 178, 128, 46 }, new[] { 41, 150, 116, 82, 32, 151, 27, 63, 93, 97, 102, 36, 153, 95, 146, 90, 100, 60, 134, 190, 69 }, new[] { 156, 81, 179, 65, 43, 196, 167, 121, 148, 1, 14, 26, 137, 114, 55, 165, 50, 39, 34, 75, 130, 106, 20, 139, 174, 143 }, new[] { 163, 108, 45, 175, 133, 24, 135, 168, 157, 123, 166, 112, 172, 105, 85, 129, 42, 59, 17, 56, 176, 47, 86, 54, 187, 31, 154, 73, 152, 74, 91, 22, 110, 111, 144, 125, 58, 185, 13, 193, 120, 38, 3 }, new[] { 194, 192, 171, 126, 12, 118, 7, 64, 61, 44, 19, 76, 96, 30, 104, 28, 79, 49, 132, 158, 51, 181, 199, 122, 37, 9, 164, 83, 78, 88, 141, 161, 40, 188, 115, 6, 66, 57 }, new[] { 177, 109, 33, 155, 84, 169, 113, 8, 10, 71, 186, 11, 170, 87, 25, 16, 191, 119, 117, 70, 62, 98, 183, 103, 89, 53, 189, 131, 138, 200, 195, 160, 72, 2, 52, 147 }, new[] { 15, 182, 94, 21, 18, 197, 198, 68, 35, 80, 173, 99, 145, 149, 107, 67, 29, 92, 180, 23, 127 }, new[] { 142, 5 } }];

        yield return [new int?[] { 152, null, 150, 126, 70, 105, 210, 278, null, 245, 121, 241, 3, 10, 45, null, 110, 112, 138, null, 71, null, 279, 137, 52, 179, null, 48, 75, null, 128, null, 158, 225, 22, 263, 19, 198, null, 261, null, 142, 274, 117, null, 165, 84, 31, 269, 41, 195, null, 283, 44, 1, null, 188, 66, null, 211, 249, 208, 292, 30, 104, null, 226, 244, 63, 120, null, 164, 276, null, 180, 265, 115, null, null, 131, 255, 252, 218, null, null, null, 51, null, null, null, 233, 100, 33, 49, null, 212, 196, 186, 189, 119, 162, null, 272, null, 145, 178, 101, 17, null, 177, null, 207, 174, 191, null, 132, null, 146, 40, 260, 54, 107, 125, null, 219, 67, 262, 280, null, null, 133, 90, null, 91, 282, null, 259, 277, null, 155, null, 35, 288, 293, 122, null, null, null, null, 12, null, null, null, 257, 124, 264, null, 217, 147, 157, null, null, 232, 8, null, 14, null, null, 42, 202, null, 200, 285, null, null, null, 127, null, 72, null, null, 18, null, null, 286, null, 15, 235, null, 199, null, null, null, 187, 69, 32, 141, null, 136, 229, null, 5, null, null, 88, 192, 143, null, 297, 86, 300, 281, null, 82, null, 250, null, null, 50, null, 298, null, 140, null, 36, 173, null, null, null, 89, null, 79, 251, null, null, 81, null, null, null, 242, 87, null, 6, 58, null, null, 206, 53, null, 129, null, 209, 46, null, 26, 220, 83, 135, null, 29, 106, null, null, 73, 39, null, 114, null, 62, 148, 151, 258, 99, null, 102, null, null, 222, null, null, null, 290, 56, null, 238, 76, null, null, null, 118, null, 21, null, null, 221, 97, null, null, null, 43, 205, null, null, 160, null, 289, null, null, 267, 227, null, null, null, null, 266, null, 234, null, null, null, null, 149, 163, 34, 68, null, 113, 213, null, null, null, 172, null, null, null, 130, null, 123, 161, null, 92, 287, null, null, null, null, 299, 253, null, 168, 60, 236, null, null, null, 95, null, 216, 111, null, 159, 182, null, null, null, null, null, null, 153, 273, 181, 154, 268, null, null, null, null, 57, 224, null, null, null, null, 11, 176, 139, 61, null, 166, null, null, null, null, 20, null, null, 295, 275, null, 47, null, 228, null, 194, 109, null, null, null, null, 201, null, null, null, null, null, null, null, null, null, null, null, 256, null, null, null, null, null, null, 9, 271, null, 38, null, 185, null, 27, 103, 248, 171, null, 25, 203, null, null, 296, null, 254, 294, 59, null, 64, null, 108, null, null, null, 144, null, 223, 270, 167, null, null, null, 55, null, 197, null, null, null, 170, 74, 175, null, null, null, 93, null, 28, 184, 134, 156, null, null, null, null, null, null, null, 24, 4, 2, null, null, null, null, null, null, null, null, 247, null, null, 13, null, null, null, 231, 37, null, 240, null, null, null, null, null, 94, 16, null, null, 65, null, 183, 291, null, null, null, 23, 7, null, 230, null, null, null, null, null, null, null, 215, null, null, null, 193, 237, 98, 190, null, 239, null, null, null, null, null, null, null, 246, null, 77, 204, null, null, null, null, null, 284, null, null, 214, null, null, null, null, null, 169, null, null, null, 243, null, 96, null, null, null, null, null, null, null, 80, null, null, null, null, null, 85, 116, 78 }, new[] { new[] { 152 }, new[] { 150, 126, 70, 105, 210, 278 }, new[] { 245, 121, 241, 3, 10, 45, 110, 112, 138, 71, 279, 137, 52, 179, 48, 75, 128 }, new[] { 158, 225, 22, 263, 19, 198, 261, 142, 274, 117, 165, 84, 31, 269, 41, 195, 283, 44, 1, 188, 66, 211, 249, 208, 292, 30, 104, 226, 244, 63, 120, 164, 276, 180, 265, 115, 131, 255, 252, 218, 51 }, new[] { 233, 100, 33, 49, 212, 196, 186, 189, 119, 162, 272, 145, 178, 101, 17, 177, 207, 174, 191, 132, 146, 40, 260, 54, 107, 125, 219, 67, 262, 280, 133, 90, 91, 282, 259, 277, 155, 35, 288, 293, 122, 12, 257, 124, 264, 217, 147, 157, 232, 8, 14, 42, 202, 200, 285, 127, 72, 18, 286, 15, 235, 199 }, new[] { 187, 69, 32, 141, 136, 229, 5, 88, 192, 143, 297, 86, 300, 281, 82, 250, 50, 298, 140, 36, 173, 89, 79, 251, 81, 242, 87, 6, 58, 206, 53, 129, 209, 46, 26, 220, 83, 135, 29, 106, 73, 39, 114, 62, 148, 151, 258, 99, 102, 222, 290, 56, 238, 76, 118, 21, 221, 97, 43, 205, 160, 289, 267, 227, 266, 234 }, new[] { 149, 163, 34, 68, 113, 213, 172, 130, 123, 161, 92, 287, 299, 253, 168, 60, 236, 95, 216, 111, 159, 182, 153, 273, 181, 154, 268, 57, 224, 11, 176, 139, 61, 166, 20, 295, 275, 47, 228, 194, 109, 201, 256, 9, 271, 38 }, new[] { 185, 27, 103, 248, 171, 25, 203, 296, 254, 294, 59, 64, 108, 144, 223, 270, 167, 55, 197, 170, 74, 175, 93, 28, 184, 134, 156, 24, 4, 2, 247, 13, 231, 37, 240 }, new[] { 94, 16, 65, 183, 291, 23, 7, 230, 215, 193, 237, 98, 190, 239, 246, 77, 204, 284 }, new[] { 214, 169, 243, 96, 80 }, new[] { 85, 116, 78 } }];

        yield return [new int?[] { 8, null, 1, 5, null, 7, 2, null, 6, null, 3, null, null, null, 4 }, new[] { new[] { 8 }, new[] { 1, 5 }, new[] { 7, 2, 6 }, new[] { 3 }, new[] { 4 } }];
    }
}