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

using LeetCode.Algorithms.PartitionLabels;

namespace LeetCode.Tests.Algorithms.PartitionLabels;

public abstract class PartitionLabelsTestsBase<T> where T : IPartitionLabels, new()
{
    [TestMethod]
    [DataRow("ababcbacadefegdehijhklij", new[] { 9, 7, 8 })]
    [DataRow("eccbbbbdec", new[] { 10 })]
    [DataRow("a", new[] { 1 })]
    [DataRow("z", new[] { 1 })]
    [DataRow("aa", new[] { 2 })]
    [DataRow("ab", new[] { 1, 1 })]
    [DataRow("aba", new[] { 3 })]
    [DataRow("abc", new[] { 1, 1, 1 })]
    [DataRow("abab", new[] { 4 })]
    [DataRow("aabbcc", new[] { 2, 2, 2 })]
    [DataRow("abcabc", new[] { 6 })]
    [DataRow("abcdef", new[] { 1, 1, 1, 1, 1, 1 })]
    [DataRow("zzzaaa", new[] { 3, 3 })]
    [DataRow("qwertyqwerty", new[] { 12 })]
    [DataRow("ababcbaca", new[] { 9 })]
    [DataRow("caedbdedda", new[] { 1, 9 })]
    [DataRow("abcdefghijklmnopqrstuvwxyz", new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 })]
    [DataRow("zyxwvutsrqponmlkjihgfedcbaa", new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2 })]
    [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", new[] { 50 })]
    [DataRow("cfaacdeechfagcceaaegacdhbeagaafeagfbcdfcgacegbafaaghhefceegh", new[] { 60 })]
    [DataRow("hbkarnxdruabyzpxvosjsisycbxbpbjnsjmyjswvjtruyphwhcskzihixplqjicvujpfvdmounsaqethexewymzbblszkfagjiwvocupziqqthakhxkhzyrbsmavjwrkryzlydwtdqwyjvidlaeitalrphnvjmlwddihvbiuawysyeupysrammdsjqhrbruqxroqejhsjdqpggczgsfinbqrgskhexmustkdbokjszicfetxvmpdandhbpskxvrlwsfebokyjgvrhcsffpeihixumxdrtayyxrzueydigmzluecuvxhmyewwhbjreujmwjtwldzijsfkvaopuwlxuayxlfsyjvdqbiivzywypaxvvibveuoqhnlwjycyztcdwwzlgljkevfiumbpkspcnzbdpgqouraackrfjhwqnqtcdmmbouqgcnjgiyagwghuxffkbujawpexvxqibviuckvvgyyoaldffuxfyyzofrfzxtkpscyc", new[] { 500 })]
    public void PartitionLabels_GivenString_ReturnsPartitionSizesWhereEachLetterAppearsOnce(string s, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var partitionSizes = solution.PartitionLabels(s);
        var actualResult = new int[partitionSizes.Count];

        partitionSizes.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}