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

using LeetCode.Algorithms.LuckyNumbersInMatrix;

namespace LeetCode.Tests.Algorithms.LuckyNumbersInMatrix;

public abstract class LuckyNumbersInMatrixTestsBase<T> where T : ILuckyNumbersInMatrix, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void LuckyNumbers_WithMatrixJson_ReturnsLuckyNumbers(int[][] matrix, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualList = solution.LuckyNumbers(matrix);
        var actualResult = new int[actualList.Count];

        actualList.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 3, 7, 8 }, new[] { 9, 11, 13 }, new[] { 15, 16, 17 } }, new[] { 15 }];

        yield return [new[] { new[] { 1, 10, 4, 2 }, new[] { 9, 3, 8, 7 }, new[] { 15, 16, 17, 12 } }, new[] { 12 }];

        yield return [new[] { new[] { 7, 8 }, new[] { 1, 2 } }, new[] { 7 }];

        yield return [new[] { new[] { 1 } }, new[] { 1 }];

        yield return [new[] { new[] { 1, 2 } }, new[] { 1 }];

        yield return [new[] { new[] { 2, 1 } }, new[] { 1 }];

        yield return [new[] { new[] { 1 }, new[] { 2 } }, new[] { 2 }];

        yield return [new[] { new[] { 2 }, new[] { 1 } }, new[] { 2 }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 3 }];

        yield return [new[] { new[] { 4, 3 }, new[] { 2, 1 } }, new[] { 3 }];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, new[] { 7 }];

        yield return [new[] { new[] { 9, 8, 7 }, new[] { 6, 5, 4 }, new[] { 3, 2, 1 } }, new[] { 7 }];

        yield return [new[] { new[] { 100000, 1 }, new[] { 2, 3 } }, new int[] { }];

        yield return [new[] { new[] { 5, 1, 9 }, new[] { 2, 8, 3 }, new[] { 4, 6, 7 } }, new int[] { }];

        yield return [new[] { new[] { 25845, 80325 }, new[] { 3878, 15227 } }, new[] { 25845 }];

        yield return [new[] { new[] { 3315, 35296 }, new[] { 42614, 80360 } }, new[] { 42614 }];

        yield return [new[] { new[] { 25309, 23764, 89442 }, new[] { 75297, 78063, 26077 }, new[] { 50679, 93405, 97630 } }, new int[] { }];

        yield return [new[] { new[] { 15624, 35096, 87110 }, new[] { 28190, 26525, 33823 }, new[] { 17863, 47470, 69958 } }, new int[] { }];

        yield return [new[] { new[] { 87238, 18962, 67316, 40124 }, new[] { 11159, 11426, 82221, 63444 }, new[] { 39313, 82480, 72137, 53303 } }, new int[] { }];

        yield return [new[] { new[] { 55100, 43523, 76869, 26482 }, new[] { 67277, 92156, 32559, 31668 }, new[] { 39120, 35711, 50745, 38925 } }, new int[] { }];

        yield return [new[] { new[] { 21818, 25345, 79107 }, new[] { 52620, 83496, 71121 }, new[] { 44469, 29188, 34987 }, new[] { 2286, 25576, 44680 } }, new[] { 52620 }];

        yield return [new[] { new[] { 69215, 46879, 88757 }, new[] { 38606, 60941, 48649 }, new[] { 52366, 69126, 53042 }, new[] { 35956, 82242, 21128 } }, new int[] { }];

        yield return [new[] { new[] { 28626, 5093, 81008, 34757, 74760 }, new[] { 74559, 53338, 45109, 31004, 21372 }, new[] { 42755, 72202, 63180, 6574, 32317 }, new[] { 22693, 25301, 89498, 28202, 12582 }, new[] { 16117, 67626, 55351, 41169, 93832 } }, new int[] { }];

        yield return [new[] { new[] { 89378, 8033, 32135, 16741, 66982 }, new[] { 18883, 45356, 32843, 2941, 28620 }, new[] { 45177, 54464, 75781, 92599, 82598 }, new[] { 12121, 96128, 33528, 42464, 10336 }, new[] { 55126, 45943, 48681, 31266, 27944 } }, new int[] { }];

        yield return [new[] { new[] { 42238, 19178, 92210, 62385, 56549, 4534 } }, new[] { 4534 }];

        yield return [new[] { new[] { 7275, 22124, 55234, 87132, 6991, 7689 } }, new[] { 6991 }];

        yield return [new[] { new[] { 75341 }, new[] { 8676 }, new[] { 44754 }, new[] { 69113 }, new[] { 54203 }, new[] { 91770 } }, new[] { 91770 }];

        yield return [new[] { new[] { 22194 }, new[] { 75886 }, new[] { 78952 }, new[] { 48369 }, new[] { 46511 }, new[] { 36543 } }, new[] { 78952 }];

        yield return [new[] { new[] { 4355, 3369, 56983, 64390, 66843, 84979, 22823, 3139 }, new[] { 89113, 42544, 29527, 17495, 80271, 10354, 22489, 82726 }, new[] { 66015, 99705, 8115, 56288, 61851, 79477, 32507, 6867 }, new[] { 43011, 9643, 29711, 3273, 2844, 81957, 936, 76853 }, new[] { 18712, 75594, 11829, 45030, 84964, 26887, 42991, 70784 }, new[] { 96732, 4022, 7709, 62909, 78773, 16859, 22880, 18832 }, new[] { 55448, 98794, 8719, 67268, 7246, 95440, 89867, 44051 } }, new int[] { }];

        yield return [new[] { new[] { 29920, 42632, 26227, 36606, 74994, 64072, 98512, 83084 }, new[] { 73388, 86809, 85550, 24985, 71980, 93109, 27892, 32363 }, new[] { 59077, 17774, 17588, 55769, 59830, 64955, 53154, 13147 }, new[] { 88989, 90972, 13111, 83339, 52177, 22441, 93912, 85649 }, new[] { 80552, 89142, 35584, 38253, 15837, 88698, 7563, 26072 }, new[] { 91212, 20707, 67651, 2418, 53756, 20826, 23954, 18148 }, new[] { 20775, 48816, 46097, 7354, 40214, 50732, 82079, 97583 } }, new int[] { }];

        yield return [new[] { new[] { 34258, 4117, 83471, 34185, 75359, 64532, 39472, 71464, 23730, 68283 }, new[] { 92827, 93496, 32313, 66629, 10442, 4843, 76114, 75654, 68192, 36752 }, new[] { 47011, 85600, 65257, 55397, 54158, 23568, 7610, 32094, 65061, 99538 }, new[] { 5668, 62836, 34595, 6859, 10821, 37668, 72767, 71486, 49195, 23199 }, new[] { 85340, 40186, 7839, 14785, 69908, 60322, 27320, 95128, 12159, 68783 }, new[] { 68826, 57209, 34019, 41318, 2012, 47494, 46196, 64369, 84733, 71047 }, new[] { 92107, 298, 40407, 56128, 50382, 80098, 39128, 16296, 20782, 33019 }, new[] { 97774, 66307, 29099, 29778, 49767, 66295, 41660, 16640, 19332, 41703 }, new[] { 10981, 11014, 44408, 21669, 86797, 19824, 44553, 68692, 38388, 55334 }, new[] { 78482, 89472, 26358, 83142, 27304, 50146, 80853, 88846, 12842, 51280 } }, new int[] { }];

        yield return [new[] { new[] { 101, 64434, 60443, 72483, 36117, 93859, 52672, 65110, 19181, 49590 }, new[] { 39166, 62447, 41815, 6890, 39503, 32576, 27821, 84500, 85268, 70359 }, new[] { 74747, 6966, 11621, 55009, 57010, 53251, 35623, 69827, 25968, 35891 }, new[] { 52071, 30224, 56691, 26994, 70708, 28764, 80695, 67148, 75608, 55053 }, new[] { 19863, 83838, 42787, 25859, 21125, 89530, 60275, 26605, 7618, 62259 }, new[] { 90027, 45809, 87839, 22682, 40131, 84468, 37006, 74330, 43014, 28658 }, new[] { 60183, 87746, 4751, 22510, 75381, 51098, 58896, 37251, 19372, 29056 }, new[] { 66276, 41416, 64998, 57081, 25914, 1993, 35572, 89795, 49204, 98791 }, new[] { 39846, 2807, 54353, 16535, 37470, 29728, 84608, 46704, 25447, 11086 }, new[] { 78443, 35757, 75293, 86920, 61283, 37964, 95978, 91870, 86652, 86354 } }, new int[] { }];
    }
}