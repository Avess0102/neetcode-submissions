public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[n];
        int total = 1, z=0;
        foreach(int num in nums) {
            if(num!=0) {
                total *= num;
            } else {
                z++;
            }
        }
        if(z>1) {
            return ans;
        }
        for(int i = 0; i < n; i++) {
            if(z > 0) {
                ans[i] = (nums[i] == 0) ? total : 0;
            } else {
                ans[i] = total/nums[i];
            }
        }
        return ans;
    }
}
