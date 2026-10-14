public class Solution {
    public int Search(int[] nums, int target) {
        int l=0, r=nums.Length;
        while(l<r) {
            int mid = l+(r-l) / 2;
            Console.WriteLine(mid);
            if(target == nums[mid]) return mid;
            if(target > nums[mid]) {
                l = mid+1;
            } else {
                r = mid-1;
            } 
        }
        return (l<nums.Length && nums[l] == target ? l : -1);
    }
}
