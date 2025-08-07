public class MinStack {

    Stack<int> min;
    Stack<int> nums;

    public MinStack() {
        min = new();
        nums = new();
    }
    
    public void Push(int val) {
        if(min.Count > 0)
        {
            var curMin = min.Peek();
            if(curMin >= val)
                min.Push(val);
        }
        else
        {
            min.Push(val);
        }

        nums.Push(val);
    }
    
    public void Pop() {
        var top = nums.Pop();
        if(min.Count > 0 && min.Peek() == top)
            min.Pop();
    }
    
    public int Top() {
        return nums.Peek();
    }
    
    public int GetMin() {
        return min.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */