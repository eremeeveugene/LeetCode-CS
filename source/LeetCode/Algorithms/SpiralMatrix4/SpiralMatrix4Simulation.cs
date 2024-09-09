using LeetCode.Core.Models;

namespace LeetCode.Algorithms.SpiralMatrix4;

/// <inheritdoc />
public class SpiralMatrix4Simulation : ISpiralMatrix4
{
    /// <summary>
    ///     Time complexity - O(m * n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <param name="head"></param>
    /// <returns></returns>
    public int[][] SpiralMatrix(int m, int n, ListNode head)
    {
        var matrix = new int[m][];

        for (var i = 0; i < m; i++)
        {
            matrix[i] = new int[n];
        }

        var x = 0;
        var y = 0;
        var round = 0;
        var direction = 0;
        var count = 0;

        var listNode = head;

        while (count < m * n)
        {
            if (listNode == null)
            {
                matrix[x][y] = -1;
            }
            else
            {
                matrix[x][y] = listNode.val;
            }

            switch (direction)
            {
                case 0:

                    if (y + 1 < n - round)
                    {
                        y++;
                    }
                    else
                    {
                        direction = 1;

                        x++;
                    }

                    break;
                case 1:
                    if (x + 1 < m - round)
                    {
                        x++;
                    }
                    else
                    {
                        direction = 2;

                        y--;
                    }

                    break;
                case 2:
                    if (y - 1 < round)
                    {
                        direction = 3;

                        round++;

                        x--;
                    }
                    else
                    {
                        y--;
                    }

                    break;
                case 3:
                    if (x - 1 < round)
                    {
                        direction = 0;

                        y++;
                    }
                    else
                    {
                        x--;
                    }

                    break;
            }

            listNode = listNode?.next;
            count++;
        }

        return matrix;
    }
}