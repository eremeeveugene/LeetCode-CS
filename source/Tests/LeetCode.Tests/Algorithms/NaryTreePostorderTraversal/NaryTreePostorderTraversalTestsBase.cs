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

using LeetCode.Algorithms.NaryTreePostorderTraversal;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.NaryTreePostorderTraversal;

public abstract class NaryTreePostorderTraversalTestsBase<T> where T : INaryTreePostorderTraversal, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Postorder_WithNaryTree_ReturnsPostorderTraversalOfNodes(int?[] rootArray, int[] expectedResult)
    {
        // Arrange
        var root = Node.ToNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.Postorder(root);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int>()];

        yield return [new int?[] { 1, null, 3, 2, 4, null, 5, 6 }, new[] { 5, 6, 3, 2, 4, 1 }];

        yield return
        [
            new int?[] { 1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null, null, 14 },
            new[] { 2, 6, 14, 11, 7, 3, 12, 8, 4, 13, 9, 10, 5, 1 }
        ];

        yield return [new int?[] { 1 }, new[] { 1 }];

        yield return [new int?[] { 1, null, 2 }, new[] { 2, 1 }];

        yield return [new int?[] { 3, null, 1, null, 2 }, new[] { 2, 1, 3 }];

        yield return [new int?[] { 2, null, 3, 1 }, new[] { 3, 1, 2 }];

        yield return [new int?[] { 2, null, 4, null, 5, null, 1, null, 3 }, new[] { 3, 1, 5, 4, 2 }];

        yield return [new int?[] { 3, null, 5, 2, 4, 6, 1 }, new[] { 5, 2, 4, 6, 1, 3 }];

        yield return [new int?[] { 7, null, 3, 6, 1, null, 2, null, 4, null, null, null, 5 }, new[] { 2, 3, 5, 4, 6, 1, 7 }];

        yield return [new int?[] { 6, null, 5, 7, 8, null, 2, 1, null, 9, 4, null, null, 3 }, new[] { 3, 2, 1, 5, 9, 4, 7, 8, 6 }];

        yield return [new int?[] { 9, null, 3, null, 2, 7, 5, 6, null, null, 1, null, 10, null, 8, null, null, null, 4 }, new[] { 2, 1, 7, 10, 5, 4, 8, 6, 3, 9 }];

        yield return [new int?[] { 3, null, 2, 10, 1, null, 7, 4, null, 12, 5, null, 11, 6, 8, null, null, null, null, null, null, 9 }, new[] { 7, 4, 2, 12, 5, 10, 11, 9, 6, 8, 1, 3 }];

        yield return [new int?[] { 4, null, 14, 6, 10, null, 3, 15, null, null, null, 9, 7, 11, null, null, 1, 12, 8, null, 5, null, 2, null, null, 13 }, new[] { 1, 13, 12, 8, 9, 5, 7, 2, 11, 3, 15, 14, 6, 10, 4 }];

        yield return [new int?[] { 1, null, 9, 11, 4, 3, null, 6, 20, 12, 19, null, 7, 16, null, null, null, 14, null, 15, 17, 13, null, null, 2, null, null, 18, null, 8, null, null, null, null, 10, null, null, 5 }, new[] { 5, 8, 14, 6, 15, 17, 13, 20, 12, 10, 2, 19, 9, 7, 18, 16, 11, 4, 3, 1 }];

        yield return [new int?[] { 3, null, 22, 10, 6, 9, null, 12, 1, null, 4, 24, null, 14, 2, 25, null, 8, null, 16, 7, null, null, null, null, 23, 20, null, null, null, 13, null, 21, null, 5, null, 18, null, null, null, 15, 17, 11, 19 }, new[] { 15, 17, 11, 19, 21, 16, 5, 7, 12, 1, 22, 4, 24, 10, 18, 23, 20, 14, 2, 25, 6, 13, 8, 9, 3 }];

        yield return [new int?[] { 15, null, 13, 28, 2, 23, null, 8, 19, 30, null, 17, null, null, 24, null, 22, 18, 16, null, 10, 14, 25, null, 26, null, null, null, 20, 6, 9, null, 21, null, null, 11, 4, null, 29, 12, 7, 1, null, null, null, null, null, null, null, null, null, 27, 5, null, null, null, 3 }, new[] { 20, 6, 9, 22, 21, 18, 16, 8, 11, 4, 10, 27, 5, 29, 12, 7, 3, 1, 14, 25, 19, 26, 30, 13, 17, 28, 2, 24, 23, 15 }];

        yield return [new int?[] { 74, null, 24, null, 68, null, 97, null, 8, null, 7, null, 81, null, 44, null, 36, null, 91, null, 28, null, 42, null, 55, null, 15, null, 89, null, 78, null, 80, null, 37, null, 65, null, 71, null, 32, null, 72, null, 40, null, 93, null, 5, null, 90, null, 31, null, 99, null, 70, null, 6, null, 25, null, 29, null, 58, null, 39, null, 41, null, 10, null, 48, null, 46, null, 54, null, 47, null, 34, null, 95, null, 30, null, 88, null, 76, null, 9, null, 27, null, 35, null, 57, null, 100, null, 38, null, 49, null, 92, null, 33, null, 73, null, 59, null, 69, null, 67, null, 66, null, 63, null, 53, null, 13, null, 64, null, 87, null, 18, null, 14, null, 2, null, 3, null, 77, null, 75, null, 96, null, 61, null, 19, null, 86, null, 20, null, 4, null, 17, null, 22, null, 21, null, 94, null, 52, null, 60, null, 51, null, 12, null, 43, null, 82, null, 56, null, 23, null, 98, null, 26, null, 50, null, 16, null, 85, null, 11, null, 83, null, 45, null, 84, null, 62, null, 1, null, 79 }, new[] { 79, 1, 62, 84, 45, 83, 11, 85, 16, 50, 26, 98, 23, 56, 82, 43, 12, 51, 60, 52, 94, 21, 22, 17, 4, 20, 86, 19, 61, 96, 75, 77, 3, 2, 14, 18, 87, 64, 13, 53, 63, 66, 67, 69, 59, 73, 33, 92, 49, 38, 100, 57, 35, 27, 9, 76, 88, 30, 95, 34, 47, 54, 46, 48, 10, 41, 39, 58, 29, 25, 6, 70, 99, 31, 90, 5, 93, 40, 72, 32, 71, 65, 37, 80, 78, 89, 15, 55, 42, 28, 91, 36, 44, 81, 7, 8, 97, 68, 24, 74 }];

        yield return [new int?[] { 1, null, 11, 53, 28, 41, 60, 6, 24, 43, 55, 44, 42, 2, 20, 23, 15, 19, 37, 25, 12, 32, 59, 4, 10, 30, 7, 50, 14, 46, 22, 3, 56, 38, 26, 8, 27, 9, 48, 51, 36, 17, 34, 16, 47, 31, 35, 52, 57, 18, 45, 13, 54, 39, 33, 40, 21, 29, 5, 58, 49 }, new[] { 11, 53, 28, 41, 60, 6, 24, 43, 55, 44, 42, 2, 20, 23, 15, 19, 37, 25, 12, 32, 59, 4, 10, 30, 7, 50, 14, 46, 22, 3, 56, 38, 26, 8, 27, 9, 48, 51, 36, 17, 34, 16, 47, 31, 35, 52, 57, 18, 45, 13, 54, 39, 33, 40, 21, 29, 5, 58, 49, 1 }];

        yield return [new int?[] { 124, null, 4, 136, 159, null, 184, 140, 162, null, 101, 48, 77, null, 178, 128, 46, null, 41, 150, null, 116, 82, null, 32, null, 151, 27, null, 63, 93, 97, null, 102, 36, 153, null, 95, 146, 90, null, 100, 60, 134, null, 190, 69, null, 156, 81, null, 179, 65, null, null, null, null, null, null, 43, 196, null, 167, 121, 148, null, 1, 14, null, 26, null, 137, null, null, 114, 55, 165, null, 50, 39, 34, null, 75, null, 130, 106, 20, null, 139, 174, null, 143, null, null, null, 163, 108, null, 45, 175, null, 133, 24, null, 135, null, 168, 157, 123, null, 166, 112, 172, null, 105, null, 85, null, null, 129, null, 42, 59, 17, null, 56, null, 176, 47, null, 86, 54, 187, null, 31, 154, null, 73, 152, 74, null, null, null, null, 91, 22, null, 110, 111, 144, null, 125, null, 58, 185, null, 13, null, 193, null, 120, 38, 3, null, 194, null, 192, null, 171, null, null, null, null, null, 126, 12, 118, null, 7, 64, 61, null, 44, 19, 76, null, 96, 30, 104, null, 28, 79, null, null, null, null, 49, null, 132, null, null, null, 158, 51, null, 181, null, null, 199, 122, 37, null, 9, null, null, 164, null, null, 83, null, 78, null, 88, 141, 161, null, null, null, 40, 188, null, 115, 6, 66, null, 57, null, null, null, null, null, null, null, null, null, null, 177, 109, null, null, 33, 155, null, null, null, 84, null, 169, null, null, 113, null, null, null, 8, 10, 71, null, null, null, 186, 11, null, 170, 87, null, 25, null, null, null, null, null, 16, 191, 119, null, 117, 70, null, 62, null, 98, null, null, 183, 103, null, null, 89, 53, null, 189, 131, 138, null, null, 200, 195, 160, null, null, 72, null, null, 2, 52, 147, null, null, null, null, null, 15, 182, null, 94, null, null, null, 21, 18, null, null, null, null, null, null, null, null, 197, 198, null, null, null, 68, null, null, null, null, null, 35, null, 80, null, 173, 99, null, 145, null, 149, 107, 67, null, null, 29, 92, null, null, null, null, 180, 23, 127, null, null, null, null, null, null, null, null, null, null, 142, null, null, null, null, null, null, null, null, null, null, null, 5 }, new[] { 194, 163, 177, 109, 192, 108, 156, 171, 45, 175, 81, 41, 133, 24, 179, 135, 65, 150, 184, 116, 82, 140, 32, 162, 4, 151, 27, 101, 33, 15, 182, 155, 126, 12, 118, 168, 94, 84, 7, 169, 64, 61, 157, 113, 44, 19, 76, 123, 43, 21, 18, 8, 10, 71, 96, 30, 104, 166, 186, 11, 28, 170, 87, 79, 112, 172, 196, 63, 105, 167, 85, 121, 148, 93, 25, 49, 129, 1, 132, 42, 59, 17, 14, 97, 48, 158, 51, 56, 26, 102, 181, 176, 47, 137, 36, 153, 77, 136, 197, 198, 16, 191, 119, 199, 142, 68, 117, 70, 122, 62, 37, 86, 98, 9, 54, 187, 114, 164, 31, 154, 55, 183, 35, 103, 83, 73, 78, 152, 80, 89, 173, 99, 53, 88, 145, 189, 149, 107, 67, 131, 138, 141, 161, 74, 165, 95, 50, 39, 34, 146, 91, 22, 75, 90, 178, 29, 92, 200, 195, 160, 40, 188, 110, 72, 115, 6, 5, 180, 23, 127, 2, 52, 147, 66, 111, 57, 144, 130, 125, 106, 58, 185, 20, 100, 13, 139, 193, 174, 60, 120, 38, 3, 143, 134, 128, 190, 69, 46, 159, 124 }];

        yield return [new int?[] { 152, null, 150, 126, 70, 105, 210, 278, null, 245, 121, 241, 3, 10, 45, null, 110, 112, 138, null, 71, null, 279, 137, 52, 179, null, 48, 75, null, 128, null, 158, 225, 22, 263, 19, 198, null, 261, null, 142, 274, 117, null, 165, 84, 31, 269, 41, 195, null, 283, 44, 1, null, 188, 66, null, 211, 249, 208, 292, 30, 104, null, 226, 244, 63, 120, null, 164, 276, null, 180, 265, 115, null, null, 131, 255, 252, 218, null, null, null, 51, null, null, null, 233, 100, 33, 49, null, 212, 196, 186, 189, 119, 162, null, 272, null, 145, 178, 101, 17, null, 177, null, 207, 174, 191, null, 132, null, 146, 40, 260, 54, 107, 125, null, 219, 67, 262, 280, null, null, 133, 90, null, 91, 282, null, 259, 277, null, 155, null, 35, 288, 293, 122, null, null, null, null, 12, null, null, null, 257, 124, 264, null, 217, 147, 157, null, null, 232, 8, null, 14, null, null, 42, 202, null, 200, 285, null, null, null, 127, null, 72, null, null, 18, null, null, 286, null, 15, 235, null, 199, null, null, null, 187, 69, 32, 141, null, 136, 229, null, 5, null, null, 88, 192, 143, null, 297, 86, 300, 281, null, 82, null, 250, null, null, 50, null, 298, null, 140, null, 36, 173, null, null, null, 89, null, 79, 251, null, null, 81, null, null, null, 242, 87, null, 6, 58, null, null, 206, 53, null, 129, null, 209, 46, null, 26, 220, 83, 135, null, 29, 106, null, null, 73, 39, null, 114, null, 62, 148, 151, 258, 99, null, 102, null, null, 222, null, null, null, 290, 56, null, 238, 76, null, null, null, 118, null, 21, null, null, 221, 97, null, null, null, 43, 205, null, null, 160, null, 289, null, null, 267, 227, null, null, null, null, 266, null, 234, null, null, null, null, 149, 163, 34, 68, null, 113, 213, null, null, null, 172, null, null, null, 130, null, 123, 161, null, 92, 287, null, null, null, null, 299, 253, null, 168, 60, 236, null, null, null, 95, null, 216, 111, null, 159, 182, null, null, null, null, null, null, 153, 273, 181, 154, 268, null, null, null, null, 57, 224, null, null, null, null, 11, 176, 139, 61, null, 166, null, null, null, null, 20, null, null, 295, 275, null, 47, null, 228, null, 194, 109, null, null, null, null, 201, null, null, null, null, null, null, null, null, null, null, null, 256, null, null, null, null, null, null, 9, 271, null, 38, null, 185, null, 27, 103, 248, 171, null, 25, 203, null, null, 296, null, 254, 294, 59, null, 64, null, 108, null, null, null, 144, null, 223, 270, 167, null, null, null, 55, null, 197, null, null, null, 170, 74, 175, null, null, null, 93, null, 28, 184, 134, 156, null, null, null, null, null, null, null, 24, 4, 2, null, null, null, null, null, null, null, null, 247, null, null, 13, null, null, null, 231, 37, null, 240, null, null, null, null, null, 94, 16, null, null, 65, null, 183, 291, null, null, null, 23, 7, null, 230, null, null, null, null, null, null, null, 215, null, null, null, 193, 237, 98, 190, null, 239, null, null, null, null, null, null, null, 246, null, 77, 204, null, null, null, null, null, 284, null, null, 214, null, null, null, null, null, 169, null, null, null, 243, null, 96, null, null, null, null, null, null, null, 80, null, null, null, null, null, 85, 116, 78 }, new[] { 185, 149, 27, 214, 94, 16, 103, 248, 65, 171, 163, 183, 291, 25, 203, 34, 68, 187, 296, 113, 169, 23, 7, 254, 230, 294, 59, 213, 69, 32, 141, 233, 64, 172, 136, 229, 100, 5, 33, 49, 158, 108, 130, 88, 123, 161, 192, 144, 92, 223, 270, 243, 215, 167, 287, 143, 212, 297, 86, 300, 299, 253, 281, 196, 55, 168, 197, 60, 236, 82, 186, 250, 189, 119, 50, 162, 225, 95, 298, 272, 22, 85, 116, 78, 96, 193, 237, 98, 190, 170, 239, 74, 175, 216, 111, 140, 145, 159, 93, 182, 36, 173, 178, 101, 17, 263, 89, 177, 19, 79, 251, 207, 174, 81, 191, 198, 245, 132, 261, 121, 146, 28, 184, 134, 156, 153, 273, 181, 154, 268, 242, 87, 40, 6, 58, 260, 54, 57, 224, 206, 53, 107, 129, 125, 142, 209, 246, 24, 77, 80, 204, 4, 2, 11, 176, 139, 61, 46, 219, 166, 26, 220, 83, 135, 67, 20, 29, 106, 262, 280, 274, 117, 241, 295, 275, 73, 247, 47, 39, 133, 228, 114, 90, 165, 13, 194, 109, 62, 148, 151, 258, 201, 99, 91, 102, 282, 84, 259, 222, 277, 31, 155, 269, 35, 290, 56, 288, 238, 76, 293, 122, 41, 195, 3, 283, 44, 12, 1, 10, 188, 66, 45, 150, 118, 257, 21, 124, 264, 211, 221, 97, 217, 147, 157, 249, 208, 231, 284, 37, 256, 43, 205, 232, 8, 292, 160, 14, 30, 104, 110, 289, 42, 202, 226, 267, 227, 200, 285, 244, 63, 120, 112, 127, 164, 72, 276, 138, 126, 180, 240, 9, 271, 266, 18, 265, 115, 71, 70, 279, 38, 234, 286, 131, 15, 235, 255, 199, 252, 218, 137, 52, 179, 105, 51, 48, 75, 210, 128, 278, 152 }];

        yield return [new int?[] { 8, null, 1, 5, null, 7, 2, null, 6, null, 3, null, null, null, 4 }, new[] { 4, 3, 7, 2, 1, 6, 5, 8 }];
    }
}