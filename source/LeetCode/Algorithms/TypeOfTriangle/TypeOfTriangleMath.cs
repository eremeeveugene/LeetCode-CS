// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.TypeOfTriangle;

/// <summary>
///     https://leetcode.com/problems/type-of-triangle/description/
/// </summary>
public class TypeOfTriangleMath : ITypeOfTriangle
{
    private const string Equilateral = "equilateral";
    private const string Scalene = "scalene";
    private const string Isosceles = "isosceles";
    private const string None = "none";

    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public string TriangleType(int[] nums)
    {
        if (nums[0] + nums[1] <= nums[2] || nums[1] + nums[2] <= nums[0] || nums[2] + nums[0] <= nums[1])
        {
            return None;
        }

        if (nums[0] == nums[1] && nums[1] == nums[2])
        {
            return Equilateral;
        }

        if (nums[0] == nums[1] || nums[1] == nums[2] || nums[2] == nums[0])
        {
            return Isosceles;
        }

        return Scalene;
    }
}