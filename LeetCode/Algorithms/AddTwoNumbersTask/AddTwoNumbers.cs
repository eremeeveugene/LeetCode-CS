using LeetCode.Core.Extensions;
using LeetCode.Core.Models;

namespace LeetCode.Algorithms.AddTwoNumbersTask;

public static class AddTwoNumbers
{
    public static ListNode? GetResultV2(ListNode? l1, ListNode? l2)
    {
        var carry = 0;

        ListNode? head = null;

        while (l1 != null || l2 != null)
        {
            var val1 = l1?.val ?? 0;
            var val2 = l2?.val ?? 0;

            var sum = val1 + val2 + carry;

            carry = 0;

            if (sum > 9)
            {
                carry = 1;
                sum -= 10;
            }

            l1 = l1?.next;
            l2 = l2?.next;

            head = new ListNode(sum, head);
        }

        if (carry > 0) head = new ListNode(1, head);

        return ReverseList(head);
    }

    public static ListNode? ReverseList(ListNode? head)
    {
        ListNode? prev = null;
        var current = head;

        while (current != null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }

    public static ListNode? GetResult(ListNode? l1, ListNode? l2)
    {
        var carry = 0;
        var list1 = new List<int>();
        var list2 = new List<int>();
        var resList = new List<int>();

        while (l1 != null)
        {
            list1.Add(l1.val);

            l1 = l1.next;
        }

        while (l2 != null)
        {
            list2.Add(l2.val);

            l2 = l2.next;
        }


        for (var i = 0;; i++)
        {
            if (i >= list1.Count && i >= list2.Count) break;

            var val1 = 0;

            if (i < list1.Count) val1 = list1[i];

            var val2 = 0;

            if (i < list2.Count) val2 = list2[i];

            var resVal = val1 + val2 + carry;

            carry = 0;

            if (resVal >= 10)
            {
                carry = 1;
                resVal -= 10;
            }

            resList.Add(resVal);
        }

        if (carry > 0) resList.Add(carry);

        return resList.ToArray().ToListNode();
    }
}