public class Solution {
    public int MaxArea(int[] heights) {
        int n = heights.Length-1, i =0;
        int res = 0;
        while(i<n) {
            res = Math.Max(res, Math.Min(heights[i], heights[n]) * (n - i));
            if(heights[i] >= heights[n]) {
                n--;
            } else {
                i++;
            }
        }
        return res;
    }
}
