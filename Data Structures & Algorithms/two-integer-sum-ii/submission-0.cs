public class Solution {
    public int[] TwoSum(int[] num, int target) {
        Array.Sort(num);
        int i=0, j=num.Length - 1;
        while(i<j) {
            if(num[i] + num[j] > target) {
                j--;
            }
            if(num[i] + num[j] < target) {
                i++;
            }
            if(num[i] + num[j] == target) {
                return [i+1, j+1];
            }
        }
        return new int[0];
    }
}
