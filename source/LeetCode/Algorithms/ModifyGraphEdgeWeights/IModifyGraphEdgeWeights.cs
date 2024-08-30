namespace LeetCode.Algorithms.ModifyGraphEdgeWeights;

/// <summary>
///     https://leetcode.com/problems/modify-graph-edge-weights/description/
/// </summary>
public interface IModifyGraphEdgeWeights
{
    int[][] ModifiedGraphEdges(int n, int[][] edges, int source, int destination, int target);
}