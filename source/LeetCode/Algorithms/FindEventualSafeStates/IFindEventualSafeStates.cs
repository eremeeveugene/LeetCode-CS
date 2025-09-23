namespace LeetCode.Algorithms.FindEventualSafeStates;

/// <summary>
///     https://leetcode.com/problems/find-eventual-safe-states/description/
/// </summary>
public interface IFindEventualSafeStates
{
    IList<int> EventualSafeNodes(int[][] graph);
}