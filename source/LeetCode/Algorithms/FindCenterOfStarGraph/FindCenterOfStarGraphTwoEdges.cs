namespace LeetCode.Algorithms.FindCenterOfStarGraph;

/// <inheritdoc />
public class FindCenterOfStarGraphTwoEdges : IFindCenterOfStarGraph
{
    /// <summary>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="edges"></param>
    /// <returns></returns>
    public int FindCenter(int[][] edges)
    {
        if (edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1])
        {
            return edges[0][0];
        }

        return edges[0][1];
    }
}