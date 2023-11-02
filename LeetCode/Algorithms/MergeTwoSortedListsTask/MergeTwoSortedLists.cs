namespace LeetCode.Algorithms.MergeTwoSortedListsTask;

public static class MergeTwoSortedLists
{
    public static ListNode? GetResult(ListNode? list1, ListNode? list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }

        if (list1 == null && list2 != null)
        {
            return list2;
        }

        if (list1 != null && list2 == null)
        {
            return list1;
        }

        if (list1 != null && list2 != null)
        {
            ListNode? headNode = null;

            ListNode? previousNode = null;

            while (list1 != null || list2 != null)
            {
                if (list1 == null && list2 != null)
                {
                    var list2CurrentNode = new ListNode(list2.Value);

                    if (previousNode != null) previousNode.NextNode = list2CurrentNode;

                    previousNode = list2CurrentNode;

                    if (headNode == null)
                    {
                        headNode = list2CurrentNode;
                    }

                    list2 = list2.NextNode;

                    continue;
                }
                
                if (list1 != null && list2 == null)
                {
                    var list1CurrentNode = new ListNode(list1.Value);

                    if (previousNode != null) previousNode.NextNode = list1CurrentNode;

                    previousNode = list1CurrentNode;

                    if (headNode == null)
                    {
                        headNode = list1CurrentNode;
                    }

                    list1 = list1.NextNode;

                    continue;
                }

                if (list1.Value < list2.Value)
                {
                    var list1CurrentNode = new ListNode(list1.Value);

                    if (previousNode != null) previousNode.NextNode = list1CurrentNode;

                    previousNode = list1CurrentNode;

                    if (headNode == null)
                    {
                        headNode = list1CurrentNode;
                    }

                    list1 = list1.NextNode;
                }
                else
                {
                    var list2CurrentNode = new ListNode(list2.Value);

                    if (previousNode != null) previousNode.NextNode = list2CurrentNode;

                    previousNode = list2CurrentNode;

                    if (headNode == null)
                    {
                        headNode = list2CurrentNode;
                    }

                    list2 = list2.NextNode;
                }
            }

            return headNode;
        }

        return null;
    }
}