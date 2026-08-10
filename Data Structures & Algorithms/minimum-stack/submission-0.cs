public class MinStack {

    private Stack<(int, int)> minStack;

    public MinStack() {
        minStack = new Stack<(int, int)>();
    }
    
    public void Push(int val) {

        int minVal = val;

        if (minStack.Count > 0){
            var top = minStack.Peek();
            minVal = (val < top.Item2 ? val : top.Item2);
        }

        minStack.Push((val, minVal));

        return;
    }
    
    public void Pop() {
        var top = minStack.Pop();
        return;
    }
    
    public int Top() {
        var top = minStack.Peek();
        return top.Item1;
    }
    
    public int GetMin() {
        var top = minStack.Peek();
        return top.Item2;
    }
}
