// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.CombinationSum2;

/// <inheritdoc />
public class CombinationSum2Backtracking : ICombinationSum2
{
    /// <summary>
    ///     Time complexity - O(2^n * k)
    ///     Space complexity - O(2^n * k)
    /// </summary>
    /// <param name="candidates"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);

        var result = new List<IList<int>>();

        Backtrack(result, new List<int>(), candidates, target, 0);

        return result;
    }

    private static void Backtrack(ICollection<IList<int>> result, IList<int> tempList, IReadOnlyList<int> candidates,
        int remain, int start)
    {
        switch (remain)
        {
            case < 0:
                break;
            case 0:
                result.Add(new List<int>(tempList));
                break;
            default:
                {
                    for (var i = start; i < candidates.Count; i++)
                    {
                        if (i > start && candidates[i] == candidates[i - 1])
                        {
                            continue;
                        }

                        tempList.Add(candidates[i]);

                        Backtrack(result, tempList, candidates, remain - candidates[i], i + 1);

                        tempList.RemoveAt(tempList.Count - 1);
                    }

                    break;
                }
        }
    }
}