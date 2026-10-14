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

using LeetCode.Algorithms.PascalsTriangle2;

namespace LeetCode.Tests.Algorithms.PascalsTriangle2;

public abstract class PascalsTriangle2TestsBase<T> where T : IPascalsTriangle2, new()
{
    [TestMethod]
    [DataRow(0, new[] { 1 })]
    [DataRow(1, new[] { 1, 1 })]
    [DataRow(3, new[] { 1, 3, 3, 1 })]
    [DataRow(2, new[] { 1, 2, 1 })]
    [DataRow(4, new[] { 1, 4, 6, 4, 1 })]
    [DataRow(5, new[] { 1, 5, 10, 10, 5, 1 })]
    [DataRow(6, new[] { 1, 6, 15, 20, 15, 6, 1 })]
    [DataRow(7, new[] { 1, 7, 21, 35, 35, 21, 7, 1 })]
    [DataRow(8, new[] { 1, 8, 28, 56, 70, 56, 28, 8, 1 })]
    [DataRow(9, new[] { 1, 9, 36, 84, 126, 126, 84, 36, 9, 1 })]
    [DataRow(10, new[] { 1, 10, 45, 120, 210, 252, 210, 120, 45, 10, 1 })]
    [DataRow(12, new[] { 1, 12, 66, 220, 495, 792, 924, 792, 495, 220, 66, 12, 1 })]
    [DataRow(15, new[] { 1, 15, 105, 455, 1365, 3003, 5005, 6435, 6435, 5005, 3003, 1365, 455, 105, 15, 1 })]
    [DataRow(16, new[] { 1, 16, 120, 560, 1820, 4368, 8008, 11440, 12870, 11440, 8008, 4368, 1820, 560, 120, 16, 1 })]
    [DataRow(20, new[] { 1, 20, 190, 1140, 4845, 15504, 38760, 77520, 125970, 167960, 184756, 167960, 125970, 77520, 38760, 15504, 4845, 1140, 190, 20, 1 })]
    [DataRow(25, new[] { 1, 25, 300, 2300, 12650, 53130, 177100, 480700, 1081575, 2042975, 3268760, 4457400, 5200300, 5200300, 4457400, 3268760, 2042975, 1081575, 480700, 177100, 53130, 12650, 2300, 300, 25, 1 })]
    [DataRow(30, new[] { 1, 30, 435, 4060, 27405, 142506, 593775, 2035800, 5852925, 14307150, 30045015, 54627300, 86493225, 119759850, 145422675, 155117520, 145422675, 119759850, 86493225, 54627300, 30045015, 14307150, 5852925, 2035800, 593775, 142506, 27405, 4060, 435, 30, 1 })]
    [DataRow(31, new[] { 1, 31, 465, 4495, 31465, 169911, 736281, 2629575, 7888725, 20160075, 44352165, 84672315, 141120525, 206253075, 265182525, 300540195, 300540195, 265182525, 206253075, 141120525, 84672315, 44352165, 20160075, 7888725, 2629575, 736281, 169911, 31465, 4495, 465, 31, 1 })]
    [DataRow(32, new[] { 1, 32, 496, 4960, 35960, 201376, 906192, 3365856, 10518300, 28048800, 64512240, 129024480, 225792840, 347373600, 471435600, 565722720, 601080390, 565722720, 471435600, 347373600, 225792840, 129024480, 64512240, 28048800, 10518300, 3365856, 906192, 201376, 35960, 4960, 496, 32, 1 })]
    [DataRow(33, new[] { 1, 33, 528, 5456, 40920, 237336, 1107568, 4272048, 13884156, 38567100, 92561040, 193536720, 354817320, 573166440, 818809200, 1037158320, 1166803110, 1166803110, 1037158320, 818809200, 573166440, 354817320, 193536720, 92561040, 38567100, 13884156, 4272048, 1107568, 237336, 40920, 5456, 528, 33, 1 })]
    public void GetRow_GivenRowIndex_ReturnsPascalsTriangleRow(int rowIndex, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var row = solution.GetRow(rowIndex);
        var actualResult = new int[row.Count];

        row.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}