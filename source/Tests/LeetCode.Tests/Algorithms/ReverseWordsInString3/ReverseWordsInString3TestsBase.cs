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

using LeetCode.Algorithms.ReverseWordsInString3;

namespace LeetCode.Tests.Algorithms.ReverseWordsInString3;

public abstract class ReverseWordsInString3TestsBase<T> where T : IReverseWordsInString3, new()
{
    [TestMethod]
    [DataRow("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
    [DataRow("Mr Ding", "rM gniD")]
    [DataRow("a", "a")]
    [DataRow("ab", "ba")]
    [DataRow("abc", "cba")]
    [DataRow("a b", "a b")]
    [DataRow("ab cd", "ba dc")]
    [DataRow("abc def ghi", "cba fed ihg")]
    [DataRow("racecar level", "racecar level")]
    [DataRow("Hello", "olleH")]
    [DataRow("Hello, World!", ",olleH !dlroW")]
    [DataRow("a1 b2 c3", "1a 2b 3c")]
    [DataRow("x y z w", "x y z w")]
    [DataRow("12345 67890", "54321 09876")]
    [DataRow("The quick brown fox", "ehT kciuq nworb xof")]
    [DataRow("!@# $%^ &*()", "#@! ^%$ )(*&")]
    [DataRow("madam im adam", "madam mi mada")]
    [DataRow("pyddd hxzcf xzcrb xoaxh cqohb tadsk kxtjw dufup skdrj cdpty", "dddyp fczxh brczx hxaox bhoqc ksdat wjtxk pufud jrdks ytpdc")]
    [DataRow("trewa nlj q eydgyl onu jgrtwnym d q ozvtuv xycyp amq m cjesgp wd x auq gjoup sx ksb ularn ktdh lhk ho jtru zpvslf fuilm qioo fsp gizgdxym rc", "awert jln q lygdye uno mynwtrgj d q vutvzo pycyx qma m pgsejc dw x qua puojg xs bsk nralu hdtk khl oh urtj flsvpz mliuf ooiq psf myxdgzig cr")]
    [DataRow("ehqtzqinktnzjyvmulwfepuefxqmavixghfkrorkgzbdqalpgsuaaxpgaukrbbgkzapxqtrwllyhuechmdubfqayivtxoumdkqwa", "awqkdmuoxtviyaqfbudmhceuhyllwrtqxpazkgbbrkuagpxaausgplaqdbzgkrorkfhgxivamqxfeupefwlumvyjzntkniqztqhe")]
    public void ReverseWords_WithString_ReversesEachWord(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReverseWords(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}