namespace LeetCode.Algorithms.FindCenterOfStarGraph;

/// <inheritdoc />
public class FindCenterOfStarGraphDictionary : IFindCenterOfStarGraph
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="edges"></param>
    /// <returns></returns>
    public int FindCenter(int[][] edges)
    {
        var dictionary = new Dictionary<int, int>();

        foreach (var edge in edges)
        {
            if (!dictionary.TryAdd(edge[0], 1))
            {
                dictionary[edge[0]]++;
            }

            if (!dictionary.TryAdd(edge[1], 1))
            {
                dictionary[edge[1]]++;
            }
        }

        foreach (var item in dictionary.Where(item => item.Value == edges.Length))
        {
            return item.Key;
        }

        return -1;
    }
}