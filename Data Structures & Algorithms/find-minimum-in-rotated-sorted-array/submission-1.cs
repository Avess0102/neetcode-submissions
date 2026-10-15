public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length-1;
        while(l<r) {
            int k = l + (r-l) / 2;
            if(nums[k]<nums[r]) {
                r = k;
            } else {
                l = k+1;
            }
        }
        return nums[l];

    }
}
