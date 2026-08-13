public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // foreach(int num in nums) {
        //     Console.WriteLine(num);
        // }
        List<List<int>> res = new List<List<int>> ();
        int n = nums.Length;
        Array.Sort(nums);
        for (int i = 0; i < n; i++) {
            if(nums[i] > 0) break;
            if(i>0 && nums[i] == nums[i-1]) continue;
            int j = i+1, k = n-1;
            while(j<k) {
                int sum = nums[i] + nums[j] + nums[k];
                // Console.WriteLine(nums[i] + nums[j] + nums[k]);
                if(sum > 0) k--;
                else if(sum < 0) j++;
                else {
                    res.Add(new List<int> {nums[i], nums[j], nums[k]});
                    j++;
                    k--;
                    while (j < k && nums[j] == nums[j - 1]) {
                        j++;
                    }
                }
            }
        }
        return res;
    }
}
