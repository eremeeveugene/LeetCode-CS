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

using LeetCode.Algorithms.ShuffleString;

namespace LeetCode.Tests.Algorithms.ShuffleString;

public abstract class ShuffleStringTestsBase<T> where T : IShuffleString, new()
{
    [TestMethod]
    [DataRow("codeleet", new[] { 4, 5, 6, 7, 0, 2, 1, 3 }, "leetcode")]
    [DataRow("abc", new[] { 0, 1, 2 }, "abc")]
    [DataRow("a", new[] { 0 }, "a")]
    [DataRow("ab", new[] { 1, 0 }, "ba")]
    [DataRow("ab", new[] { 0, 1 }, "ab")]
    [DataRow("abc", new[] { 2, 1, 0 }, "cba")]
    [DataRow("abc", new[] { 1, 2, 0 }, "cab")]
    [DataRow("abc", new[] { 2, 0, 1 }, "bca")]
    [DataRow("aaa", new[] { 2, 0, 1 }, "aaa")]
    [DataRow("art", new[] { 1, 0, 2 }, "rat")]
    [DataRow("abcde", new[] { 4, 3, 2, 1, 0 }, "edcba")]
    [DataRow("hello", new[] { 0, 1, 2, 3, 4 }, "hello")]
    [DataRow("zyxw", new[] { 3, 2, 1, 0 }, "wxyz")]
    [DataRow("leetcode", new[] { 7, 6, 5, 4, 3, 2, 1, 0 }, "edocteel")]
    [DataRow("izpjefgnfc", new[] { 5, 6, 0, 8, 7, 3, 1, 9, 2, 4 }, "pgffcizejn")]
    [DataRow("qlmzrmwdzmaszmlgrsbwxfenzk", new[] { 24, 18, 22, 4, 6, 23, 25, 13, 21, 8, 16, 3, 10, 2, 14, 19, 11, 15, 12, 9, 5, 0, 7, 20, 1, 17 }, "fzmszxremwzrbdlsaklgnzmmqw")]
    [DataRow("ihrcprhbqcblhlwktykmatnnqtwsaohzymshvuwpbjjhgjufwq", new[] { 7, 16, 36, 35, 33, 45, 42, 20, 4, 38, 2, 23, 1, 24, 8, 44, 40, 31, 10, 3, 29, 11, 49, 22, 39, 47, 12, 37, 34, 32, 5, 48, 21, 30, 18, 14, 46, 25, 9, 26, 6, 41, 28, 15, 43, 19, 17, 13, 27, 0 }, "qhbmqhbiwwktwfhhhusjbynllupwjamyopacrscqtjhgkrvtzn")]
    [DataRow("ozhxqqjckivootxvizrbfcniobrwqsunvqngzqjyfhicsnexxoxupksgavcrqtajwuazcvoivxj", new[] { 41, 50, 44, 3, 4, 18, 25, 62, 13, 22, 11, 59, 56, 55, 28, 73, 34, 70, 38, 20, 24, 39, 29, 54, 31, 66, 52, 46, 53, 68, 43, 57, 67, 8, 1, 61, 74, 72, 32, 16, 37, 35, 71, 9, 7, 51, 60, 6, 45, 27, 58, 49, 64, 65, 40, 42, 33, 23, 36, 15, 63, 47, 12, 10, 2, 19, 48, 14, 26, 21, 30, 17, 5, 0, 69 }, "xnwxqvxsqcjvakzryiqubvivfjcoxnoojaihcfrcsoguhxwtauznrqitonxoegcqpkbvsjziqvz")]
    [DataRow("sjuvpavripufbdgugvefmtkhmakegpysepyaonukwsancsiwcpczeucpdmamqevgxsvuswubjkgmihkcbldrzlyobtmiespjpurp", new[] { 73, 90, 6, 56, 91, 83, 93, 94, 97, 86, 39, 77, 85, 96, 30, 4, 65, 48, 54, 19, 15, 23, 22, 67, 11, 51, 37, 18, 32, 55, 33, 82, 57, 20, 63, 45, 84, 95, 46, 74, 50, 14, 59, 9, 60, 42, 10, 16, 13, 79, 99, 31, 1, 7, 17, 52, 81, 58, 98, 12, 21, 40, 80, 68, 87, 35, 34, 2, 62, 26, 5, 88, 0, 38, 47, 75, 76, 64, 72, 43, 3, 92, 66, 49, 61, 28, 44, 71, 36, 78, 70, 8, 53, 41, 27, 25, 89, 24, 69, 29 }, "jeubuuuuinimmcsmwcefpqktujwplpgzgyvsbkkuesscyaugvrwapeepvemaczsyhgdhgrmokskmiftpvdsaobpxbpjplvrndiac")]
    [DataRow("ydtjzaanedyjjlbwqvlwdqbavsisovsxkkjosljpcvsgytumwwubdkieiopcmpjdbuxrlngoibrpqzudcdjlsdjvizdpfmtnduwx", new[] { 33, 40, 39, 16, 2, 86, 73, 83, 29, 47, 78, 96, 7, 35, 24, 10, 79, 64, 38, 82, 72, 55, 0, 30, 4, 76, 5, 93, 45, 54, 37, 92, 11, 61, 88, 49, 22, 3, 59, 27, 71, 25, 13, 74, 98, 21, 9, 90, 77, 69, 42, 44, 31, 84, 51, 50, 18, 8, 62, 52, 56, 81, 46, 95, 12, 53, 34, 65, 89, 94, 99, 20, 60, 26, 80, 97, 36, 58, 1, 70, 43, 68, 41, 75, 23, 15, 14, 91, 66, 32, 67, 85, 6, 48, 57, 17, 63, 28, 87, 19 }, "buzlvifjouwkbsjdjnixotssbvbpueadzyxlqsltdjucbojdmoeicuvqmtzjikpdvriddwdcdaglswyqrpwnkpawjlmvxsndjpyg")]
    public void RestoreString_WhenGivenStringAndIndicesArray_RearrangesToExpectedString(string s, int[] indices, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RestoreString(s, indices);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}