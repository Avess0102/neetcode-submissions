public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int x = -1, r=matrix[0].Length, l=0;
        for(int i=0;i<matrix.Length;i++) {
            if(target >= matrix[i][l] && target <= matrix[i][r-1]) {
                x = i;
                break;
            }
        }
        if(x == -1) return false;
        Console.WriteLine(x);
        while(l<r) {
            int mid = l + (r-l)/2;
            if(target == matrix[x][mid]) return true;
            if(target > matrix[x][mid]) {
                l = mid + 1;
            } else {
                r = mid - 1;
            }
        }
        return (matrix[x][l] == target || matrix[x][r] == target) ? true : false;
    }
}
