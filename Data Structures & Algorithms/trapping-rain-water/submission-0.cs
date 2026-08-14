public class Solution {
    public int Trap(int[] height) {
        int l=0, r = height.Length - 1;
        int res = 0, sum = 0;
        int leftMax = height[l], rightMax = height[r];
        while(l < r) {
            if(leftMax < rightMax) {
                l++;
                leftMax = Math.Max(leftMax, height[l]);
                res += leftMax - height[l];
            } else {
                r--;
                rightMax = Math.Max(rightMax, height[r]);
                res += rightMax - height[r];                
            }
        }
        return res;
    }
}
