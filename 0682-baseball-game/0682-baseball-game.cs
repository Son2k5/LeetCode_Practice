public class Solution {
    public int CalPoints(string[] ops) {
        var stack = new Stack<int>();
        foreach(var op in ops){
            if(op == "+"){
                int top = stack.Pop();
                int newTop = top + stack.Peek();
                stack.Push(top);
                stack.Push(newTop);
            }
            else if(op == "D") stack.Push(stack.Peek() * 2);
            else if(op == "C") stack.Pop();
            else stack.Push(int.Parse(op));

        }
        return stack.Sum();
    }
}