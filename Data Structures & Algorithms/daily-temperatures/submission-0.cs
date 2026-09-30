public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> st = new Stack<int>();
        int[] res = new int[temperatures.Length];
        st.Push(0);
        for(int i=1;i<temperatures.Length;i++) {
            while(st.Count != 0 && temperatures[i] > temperatures[st.Peek()]) {
                res[st.Peek()] = i - st.Peek();
                st.Pop();
            }
            st.Push(i);
        }
        return res;
    }
}
