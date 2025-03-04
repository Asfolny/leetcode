public class MyNode {
    public int value;
    public MyNode next = null;
    public MyNode prev = null;

    public MyNode(int val) {
        value = val;
    }
}

public class MyLinkedList {
    MyNode head = null;
    MyNode tail = null;
    
    public int Get(int index) {
        var node = head;
        
        for (int i = 0; i < index; i++) {
            if (node == null)
                return -1;
            node = node.next;
        }

        return node?.value ?? -1;
    }
    
    public void AddAtHead(int val) {
        var node = new MyNode(val);
        node.next = head;
        if (head != null)
            head.prev = node;
        if (tail == null)
            tail = node;
        head = node;
    }
    
    public void AddAtTail(int val) {
        var node = new MyNode(val);
        node.prev = tail;
        if (tail != null)
            tail.next = node;
        if (head == null)
            head = node;
        tail = node;
    }
    
    public void AddAtIndex(int index, int val) {
        if (index == 0) {
            AddAtHead(val);
            return;
        }

        if (head == null)
            return;

        var prev = head;
        for (int i = 1; i < index; i++) {
            if (prev?.next == null)
                return;
            prev = prev.next;
        }

        var next = prev.next;
        var node = new MyNode(val);
        node.prev = prev;
        node.next = next;
        if (prev == tail)
            tail = node;
        else
            next.prev = node;
        prev.next = node;
    }
    
    public void DeleteAtIndex(int index) {
        if (index == 0) {
            DeleteAtHead();
            return;
        }

        var prev = head;

        for (int i = 1; i < index; i++) {
            if (prev.next == null)
                return;
            prev = prev.next;
        }

        var next = prev.next?.next;
        if (next != null)
            next.prev = prev;
        else
            tail = prev;
        prev.next = next;
    }

    private void DeleteAtHead() {
        if (head == null)
            return;
        head = head.next;
        if (head?.next == null) {
            tail = head;
        }
    }
}

