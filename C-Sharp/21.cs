//merge-two-lists

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
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
        
        ListNode current = new ListNode();
        ListNode currentPointer = current;

        // Init Statement
        if (list1.val < list2.val)
        {
            currentPointer.val = list1.val;
            list1 = list1.next;
        }
        else
        {
            currentPointer.val = list2.val;
            list2 = list2.next;
        }
        
        // Middle Statement
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                currentPointer.next = new ListNode(list1.val);
                currentPointer = currentPointer.next;
                list1 = list1.next;
            }
            else
            {
                currentPointer.next = new ListNode(list2.val);
                currentPointer = currentPointer.next;
                list2 = list2.next;
            }
        }

        // End check
        while (list1 != null)
        {
            currentPointer.next = new ListNode(list1.val);
            currentPointer = currentPointer.next;
            list1 = list1.next;
        }

        while (list2 != null)
        {
            currentPointer.next = new ListNode(list2.val);
            currentPointer = currentPointer.next;
            list2 = list2.next;
        }


        return current;
    }
}