using System.Collections.Generic;

public class MyStack {
    Queue<int> stack = new Queue<int>();
    Queue<int> tmp = new Queue<int>();
    
    public void Push(int x) {
        while (stack.Count > 0)
            tmp.Enqueue(stack.Dequeue());
        stack.Enqueue(x);
        while (tmp.Count > 0)
            stack.Enqueue(tmp.Dequeue());
    }
    
    public int Pop() {
        return stack.Dequeue();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public bool Empty() => stack.Count == 0;
}

