public class Solution {
    public int doCalculation(string c, int a, int b) {
        int result = 0;
        switch(c) {
            case "+":
                result = a+b;
                break;
            case "-":
                result = b-a;
                break;
            case "*":
                result = a*b;
                break;
            case "/":
                result = (int)b/a;
                break;
            default:
                break;
        }
        return result;
    }
    public int EvalRPN(string[] tokens) {
        Stack<int> t = new Stack<int>();
        List<string> op = ["+", "-", "/", "*"];

        foreach(string c in tokens) {
            if(op.Contains(c)) {
                int a = t.Pop();
                int b = t.Pop();
                t.Push(doCalculation(c, a, b));
            } else {
                t.Push(int.Parse(c));
            }
        }
        return t.Pop();

    }
}
