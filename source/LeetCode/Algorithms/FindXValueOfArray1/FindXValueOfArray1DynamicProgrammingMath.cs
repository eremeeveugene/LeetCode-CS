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

namespace LeetCode.Algorithms.FindXValueOfArray1;

/// <inheritdoc />
public sealed class FindXValueOfArray1DynamicProgrammingMath : IFindXValueOfArray1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public long[] ResultArray(int[] nums, int k)
    {
        return k switch
        {
            1 => ResultArrayModulo1(nums),
            2 => ResultArrayModulo2(nums),
            3 => ResultArrayModulo3(nums),
            4 => ResultArrayModulo4(nums),
            _ => ResultArrayModulo5(nums)
        };
    }

    private static long[] ResultArrayModulo1(int[] nums)
    {
        var n = nums.Length;

        return [(long)n * (n + 1) / 2];
    }

    private static long[] ResultArrayModulo2(int[] nums)
    {
        var n = nums.Length;

        long result0 = 0;
        long result1 = 0;
        long count0 = 0;
        long count1 = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            if (num % 2 == 0)
            {
                count0 += count1 + 1;
                count1 = 0;
            }
            else
            {
                count1++;
            }

            result0 += count0;
            result1 += count1;
        }

        return [result0, result1];
    }

    private static long[] ResultArrayModulo3(int[] nums)
    {
        var n = nums.Length;

        long result0 = 0;
        long result1 = 0;
        long result2 = 0;
        long count0 = 0;
        long count1 = 0;
        long count2 = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            switch (num % 3)
            {
                case 0:
                    count0 += count1 + count2 + 1;
                    count1 = 0;
                    count2 = 0;
                    break;
                case 1:
                    count1++;
                    break;
                default:
                    (count1, count2) = (count2, count1 + 1);
                    break;
            }

            result0 += count0;
            result1 += count1;
            result2 += count2;
        }

        return [result0, result1, result2];
    }

    private static long[] ResultArrayModulo4(int[] nums)
    {
        var n = nums.Length;

        long result0 = 0;
        long result1 = 0;
        long result2 = 0;
        long result3 = 0;
        long count0 = 0;
        long count1 = 0;
        long count2 = 0;
        long count3 = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            switch (num % 4)
            {
                case 0:
                    count0 += count1 + count2 + count3 + 1;
                    count1 = 0;
                    count2 = 0;
                    count3 = 0;
                    break;
                case 1:
                    count1++;
                    break;
                case 2:
                    count0 += count2;
                    count2 = count1 + count3 + 1;
                    count1 = 0;
                    count3 = 0;
                    break;
                default:
                    (count1, count3) = (count3, count1 + 1);
                    break;
            }

            result0 += count0;
            result1 += count1;
            result2 += count2;
            result3 += count3;
        }

        return [result0, result1, result2, result3];
    }

    private static long[] ResultArrayModulo5(int[] nums)
    {
        var n = nums.Length;

        long result0 = 0;
        long result1 = 0;
        long result2 = 0;
        long result3 = 0;
        long result4 = 0;
        long count0 = 0;
        long count1 = 0;
        long count2 = 0;
        long count3 = 0;
        long count4 = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            switch (num % 5)
            {
                case 0:
                    count0 += count1 + count2 + count3 + count4 + 1;
                    count1 = 0;
                    count2 = 0;
                    count3 = 0;
                    count4 = 0;
                    break;
                case 1:
                    count1++;
                    break;
                case 2:
                    (count1, count2, count3, count4) = (count3, count1 + 1, count4, count2);
                    break;
                case 3:
                    (count1, count2, count3, count4) = (count2, count4, count1 + 1, count3);
                    break;
                default:
                    (count1, count2, count3, count4) = (count4, count3, count2, count1 + 1);
                    break;
            }

            result0 += count0;
            result1 += count1;
            result2 += count2;
            result3 += count3;
            result4 += count4;
        }

        return [result0, result1, result2, result3, result4];
    }
}