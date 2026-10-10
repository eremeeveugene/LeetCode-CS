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

using LeetCode.Algorithms.ReverseString2;

namespace LeetCode.Tests.Algorithms.ReverseString2;

public abstract class ReverseString2TestsBase<T> where T : IReverseString2, new()
{
    [TestMethod]
    [DataRow("abcdefg", 2, "bacdfeg")]
    [DataRow("abcd", 2, "bacd")]
    [DataRow("a", 1, "a")]
    [DataRow("a", 5, "a")]
    [DataRow("ab", 1, "ab")]
    [DataRow("ab", 2, "ba")]
    [DataRow("ab", 3, "ba")]
    [DataRow("abc", 1, "abc")]
    [DataRow("abc", 2, "bac")]
    [DataRow("abc", 3, "cba")]
    [DataRow("abcdef", 3, "cbadef")]
    [DataRow("abcdefg", 8, "gfedcba")]
    [DataRow("abcdefgh", 4, "dcbaefgh")]
    [DataRow("abcdefghi", 3, "cbadefihg")]
    [DataRow("abcdefghij", 1, "abcdefghij")]
    [DataRow("abcdefghijkl", 2, "bacdfeghjikl")]
    [DataRow("hello world", 4, "lleho wodlr")]
    [DataRow("kapatomlgomvsohbahmguhxpkohjmn", 5, "tapakomlgohosvmbahmgkpxhuohjmn")]
    [DataRow("fbefnbjtqlvbvgswcztbmrncowtwlbrcluoneksprmnigakvhumyrvyyljiqvhncfvqllmiypuncgmzcyzottlvvhwzpcibtwuvi", 7, "jbnfebftqlvbvgmbtzcwsrncowtwoulcrblneksprmhvkaginumyrvyynhvqijlcfvqllmgcnupyimzcyzotzwhvvltpcibtwuiv")]
    [DataRow("izhnllngppptdoaucrlgrifvgadavqwhnaxggbnrxomqkfxgegyhjvmzqapggovmzxsnxleecpzwdvthqgekzlszizbwapsagygwypsicjyjqwfdgtawlieamuswdxxruqrslevouhjawobhkcewjuftkhkokldtrdodstbrcymcgznftkqkxvncusqyezritqfxnmuouncobqjdwawfpuilondbjhjbeimswphqvmrbsmtjtlamslyhbbowmbjjxqpqlcoqoryhrhiqhkvmlesfcyoydkforxrfculrlhpzokyaktxoiihewmonegfejfngwsbcqerwbgexwgvffdstgpcgztmulbsgowdnbnmycewltoklbeuppvimivsprbhexthqnckzkamjbamimyvygbylcnxpgebgjrfskvypfaapyfmwfklujdzxlhfvnelheakqhdyszhjjnjemcdizjqvarunfzwwjtluxzuoryiihwxueizgcazbauoeyujgyebhjwbpsxcethkomaibrhgsiqaftkvulfbdlroasxwwwhnqpcplrtmnliddtblghidysvvhccsodghvyznxvkoayirzxeruxiatfsgtwsmclmoignvuwzpgqoviavasuxofgbhbmpihvragxpkbwrlsfnkvheqhoitbfvqzvbmwpvosxwdsbctiibctjjemgebwveknkelkjipgxmyvcaczmskmlzyivvttmganmruzjdrahfobbvixuspcmyboegnxiqjmdtkuhsiekyhnuggsliyoqmobfnjnzgshtvcoqwioqlatpdifctvvibotdvyfnwvmolfjltnititmzwitgynjpnxdzbonvmvrzzmzkjoazqbjqrqryftpmexqqtogugbichgzqrliidaovuiwcjmdheymovrcyypkhjorubuypgikpkxxumjybxtazmspunmubuvszqzfakdcsqyaswyeldlavrilq", 1000, "qlirvaldleywsayqscdkafzqzsvubumnupsmzatxbyjmuxxkpkigpyuburojhkpyycrvomyehdmjcwiuvoadiilrqzghcibgugotqqxemptfyrqrqjbqzaojkzmzzrvmvnobzdxnpjnygtiwzmtitintljflomvwnfyvdtobivvtcfidptalqoiwqocvthsgznjnfbomqoyilsggunhykeishuktdmjqixngeobymcpsuxivbbofhardjzurmnagmttvviyzlmksmzcacvymxgpijkleknkevwbegmejjtcbiitcbsdwxsovpwmbvzqvfbtiohqehvknfslrwbkpxgarvhipmbhbgfoxusavaivoqgpzwuvngiomlcmswtgsftaixurexzriyaokvxnzyvhgdoscchvvsydihglbtddilnmtrlpcpqnhwwwxsaorldbfluvktfaqisghrbiamokhtecxspbwjhbeygjuyeouabzacgzieuxwhiiyrouzxultjwwzfnuravqjzidcmejnjjhzsydhqkaehlenvfhlxzdjulkfwmfypaafpyvksfrjgbegpxnclybgyvymimabjmakzkcnqhtxehbrpsvimivppueblkotlwecymnbndwogsblumtzgcpgtsdffvgwxegbwreqcbswgnfjefgenomwehiioxtkaykozphlrlucfrxrofkdyoycfselmvkhqihrhyroqoclqpqxjjbmwobbhylsmaltjtmsbrmvqhpwsmiebjhjbdnoliupfwawdjqbocnuoumnxfqtirzeyqsucnvxkqktfnzgcmycrbtsdodrtdlkokhktfujweckhbowajhuovelsrqurxxdwsumaeilwatgdfwqjyjcispywgygaspawbzizslzkegqhtvdwzpceelxnsxzmvoggpaqzmvjhygegxfkqmoxrnbggxanhwqvadagvfirglrcuaodtpppgnllnhzi")]
    public void ReverseStr_WithStringAndInterval_ReversesEveryKCharacters(string s, int k, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReverseStr(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}